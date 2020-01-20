using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class ResouceManagement : Form
    {
        public ResouceManagement()
        {
            InitializeComponent();
        }

        private void ResouceManagement_Load(object sender, EventArgs e)
        {
            using (var db = new Session1Entities())
            {
                var query = db.Resources.OrderBy(x => x.remainingQuantity).ToList();
                dataGridView1.DataSource = CDT(query);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells["Available Quantity"].Value.ToString() == "Not Available")
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                //Filter not working.
                var query2 = db.Resource_Type.ToList();
                foreach (var item in query2)
                {
                    type.Items.Add(item.resTypeName);
                }

                var query3 = db.Skills.ToList();
                foreach (var item in query3)
                {
                    Skill.Items.Add(item.skillName);
                }


            }
        }

        DataTable CDT(List<Resource> resources)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("No of Skills");
            dt.Columns.Add("Allocated Skill(s)");
            dt.Columns.Add("Available Quantity");
            using (var db = new Session1Entities())
            {
                foreach (var item in resources)
                {
                    DataRow dr = dt.NewRow();
                    var vals = item.resId;
                    var val = db.Resources.Where(x => x.resId == vals).FirstOrDefault();
                    dr["ID"] = val.resId;
                    dr["Name"] = val.resName;
                    dr["Type"] = val.Resource_Type.resTypeName;
                    if (val.remainingQuantity > 5)
                    {
                        dr["Available Quantity"] = "Sufficiet";
                    }
                    else if (val.remainingQuantity >= 1 && val.remainingQuantity <= 5)
                    {
                        dr["Available Quantity"] = "Low Stock";
                    }

                    if (val.remainingQuantity == 0)
                    {
                        dr["Available Quantity"] = "Not Available";
                    }
                    int count = 0;
                    string skills = "Nil";

                    var q = db.Resource_Allocation.Where(x => x.resIdFK == vals);
                    if(q.FirstOrDefault() != null)
                    {
                        foreach (var items in q.ToList())
                        {
                            if (skills == "Nil")
                            {
                                skills = items.Skill.skillName;
                                count += 1;
                            }
                            else
                            {
                                skills += ", " + items.Skill.skillName.ToString();
                                count += 1;
                            }

                        }
                    }
                    dr["Allocated Skill(s)"] = skills;
                    
                    dr["No of Skills"] = count;
                    dt.Rows.Add(dr);
                }
                return dt;

            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddResource addResource = new AddResource();
            addResource.Show();
            this.Hide();
            using (var db = new Session1Entities())
            {
                var q = db.Resources.ToList();
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells["Available Quantity"].Value.ToString() == "Not Available")
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                using (var db = new Session1Entities())
                {
                    var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                    
                    var query = db.Resources.Where(x => x.resId == ID).FirstOrDefault();
                    db.Resources.Remove(query);

                    var query2 = db.Resource_Allocation.Where(x => x.resIdFK == ID).ToList();
                    foreach(var item in query2)
                    {
                        db.Resource_Allocation.Remove(item);
                    }
                    try { 
                        db.SaveChanges();
                        MessageBox.Show("Deleted Successfully!");
                        var q = db.Resources.ToList();
                        dataGridView1.DataSource = CDT(q);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.Columns["ID"].Visible = false;
                        foreach (DataGridViewRow datar in dataGridView1.Rows)
                        {
                            if (datar.Cells["Available Quantity"].ToString() == "Not Available")
                            {
                                datar.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                    catch(Exception es) { MessageBox.Show(es.ToString()); }
                }
            }

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                    Update_Resource update_Resource = new Update_Resource(ID);
                    update_Resource.Show();
                    this.Hide();
                    using (var db = new Session1Entities())
                    {
                        var q = db.Resources.ToList();
                        dataGridView1.DataSource = CDT(q);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.Columns["ID"].Visible = false;
                        foreach (DataGridViewRow datar in dataGridView1.Rows)
                        {
                            if (datar.Cells["Available Quantity"].Value.ToString() == "Not Available")
                            {
                                datar.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            
        }

        void filter()
        {
            using (var db = new Session1Entities())
            {
                var q = db.Resources.ToList();
                if (string.IsNullOrEmpty(type.Text) == false)
                {
                    var IDss = type.SelectedIndex + 1;
                    q = q.Where(x => x.resTypeIdFK == IDss).ToList();
                   
                }
                if(string.IsNullOrEmpty(Skill.Text) == false)
                {
                    List<Resource> resources = new List<Resource>();
                    var query = db.Resource_Allocation.Where(x => x.Skill.skillName == Skill.Text).ToList();
                    foreach(var item in query)
                    {
                        var res = q.Where(x => x.resId == item.resIdFK).FirstOrDefault();
                        if (res != null)
                        {
                            resources.Add(res);
                        }
                    }
                    q = resources;
                }
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
                foreach (DataGridViewRow datar in dataGridView1.Rows)
                {
                    if (datar.Cells["Available Quantity"].Value.ToString() == "Not Available")
                    {
                        datar.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResourcemanagerLogin resourcemanagerLogin = new ResourcemanagerLogin();
            resourcemanagerLogin.Show();
        }

        private void Skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }
    }

    //FILTERTING
    //private void type_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    using (var db = new Session1Entities())
    //    {
    //        if (Skill.Text == null)
    //        {
    //            var query = db.Resources.Where(x => x.Resource_Type.resTypeName == type.Text);

    //        }
    //        else
    //        {

    //        }
    //    }

    //}
}
