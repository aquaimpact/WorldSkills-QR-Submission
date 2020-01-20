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
    public partial class SponserMainMenu : Form
    {
        User users;
        public SponserMainMenu(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void BSPBtn_Click(object sender, EventArgs e)
        {
            BookSponderPackages bookSponderPackages = new BookSponderPackages(users);
            this.Hide();
            bookSponderPackages.Show();
        }

        private void USPBtn_Click(object sender, EventArgs e)
        {
            UpdateSponsershipBookings updateSponsershipBookings = new UpdateSponsershipBookings(users);
            this.Hide();
            updateSponsershipBookings.Show();
        }

        private void SponserMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
