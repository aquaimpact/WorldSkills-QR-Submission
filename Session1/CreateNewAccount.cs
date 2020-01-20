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
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {
            using (var db = new Session1Entities())
            {
                var query = db.User_Type.ToList();
                if(query != null)
                {
                    foreach (var item in query)
                    {
                        UType.Items.Add(item.userTypeName);
                    }
                    UType.SelectedIndex = 0;
                }
                
            }
        }

        private void CABtn_Click(object sender, EventArgs e)
        {
            using(var db = new Session1Entities())
            {
                User user = new User();
                user.userName = UName.Text;
                if(UID.TextLength < 8)
                {
                    MessageBox.Show("User ID must have a minimum of 8 characters!");
                    return;
                }
                else
                {
                    var query2 = db.Users.Where(x => x.userId == UID.Text).FirstOrDefault();
                    if( query2 != null)
                    {
                        MessageBox.Show("User ID already exists!");
                    }
                    else
                    {
                        user.userId = UID.Text;
                    }
                    
                }

                //Checking password
                if(Pass.TextLength == 0 )
                {
                    MessageBox.Show("Password must have a value!");
                    return;

                }
                if (PassC.TextLength == 0)
                {
                    MessageBox.Show("Confirm Password must have a value!");
                    return;
                }
                if (Pass.Text != PassC.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    user.userPw = Pass.Text;
                }
                var ID = UType.SelectedIndex + 1;
                var query = db.User_Type.Where(x => x.userTypeId == ID).FirstOrDefault();
                user.userTypeIdFK = query.userTypeId;
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Account Created Successfully!");
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                }catch(Exception es)
                {
                    MessageBox.Show(es.ToString());
                }

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void UType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
