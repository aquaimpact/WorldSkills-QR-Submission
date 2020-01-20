using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //var timeleft = DateTime.Parse("26 July 2020") - DateTime.Now;
            //time.Text = timeleft.Days.ToString() + " days " + timeleft.Hours.ToString() + " hours and " + timeleft.Minutes.ToString() + " minutes until the event starts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new Session4Entities())
            {
                var ID = UID.Text;
                var pass = Pass.Text;
                var q = db.Users.Where(x => x.userId.Trim() == ID && x.passwd == pass).FirstOrDefault();
                if(q != null)
                {
                    if(q.userTypeIdFK == 1)
                    {
                        this.Hide();
                        AdminMainMenu adminMainMenu = new AdminMainMenu(q);
                        adminMainMenu.Show();
                    }else if(q.userTypeIdFK == 2)
                    {
                        this.Hide();
                        ExpertMainMenu expertMainMenu = new ExpertMainMenu(q);
                        expertMainMenu.Show();
                    }
                    else
                    {
                        this.Hide();
                        UpdateCompetitorTrainingRecords updateCompetitorTrainingRecords = new UpdateCompetitorTrainingRecords(q);
                        updateCompetitorTrainingRecords.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var timeleft = DateTime.Parse("26 July 2020") - DateTime.Now;
            time.Text = timeleft.Days.ToString() + " days " + timeleft.Hours.ToString() + " hours and " + timeleft.Minutes.ToString() + " minutes until the event starts";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                textBox2.Text = dialog.FileName; // get name of file
                try
                {
                    using (var db = new Session4Entities())
                    {
                        string[] Lines = File.ReadAllLines(dialog.FileName);
                        string[] Fields = Lines[0].Split(new char[] { ',' });
                        //The system should then append the
                        //information from this CSV file to the 
                        //database
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ',' });
                            User user = new User();
                            user.userId = Fields[0].Trim();
                            user.skillIdFK = int.Parse(Fields[1]);
                            user.passwd = Fields[2].Trim();
                            user.name = Fields[3].Trim();
                            user.userTypeIdFK = int.Parse(Fields[4]);

                            db.Users.Add(user);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Successfully added to DB!");
                    }

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
        }
    }
}
