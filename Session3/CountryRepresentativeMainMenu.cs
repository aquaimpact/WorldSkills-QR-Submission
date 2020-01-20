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
    public partial class CountryRepresentativeMainMenu : Form
    {
        User users;
        public CountryRepresentativeMainMenu(User user)
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

        private void CountryRepresentativeMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using(var db = new Session3Entities())
            {
                //var q = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                //if(q != null)
                //{
                //    button1.Visible = false;
                //}
                //else
                //{
                //    button1.Visible = true;
                //}
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfirmArrivalDetails confirmArrivalDetails = new ConfirmArrivalDetails(users);
            confirmArrivalDetails.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using( var db = new Session3Entities())
            {
                var q = db.Hotel_Booking.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                if(q != null)
                {
                    MessageBox.Show("You have already made a hotel selection!");
                    return;
                }
            }
            this.Hide();
            HotelSelection hotalBooking = new HotelSelection(users);
            hotalBooking.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateInfoBooking updateInfoBooking = new UpdateInfoBooking(users);
            updateInfoBooking.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
