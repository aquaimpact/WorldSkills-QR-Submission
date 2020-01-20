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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RMLBtn_Click(object sender, EventArgs e)
        {
            ResourcemanagerLogin login = new ResourcemanagerLogin();
            this.Hide();
            login.ShowDialog();
            
        }

        private void CNABtn_Click(object sender, EventArgs e)
        {
            CreateNewAccount createNewAccount = new CreateNewAccount();
            this.Hide();
            createNewAccount.ShowDialog();
        }
    }
}
