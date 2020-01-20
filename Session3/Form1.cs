using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CNCRA_Click(object sender, EventArgs e)
        {
            //New country representatives can also click on the button to go to the new country rep account
            //creation screen.
            this.Hide();
            NewCountryRepresentative_AccountCreation newCountryRepresentative_AccountCreation = new NewCountryRepresentative_AccountCreation();
            newCountryRepresentative_AccountCreation.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (var db = new Session3Entities())
            {
                var ID = UID.Text;
                var pass = Pass.Text;
                var q = db.Users.Where(x => x.userId == ID && x.passwd == pass).FirstOrDefault();
                if (q != null)
                {
                    //Only administrators and country representatives
                    //can successfully login via this screen.
                    if (q.userTypeIdFK == 1)
                    {
                        //When a user successfully logs in, they will be
                        //automatically re‐directed to the appropriate main menu for that type of user.
                        AdminMainMenu adminMainMenu = new AdminMainMenu(q);
                        this.Hide();
                        adminMainMenu.Show();
                    }
                    else
                    {

                        //When a user successfully logs in, they will be
                        //automatically re‐directed to the appropriate main menu for that type of user.
                        CountryRepresentativeMainMenu countryRepresentativeMainMenu = new CountryRepresentativeMainMenu(q);
                        this.Hide();
                        countryRepresentativeMainMenu.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show((38 % 42).ToString());
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
            
        }
    }
}
