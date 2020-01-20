using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class Form1 : Form
    {
        Session5Entities db = new Session5Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var lol = (int)(9 / 2);
            //MessageBox.Show(lol.ToString());
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var q = db.Users.Where(x => x.userId == ID.Text && x.passwd == Pass.Text).FirstOrDefault();
            if (q != null)
            {
                //Only administrators can successfully login via this
                //screen.
                //When a user successfully logs in, they will be automatically re‐directed to
                //the admin main menu.
                AdminMainMenu adminMainMenu = new AdminMainMenu();
                this.Hide();
                adminMainMenu.Show();
            }
            else
            {
                //Include appropriate error checks and messages for data entry and unsuccessful
                //login attempts.
                MessageBox.Show("Invalid User!");
            }
        }
    }
}
