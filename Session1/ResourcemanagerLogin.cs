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
    public partial class ResourcemanagerLogin : Form
    {
        public ResourcemanagerLogin()
        {
            InitializeComponent();
        }

        private void ResourcemanagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (var db = new Session1Entities())
            {
                var query = db.Users.Where(x => x.userId == UID.Text && x.userPw == Pass.Text).FirstOrDefault();
                if(query != null)
                {
                    this.Hide();
                    ResouceManagement resouceManagement = new ResouceManagement();
                    resouceManagement.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
