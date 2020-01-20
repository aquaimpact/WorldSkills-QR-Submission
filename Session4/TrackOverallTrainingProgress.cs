using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Session4
{
    public partial class TrackOverallTrainingProgress : Form
    {
        User users;
        public TrackOverallTrainingProgress(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu(users);
            adminMainMenu.Show();

        }

        private void TrackOverallTrainingProgress_Load(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
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
            dataGridView2.DataSource = dt1(-1);
            dataGridView1.DataSource = dt2();
            dataGridView3.DataSource = dt3();
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Completed"));
            chart1.Series.Add(new Series("In Progress"));
            chart1.Series.Add(new Series("Not Started"));
            chart1.Legends[0].Docking = Docking.Bottom;
        }

        #region Data Grid Views
        //For the main big one
        DataTable dt1(int filter)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Trainee Catagory");
            using(var db = new Session4Entities())
            {
                var q = db.Assign_Training.Select(x => new { x.startDate.Month, x.startDate.Year}).Distinct().OrderBy(x => new { x.Month}).ToList();

                foreach(var item in q)
                {
                    var lol = CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[item.Month - 1];
                    //MessageBox.Show("No of Training Modules Start in " + item.Month.ToString() + " " + item.Year.ToString());
                    dt.Columns.Add("No of Training Modules Start in " + lol + " " + item.Year.ToString());
                }

                //For Competitor
                
                if (filter != -1)
                {
                    var q2 = db.Assign_Training.Where(x => x.User.userTypeIdFK == 3 && x.User.skillIdFK == filter).GroupBy(x => new { x.startDate.Month, x.startDate.Year }).ToList();
                    DataRow dr = dt.NewRow();
                    dr["Trainee Catagory"] = "Competitor";
                    foreach (var item in q2)
                    {
                        var lol = CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[item.Key.Month - 1];
                        dr["No of Training Modules Start in " + lol + " " + item.Key.Year.ToString()] = item.Select(x => x.moduleIdFK).Distinct().Count();
                    }
                    dt.Rows.Add(dr);
                }
                else
                {
                    var q2 = db.Assign_Training.Where(x => x.User.userTypeIdFK == 3).GroupBy(x => new { x.startDate.Month, x.startDate.Year }).ToList();
                    DataRow dr = dt.NewRow();
                    dr["Trainee Catagory"] = "Competitor";
                    foreach (var item in q2)
                    {
                        var lol = CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[item.Key.Month - 1];
                        dr["No of Training Modules Start in " + lol.ToString() + " " + item.Key.Year.ToString()] = item.Select(x => x.moduleIdFK).Distinct().Count();
                    }
                    dt.Rows.Add(dr);
                }
                
                //For Experts
                if(filter != -1)
                {
                    var q3 = db.Assign_Training.Where(x => x.User.userTypeIdFK == 2 && x.User.skillIdFK == filter).GroupBy(x => new { x.startDate.Month, x.startDate.Year }).ToList();
                    DataRow dr2 = dt.NewRow();
                    dr2["Trainee Catagory"] = "Experts";
                    foreach (var item in q3)
                    {
                        var lol = CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[item.Key.Month - 1];
                        dr2["No of Training Modules Start in " + lol.ToString() + " " + item.Key.Year.ToString()] = item.Select(x => x.moduleIdFK).Distinct().Count();
                    }
                    dt.Rows.Add(dr2);
                }
                else
                {
                    var q3 = db.Assign_Training.Where(x => x.User.userTypeIdFK == 2).GroupBy(x => new { x.startDate.Month, x.startDate.Year }).ToList();
                    DataRow dr2 = dt.NewRow();
                    dr2["Trainee Catagory"] = "Experts";
                    foreach (var item in q3)
                    {
                        var lol = CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames[item.Key.Month - 1];
                        dr2["No of Training Modules Start in " + lol.ToString() + " " + item.Key.Year.ToString()] = item.Select(x => x.moduleIdFK).Distinct().Count();
                    }
                    dt.Rows.Add(dr2);
                }
                
            }
            return dt;
        }

        //For the Experts columns
        DataTable dt2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Status (Experts)");
            using (var db = new Session4Entities())
            {
                var selected = skill.SelectedIndex + 1;
                var q = db.Training_Module.Where(x => x.skillIdFK == selected && x.userTypeIdFK == 2).ToList();

                //Go through each training module and add the mod name
                foreach (var item in q)
                {
                    var q1 = db.Assign_Training.Where(x => x.moduleIdFK == item.moduleId).FirstOrDefault();
                    if (q1 != null)
                    {
                        dt.Columns.Add(item.moduleName);
                    }
                }

                var q2 = db.Assign_Training.Where(x => x.progress == 100 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 2).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr = dt.NewRow();
                dr["Status (Experts)"] = "Completed";
                foreach (var item in q2)
                {
                    MessageBox.Show(item.Key);
                    dr[item.Key] = item.Count();
                }
                dt.Rows.Add(dr);

                //Progress
                var q3 = db.Assign_Training.Where(x => x.progress < 100 && x.progress > 1 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 2).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr2 = dt.NewRow();
                dr2["Status (Experts)"] = "In Progress";
                foreach (var item in q3)
                {
                    dr2[item.Key] = item.Count();
                }
                dt.Rows.Add(dr2);

                var q4 = db.Assign_Training.Where(x => x.progress == 0 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 2).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr3 = dt.NewRow();
                dr3["Status (Experts)"] = "Not Started";
                foreach (var item in q4)
                {
                    dr3[item.Key] = item.Count();
                }
                dt.Rows.Add(dr3);
            }
            return dt;
        }

        //For the Compatitors Columns
        DataTable dt3()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Status (Competitor)");
            using (var db = new Session4Entities())
            {
                var selected = skill.SelectedIndex + 1;
                var q = db.Training_Module.Where(x => x.skillIdFK == selected && x.userTypeIdFK == 3).ToList();

                //Go through each training module and add the mod name
                foreach (var item in q)
                {
                    var q1 = db.Assign_Training.Where(x => x.moduleIdFK == item.moduleId).FirstOrDefault();
                    if (q1 != null)
                    {
                        dt.Columns.Add(item.moduleName);
                    }
                }

                //Completed
                var q2 = db.Assign_Training.Where(x => x.progress == 100 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 3).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr = dt.NewRow();
                dr["Status (Competitor)"] = "Completed";
                foreach (var item in q2)
                {
                    dr[item.Key] = item.Count();
                }
                dt.Rows.Add(dr);

                //Progress
                var q3 = db.Assign_Training.Where(x => x.progress < 100 && x.progress > 1 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 3).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr2 = dt.NewRow();
                dr2["Status (Competitor)"] = "In Progress";
                foreach (var item in q3)
                {
                    dr2[item.Key] = item.Count();
                }
                dt.Rows.Add(dr2);

                var q4 = db.Assign_Training.Where(x => x.progress == 0 && x.User.skillIdFK == selected && x.User.userTypeIdFK == 3).GroupBy(x => x.Training_Module.moduleName).ToList();
                DataRow dr3 = dt.NewRow();
                dr3["Status (Competitor)"] = "Not Started";
                foreach (var item in q4)
                {
                    dr3[item.Key] = item.Count();
                }
                dt.Rows.Add(dr3);
            }
            return dt;
        }
        #endregion

        void chart()
        {
            using (var db = new Session4Entities())
            {
                var idx = skill.SelectedIndex + 1;
                //foreach(DataGridViewRow dr in dataGridView3.Rows)
                //{
                //    chart1.Series.Add(new Series(dr.Cells[0].Value.ToString()));
                //}
                chart1.Series.Clear();
                chart1.Series.Add(new Series("Completed"));
                chart1.Series.Add(new Series("In Progress"));
                chart1.Series.Add(new Series("Not Started"));

                var q = db.Assign_Training.Where(x => x.User.skillIdFK == idx && x.User.userTypeIdFK == 3).GroupBy(x => x.Training_Module.moduleName).ToList();
                
                foreach(var item in q)
                {
                    var q2 = item.Where(x => x.progress == 100).ToList();
                    chart1.Series["Completed"].Points.AddXY(item.Key, q2.Count());

                    var q3 = item.Where(x => x.progress < 100 && x.progress > 1).ToList();
                    chart1.Series["In Progress"].Points.AddXY(item.Key, q3.Count());

                    var q4 = item.Where(x => x.progress == 0).ToList();
                    chart1.Series["Not Started"].Points.AddXY(item.Key, q4.Count());


                }

                chart1.Legends[0].Docking = Docking.Bottom;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = skill.SelectedIndex + 1;
            dataGridView2.DataSource = dt1(idx);
            dataGridView1.DataSource = dt2();
            dataGridView3.DataSource = dt3();
            chart();
        }
    }
}
