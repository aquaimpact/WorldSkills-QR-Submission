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
    public partial class UpdateExpertTrainingRecords : Form
    {
        User users;
        public UpdateExpertTrainingRecords(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpertMainMenu expertMainMenu = new ExpertMainMenu(users);
            expertMainMenu.Show();
        }

        private void UpdateExpertTrainingRecords_Load(object sender, EventArgs e)
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
            }
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                var index = skill.SelectedIndex + 1;
                var q2 = db.Users.Where(x => x.skillIdFK == index && x.userTypeIdFK == 2).ToList();
                compsname.Items.Clear();
                foreach (var item in q2)
                {
                    compsname.Items.Add(item.name.Trim());
                }
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

        private void compsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["ID"].Value != null)
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
                            if (lol.progress > int.Parse(progress))
                            {
                                MessageBox.Show("Can only increase not decrease progress!");
                                return;
                            }
                            lol.progress = int.Parse(progress);
                            try
                            {
                                db.SaveChanges();
                                MessageBox.Show("Success!");
                                filter();
                            }
                            catch (Exception es)
                            {
                                MessageBox.Show(es.ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

        private void SortDate_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void Sortname_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        void filter()
        {
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

                dataGridView1.DataSource = cdt(q);
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        var ED = DateTime.Parse(dr.Cells["Estimated End Date"].Value.ToString());
                        var timeleft = ED - DateTime.Now;

                        //Show this if cher dont believe
                        //MessageBox.Show(timeleft.Days.ToString());
                        if (timeleft.Days <= 14)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        if (timeleft.Days <= 5)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Red;

                        }
                    }
                }
            }
        }
    }
}
