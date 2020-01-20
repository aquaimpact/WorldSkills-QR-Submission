using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class UpdateCompetitorTrainingRecords : Form
    {
        User users;
        public UpdateCompetitorTrainingRecords(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void UpdateCompetitorTrainingRecords_Load(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                var q = db.Skills.ToList();
                foreach (var item in q)
                {
                    if (item.skillId == 5)
                    {
                        continue;
                    }
                    else
                    {
                        skill.Items.Add(item.skillName);
                    }
                }



                progress.Items.Add("Completed");
                progress.Items.Add("In Progress");
                progress.Items.Add("Not Started");


            }
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                var index = skill.SelectedIndex + 1;
                var q2 = db.Users.Where(x => x.skillIdFK == index && x.userTypeIdFK == 3).ToList();
                compsname.Text = null;
                compsname.Items.Clear();
                foreach (var item in q2)
                {
                    compsname.Items.Add(item.name.Trim());
                }
            }
        }

        private void compsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                var val = compsname.Text;
                var q = db.Assign_Training.Where(x => x.User.name.Trim() == val).ToList();
                dataGridView1.DataSource = cdt(q);
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        DataTable cdt(List<Assign_Training> assignTrainings)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Training Module");
            dt.Columns.Add("Duration (Days)");
            dt.Columns.Add("Start Date");
            dt.Columns.Add("Estimated End Date");
            dt.Columns.Add("Progress (%)");
            foreach (var item in assignTrainings)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = item.trainingId;
                dr["Training Module"] = item.Training_Module.moduleName;
                dr["Duration (Days)"] = item.Training_Module.durationDays;
                dr["Start Date"] = item.startDate;
                var dates = item.startDate.AddDays(item.Training_Module.durationDays);
                dr["Estimated End Date"] = dates;
                dr["Progress (%)"] = item.progress;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if(dr.Cells["ID"].Value != null)
                {
                    if (dr.Cells["Progress (%)"].Value.ToString().Contains("."))
                    {
                        MessageBox.Show("Progress cannot be decimals!");
                        return;
                    }
                    var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                    var progress = dr.Cells["Progress (%)"].Value.ToString();
                    if (int.Parse(progress) >= 0 && int.Parse(progress) <= 100)
                    {
                        using (var db = new Session4Entities())
                        {
                            var lol = db.Assign_Training.Where(x => x.trainingId == ID).FirstOrDefault();
                            if(lol.progress > int.Parse(progress))
                            {
                                MessageBox.Show("Can only increase not decrease progress!");
                                return;
                            }
                            lol.progress = int.Parse(progress);
                            try
                            {
                                db.SaveChanges();
                            }
                            catch (Exception es)
                            {
                                MessageBox.Show(es.ToString());
                            }
                            MessageBox.Show("Success!");
                            filter();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

        #region Start Sorting
        private void Sortname_CheckedChanged(object sender, EventArgs e)
        {
            filter();

            //OLD CODE CAN REUSE!
            //using (var db = new Session4Entities())
            //{
            //    var val = compsname.Text;
            //    var lol = db.Assign_Training.Where(x => x.User.name == val).OrderBy(x => x.Training_Module.moduleName).ToList();
            //    dataGridView1.DataSource = cdt(lol);
            //    dataGridView1.Columns["ID"].Visible = false;
            //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //}
        }

        private void SortDate_CheckedChanged(object sender, EventArgs e)
        {
            filter();
            //using (var db = new Session4Entities())
            //{
            //    var val = compsname.Text;
            //    var lol = db.Assign_Training.ToList();
            //    var lol2 = lol.Where(x => x.User.name == val).OrderBy(x => new { date = x.startDate.AddDays(x.Training_Module.durationDays) }).ToList();
            //    dataGridView1.DataSource = cdt(lol2);
            //    dataGridView1.Columns["ID"].Visible = false;
            //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //}
        }
        #endregion

        #region Start Filtering
        private void mods_TextChanged(object sender, EventArgs e)
        {
            filter();

            //OLD CODE CAN REUSE!
            //using (var db = new Session4Entities())
            //{
            //    var val = compsname.Text;
            //    var stuff = mods.Text;
            //    var lol = db.Assign_Training.Where(x => x.Training_Module.moduleName.Contains(mods.Text) && x.User.name == val).ToList();
            //    dataGridView1.DataSource = cdt(lol);
            //    dataGridView1.Columns["ID"].Visible = false;
            //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //}
        }

        private void progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();

            //OLD CODE! CAN REUSE
            //using (var db = new Session4Entities())
            //{
            //    var val = compsname.Text;
            //    var stuff = progress.Text;
            //    if (stuff == "Completed")
            //    {
            //        var lol = db.Assign_Training.Where(x => x.progress == 100 && x.User.name == val).ToList();
            //        dataGridView1.DataSource = cdt(lol);
            //        dataGridView1.Columns["ID"].Visible = false;
            //        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    }
            //    else if (stuff == "In Progress")
            //    {
            //        var lol = db.Assign_Training.Where(x => x.progress <= 100 && x.progress >= 1 && x.User.name == val).ToList();
            //        dataGridView1.DataSource = cdt(lol);
            //        dataGridView1.Columns["ID"].Visible = false;
            //        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    }
            //    else
            //    {
            //        var lol = db.Assign_Training.Where(x => x.progress == 0 && x.User.name == val).ToList();
            //        dataGridView1.DataSource = cdt(lol);
            //        dataGridView1.Columns["ID"].Visible = false;
            //        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    }

            //}
        }
        #endregion

        void filter()
        {
            //var nameC = Sortname.Checked ? 1 : 0;
            //var dateC = SortDate.Checked ? 1 : 0;
            using (var db = new Session4Entities())
            {
                var val = compsname.Text;
                var q = db.Assign_Training.Where(x => x.User.name.Trim() == val).ToList();
                if (Sortname.Checked)
                {
                    q = q.OrderBy(x => x.Training_Module.moduleName).ToList();
                }
                if (SortDate.Checked)
                {
                    q = q.OrderByDescending(x => x.startDate.AddDays(x.Training_Module.durationDays)).ToList();
                }
                if(string.IsNullOrEmpty(mods.Text) == false)
                {
                    q = q.Where(x => x.Training_Module.moduleName.Contains(mods.Text)).ToList();
                }
                if(string.IsNullOrEmpty(progress.Text) == false)
                {
                    var stuff = progress.Text;
                    if (stuff == "Completed")
                    {
                        q = q.Where(x => x.progress == 100).ToList();
                    }
                    else if (stuff == "In Progress")
                    {
                        q = q.Where(x => x.progress <= 100 && x.progress >= 1).ToList();
                    }
                    else
                    {
                        q = q.Where(x => x.progress == 0).ToList();
                    }
                }

                dataGridView1.DataSource = cdt(q);
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
