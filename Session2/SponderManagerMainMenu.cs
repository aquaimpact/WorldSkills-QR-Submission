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
    public partial class SponderManagerMainMenu : Form
    {
        User users;

        public SponderManagerMainMenu(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void VSPBtn_Click(object sender, EventArgs e)
        {
            ViewSponserPackages viewSponserPackages = new ViewSponserPackages(users);
            this.Hide();
            viewSponserPackages.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void ASPBtn_Click(object sender, EventArgs e)
        {
            AddSponsershipPackages addSponsershipPackages = new AddSponsershipPackages(users);
            this.Hide();
            addSponsershipPackages.Show();
        }

        private void ASBBtn_Click(object sender, EventArgs e)
        {
            ApproveSponsershipPackages approveSponsershipPackages = new ApproveSponsershipPackages(users);
            this.Hide();
            approveSponsershipPackages.Show();
        }

        private void VSSBtn_Click(object sender, EventArgs e)
        {
            ViewSponsershipSummary viewSponsershipSummary = new ViewSponsershipSummary(users);
            this.Hide();
            viewSponsershipSummary.Show();
        }

        private void SponderManagerMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
