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
    public partial class Update_Resource : Form
    {
        int IDs;
        public Update_Resource(int ID)
        {
            InitializeComponent();
            IDs = ID;
        }

        private void Update_Resource_Load(object sender, EventArgs e)
        {
            using (var db = new Session1Entities())
            {
                var query = db.Resources.Where(x => x.resId == IDs).FirstOrDefault();
                LblName.Text = query.resName;
                typeLbl.Text = query.Resource_Type.resTypeName;
                quantity.Value = query.remainingQuantity;
                if (quantity.Value == 0)
                {
                    skills.Visible = false;
                }
                var query2 = db.Skills.ToList();
                foreach (var item in query2)
                {
                    skills.Items.Add(item.skillName);
                }
                var query3 = db.Resource_Allocation.Where(x => x.resIdFK == IDs);
                foreach (var item in query3)
                {
                    skills.SetItemChecked(item.Skill.skillId, true);
                }
            }
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            if(quantity.Value == 0)
            {
                skills.Visible = false;
            }
            else
            {
                skills.Visible = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (var db = new Session1Entities())
            {
                var query = db.Resources.Where(x => x.resId == IDs).FirstOrDefault();
                query.remainingQuantity = (int)quantity.Value;

                if(skills.Visible == false)
                {
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Successful!");
                        this.Hide();
                        ResouceManagement resouceManagement = new ResouceManagement();
                        resouceManagement.Show();
                    }
                    catch(Exception ES)
                    {
                        MessageBox.Show(ES.ToString());
                    }
                }
                else
                {
                    var query2 = db.Resource_Allocation.Where(x => x.resIdFK == IDs).ToList();
                    foreach (var item in query2)
                    {
                        db.Resource_Allocation.Remove(item);
                    }
                    for(int i = 0; i < skills.CheckedItems.Count; i++)
                    {
                        Resource_Allocation resource_Allocation = new Resource_Allocation();
                        resource_Allocation.resIdFK = IDs;
                        resource_Allocation.skillIdFK = i + 1;
                        db.Resource_Allocation.Add(resource_Allocation);
                    }
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Successful!");
                        this.Hide();
                        ResouceManagement resouceManagement = new ResouceManagement();
                        resouceManagement.Show();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResouceManagement resouceManagement = new ResouceManagement();
            resouceManagement.Show();
        }
    }
}
