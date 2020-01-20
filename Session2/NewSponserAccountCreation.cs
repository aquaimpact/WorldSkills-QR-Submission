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
    public partial class NewSponserAccountCreation : Form
    {
        public NewSponserAccountCreation()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void createABtn_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //Create new user object
                User user = new User();

                var companyname = db.Users.Where(x => x.name == name.Text).FirstOrDefault();
                if(companyname == null)
                {
                    user.name = name.Text;
                }
                else
                {
                    MessageBox.Show("Company Name Taken!");
                    return;
                }
                
                
                var q = db.Users.Where(x => x.userId == UID.Text).FirstOrDefault();

                //Checking if UserID contains a minimum of 8 Chars
                if(UID.TextLength >= 8)
                {
                    //Checking if userID is used alr
                    if (q == null)
                    {
                        user.userId = UID.Text;
                    }
                    else
                    {
                        MessageBox.Show("User ID Taken!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("User ID must be 8 characters long!");
                    return;
                }
                
                //Checking if passwords match
                if(Pass.Text != PassC.Text)
                {
                    MessageBox.Show("Passwords Do Not Match!");
                    return;
                }
                else
                {
                    user.passwd = Pass.Text;
                }
                user.userTypeIdFK = 2;
                db.Users.Add(user);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Successful!");

                    //Redirected back to the login screen
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }

            }
        }

        private void NewSponserAccountCreation_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
