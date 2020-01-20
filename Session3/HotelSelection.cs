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
    public partial class HotelSelection : Form
    {
        User users;
        public HotelSelection(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryRepresentativeMainMenu countryRepresentativeMainMenu = new CountryRepresentativeMainMenu(users);
            countryRepresentativeMainMenu.Show();
        }

        private void HotelSelection_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void interCon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void interCon_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 4);
            hotalBooking.ShowDialog();
        }

        private void HotelRQ_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 6);
            hotalBooking.ShowDialog();
        }

        private void HGP_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 5);
            hotalBooking.ShowDialog();
        }

        private void CharH_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 3);
            hotalBooking.ShowDialog();
        }

        private void PanPac_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 2);
            hotalBooking.ShowDialog();
        }

        private void RC_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RC_Click(object sender, EventArgs e)
        {
            HotalBooking hotalBooking = new HotalBooking(users, 1);
            hotalBooking.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
