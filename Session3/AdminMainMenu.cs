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
    public partial class AdminMainMenu : Form
    {
        User users;
        public AdminMainMenu(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArrivalSummary arrivalSummary = new ArrivalSummary(users);
            arrivalSummary.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelSummary hotelSummary = new HotelSummary(users);
            hotelSummary.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestsSummary guestsSummary = new GuestsSummary(users);
            guestsSummary.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
