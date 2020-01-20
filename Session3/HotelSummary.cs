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
    public partial class HotelSummary : Form
    {
        User users;
        public HotelSummary(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu(users);
            this.Hide();
            adminMainMenu.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            int ID = 4;
            retrieve(ID);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            int ID = 5;
            retrieve(ID);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            int ID = 6;
            retrieve(ID);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            int ID = 3;
            retrieve(ID);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            int ID = 2;
            retrieve(ID);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            int ID = 1;
            retrieve(ID);
        }

        void retrieve(int id)
        {
            using( var db = new Session3Entities())
            {
                var q = db.Hotel_Booking.Where(x => x.hotelIdFK == id).ToList();
                var q2 = db.Hotels.Where(x => x.hotelId == id).FirstOrDefault();
                hotelName.Text = q2.hotelName;
                dataGridView1.DataSource = CDT(q);
            }
        }

        DataTable CDT(List<Hotel_Booking> hotel_Bookings)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Country");
            dt.Columns.Add("No of Single Rooms Booked");
            dt.Columns.Add("No of Double Rooms Booked");
            foreach( var item in hotel_Bookings)
            {
                DataRow dr = dt.NewRow();
                dr["Country"] = item.User.countryName;
                dr["No of Single Rooms Booked"] = item.numSingleRoomsRequired;
                dr["No of Double Rooms Booked"] = item.numDoubleRoomsRequired;

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }

        private void HotelSummary_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
