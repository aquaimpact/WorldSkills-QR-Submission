using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //checking if there is a user associated with the username and password
                var q = db.Users.Where(x => x.userId == UID.Text && x.passwd == Pass.Text).FirstOrDefault();

                //If no one then get error
                if (q == null)
                {
                    MessageBox.Show("Invalid User!");
                }
                else
                {
                    //Go to their respective menus
                    this.Hide();
                    if(q.User_Type.userTypeName == "Sponsor")
                    {
                        SponserMainMenu sponserMainMenu = new SponserMainMenu(q);
                        sponserMainMenu.Show();
                    }
                    else if(q.User_Type.userTypeName == "Manager")
                    {
                        SponderManagerMainMenu sponderManagerMainMenu = new SponderManagerMainMenu(q);
                        sponderManagerMainMenu.Show();
                    }

                }
            }
        }

        private void CNSABtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewSponserAccountCreation newSponserAccountCreation = new NewSponserAccountCreation();
            newSponserAccountCreation.Show();
        }
    }
}
