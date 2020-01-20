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
    public partial class AssignTraining : Form
    {
        User users;
        List<List<string>> strings = new List<List<string>>();
        public AssignTraining(User user)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lol();
        }

        private void AssignTraining_Load(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
            {
                var q = db.Skills.ToList();
                foreach( var item in q)
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
               
                var q2 = db.User_Type.ToList();
                foreach(var item in q2)
                {
                    if(item.userTypeId == 1)
                    {
                        continue;
                    }
                    else
                    {
                        cat.Items.Add(item.userTypeName);
                    }
                }
            }
            dateTimePicker1.Value = DateTime.Now;
        }

        private void mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lol();
        }

        void lol()
        {
            using (var db = new Session4Entities())
            {
                mod.Text = null;
                mod.Items.Clear();
                var Sname = skill.SelectedIndex + 1;
                var cats = cat.Text;
                var q = db.Training_Module.Where(x => x.User_Type.userTypeName == cats && x.skillIdFK == Sname).Select(x => new { x.moduleName, x.durationDays }).Distinct();
                foreach (var item in q)
                {
                    var qq = db.Assign_Training.Where(x => x.Training_Module.moduleName == item.moduleName).FirstOrDefault();
                    if(qq != null)
                    {
                        continue;
                    }
                    mod.Items.Add(item.moduleName + " (" + item.durationDays + " days)");
                }
            }
        }

        #region Adding modules to the list
        private void button2_Click(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
            {
               
                var diff = DateTime.Parse("26 July 2020") - dateTimePicker1.Value;
                var days = "";
                try
                {
                    days = mod.Text.Substring(mod.Text.IndexOf("(") + 1, 2);
                }
                catch
                {
                    MessageBox.Show("Please Add Something!");
                    return;
                }
                 
                int value = 0;
                value = int.Parse(days);

                if (diff.Days < value)
                {
                    MessageBox.Show("Date too Close!");
                    return;
                }
                var lols = skill.SelectedIndex + 1;
                var lols2 = cat.Text;
                var modules = mod.Text.Substring(0, mod.Text.IndexOf("(") - 1).Trim();
                List<String> lol = new List<string>();
                var y = db.Skills.Where(x => x.skillId == lols).FirstOrDefault();
                lol.Add(y.skillName);
                lol.Add(lols2);
                lol.Add(modules);
                if(strings.Count > 0)
                {
                    foreach (var item in strings)
                    {
                        if (item[0] == y.skillName && item[1] == lols2 && item[2] == modules)
                        {
                            MessageBox.Show("You have already added that module to the list!");
                            return;
                        }
                    }
                }
                strings.Add(lol);
                dataGridView1.DataSource = cdt(strings);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
            }
        }
        #endregion


        DataTable cdt(List<List<string>> assign_Trainings)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Skill");
            dt.Columns.Add("Trainee Category");
            dt.Columns.Add("Training Module");
            foreach(var item in assign_Trainings)
            {
                DataRow dr = dt.NewRow();
                dr["Skill"] = item[0];
                dr["Trainee Category"] = item[1];
                dr["Training Module"] = item[2];
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
            {
                //First it goes through each item in the list
                foreach(var item in strings)
                {
                    //Gets the skill name and user type
                    var skill = item[0];
                    var userType = item[1];

                    //Goes through each user and finds the users with the skill and user type
                    var user = db.Users.Where(x => x.Skill.skillName == skill && x.User_Type.userTypeName == userType).ToList();

                    //Goes through each user
                    foreach (var items in user)
                    {
                        //Creates a new DBO
                        Assign_Training assign_Training = new Assign_Training();

                        //Gets the Module Name
                        var modName = item[2];

                        //Goes to the traning module table and finds the module with the right module name, skill and user type
                        var trainingMod = db.Training_Module.Where(x => x.moduleName == modName && x.Skill.skillName == skill && x.User_Type.userTypeName == userType).FirstOrDefault();
                        
                        //Checks if it exists
                        if (trainingMod != null)
                        {
                            assign_Training.moduleIdFK = trainingMod.moduleId;
                            assign_Training.userIdFK = items.userId;
                            assign_Training.startDate = dateTimePicker1.Value;
                            assign_Training.progress = 0;
                            db.Assign_Training.Add(assign_Training);
                        }
                    }
                }

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success!");
                    this.Hide();
                    AdminMainMenu adminMainMenu = new AdminMainMenu(users);
                    adminMainMenu.Show();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                int index = dr.Index;
                strings.Remove(strings[index]);
                dataGridView1.DataSource = cdt(strings);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
