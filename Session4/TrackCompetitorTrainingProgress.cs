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
    public partial class TrackCompetitorTrainingProgress : Form
    {
        List<List<string>> strings;
        User users; 
        public TrackCompetitorTrainingProgress(User user)
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

        private void TrackCompetitorTrainingProgress_Load(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
            {
                var q = db.Users.Where(x => x.userId == users.userId).FirstOrDefault();
                skillName.Text = q.Skill.skillName;
                dataGridView1.DataSource = cdt();
                foreach(DataGridViewRow dr in dataGridView1.Rows)
                {
                    for(int i = 0; i < dr.Cells.Count; i++)
                    {
                        if(dr.Cells[i].Value != null)
                        {
                            var value = dr.Cells[i].Value.ToString().Trim();
                            if (value == "0")
                            {
                                dr.Cells[i].Style.BackColor = Color.Red;
                            }
                        }
                        
                    }
                }
            }
            
        }

        DataTable cdt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name of Competitor");
            using(var db = new Session4Entities())
            {
                var q = db.Training_Module.Where(x => x.skillIdFK == users.skillIdFK && x.userTypeIdFK == 3).ToList();

                //Go through each training module and add the mod name
                foreach (var item in q)
                {
                    var q4 = db.Assign_Training.Where(x => x.moduleIdFK == item.moduleId).FirstOrDefault();
                    if(q4 != null)
                    {
                        dt.Columns.Add(item.moduleName);
                    }
                }
                var q2 = db.Users.Where(x => x.userTypeIdFK == 3 && x.skillIdFK == users.skillIdFK).ToList();
                foreach(var item in q2)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name of Competitor"] = item.name;
                    var q3 = db.Assign_Training.Where(x => x.userIdFK == item.userId).ToList();
                    foreach(var items in q3)
                    {
                        dr[items.Training_Module.moduleName] = items.progress;
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
