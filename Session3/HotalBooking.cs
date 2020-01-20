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
    public partial class HotalBooking : Form
    {
        User users;
        int hotels, singleRoom, doubleRoom, oldS, oldD;
        public HotalBooking(User user, int hotel)
        {
            InitializeComponent();
            users = user;
            hotels = hotel;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void book_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows[0].Cells["Rooms Required"].Value != null && dataGridView1.Rows[1].Cells["Rooms Required"].Value != null)
            {
                var singleR = dataGridView1.Rows[0].Cells["Rooms Required"].Value.ToString();
                var doubleR = dataGridView1.Rows[1].Cells["Rooms Required"].Value.ToString();
                using(var db = new Session3Entities())
                {
                    var q2 = db.Hotel_Booking.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    oldD = q2.numDoubleRoomsRequired;
                    oldS = q2.numSingleRoomsRequired;
                    if (q2 == null)
                    {
                        var q = db.Hotels.Where(x => x.hotelId == hotels).FirstOrDefault();
                        Hotel_Booking hotel_Booking = new Hotel_Booking();
                        hotel_Booking.hotelIdFK = hotels;
                        hotel_Booking.userIdFK = users.userId;
                        if (int.Parse(singleR) <= q.numSingleRoomsTotal - q.numSingleRoomsBooked)
                        {
                            hotel_Booking.numSingleRoomsRequired = int.Parse(singleR);
                            q.numSingleRoomsBooked -= oldS;
                            q.numSingleRoomsBooked += int.Parse(singleR);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount of Single Rooms!");
                            return;
                        }

                        if (int.Parse(doubleR) <= q.numDoubleRoomsTotal - q.numDoubleRoomsBooked)
                        {
                            hotel_Booking.numDoubleRoomsRequired = int.Parse(doubleR);
                            q.numDoubleRoomsBooked -= oldD;
                            q.numDoubleRoomsBooked += int.Parse(doubleR);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount of Double Rooms!");
                            return;
                        }

                        db.Hotel_Booking.Add(hotel_Booking);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Success!");
                            this.Hide();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.ToString());
                        }
                    }
                    else
                    {
                        if (int.Parse(singleR) <= q2.Hotel.numSingleRoomsTotal - q2.Hotel.numSingleRoomsBooked)
                        {
                            q2.numSingleRoomsRequired = int.Parse(singleR);
                            q2.Hotel.numSingleRoomsBooked += int.Parse(singleR);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount of Single Rooms!");
                            return;
                        }

                        if (int.Parse(doubleR) <= q2.Hotel.numDoubleRoomsTotal - q2.Hotel.numDoubleRoomsBooked)
                        {
                            q2.numDoubleRoomsRequired = int.Parse(doubleR);
                            q2.Hotel.numDoubleRoomsBooked += int.Parse(doubleR);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount of Double Rooms!");
                            return;
                        }
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Success!");
                            this.Hide();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.ToString());
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var totals = 0;
            if (dataGridView1.Rows[0].Cells["Room Rate Per Night ($)"].Value != null && dataGridView1.Rows[0].Cells["Rooms Required"].Value != null)
            {
                var rate = dataGridView1.Rows[0].Cells["Room Rate Per Night ($)"].Value.ToString();
                var quantity = dataGridView1.Rows[0].Cells["Rooms Required"].Value.ToString();
                dataGridView1.Rows[0].Cells["Sub-Total ($)"].Value = (int.Parse(rate) * int.Parse(quantity)).ToString();
                totals += int.Parse(rate) * int.Parse(quantity);
            }

            if (dataGridView1.Rows[1].Cells["Room Rate Per Night ($)"].Value != null && dataGridView1.Rows[1].Cells["Rooms Required"].Value != null)
            {
                var rate = dataGridView1.Rows[1].Cells["Room Rate Per Night ($)"].Value.ToString();
                var quantity = dataGridView1.Rows[1].Cells["Rooms Required"].Value.ToString();
                dataGridView1.Rows[1].Cells["Sub-Total ($)"].Value = (int.Parse(rate) * int.Parse(quantity)).ToString();
                totals += int.Parse(rate) * int.Parse(quantity);
            }
            total.Text = totals.ToString();
        }

        private void HotalBooking_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using(var db = new Session3Entities())
            {
                var q2 = db.Hotel_Booking.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                if(q2 == null)
                {
                    var q = db.Hotels.Where(x => x.hotelId == hotels).FirstOrDefault();
                    HotalName.Text = q.hotelName;
                    var user = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    numberD.Text = user.numberDelegate.ToString();
                    NumberC.Text = user.numberCompetitors.ToString();
                    dataGridView1.DataSource = CDT(q);
                }
                else
                {
                    var q = db.Hotels.Where(x => x.hotelId == hotels).FirstOrDefault();
                    HotalName.Text = q.hotelName;
                    var user = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    numberD.Text = user.numberDelegate.ToString();
                    NumberC.Text = user.numberCompetitors.ToString();
                    dataGridView1.DataSource = CDTU(q2);
                }
            }
        }

        DataTable CDTU(Hotel_Booking hotel)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Room Type");
            dt.Columns.Add("Room Rate Per Night ($)");
            dt.Columns.Add("Rooms Required");
            dt.Columns.Add("Sub-Total ($)");

            DataRow dr = dt.NewRow();
            dr["Room Type"] = "Single";
            dr["Room Rate Per Night ($)"] = hotel.Hotel.singleRate;
            dr["Rooms Required"] = hotel.numSingleRoomsRequired;
            dr["Sub-Total ($)"] = hotel.numSingleRoomsRequired * hotel.Hotel.singleRate;

            DataRow dr2 = dt.NewRow();
            dr2["Room Type"] = "Double";
            dr2["Room Rate Per Night ($)"] = hotel.Hotel.doubleRate;
            dr2["Rooms Required"] = hotel.numDoubleRoomsRequired;
            dr2["Sub-Total ($)"] = hotel.numDoubleRoomsRequired * hotel.Hotel.doubleRate;

            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);

            var totals = (hotel.numSingleRoomsRequired * hotel.Hotel.singleRate) + (hotel.numDoubleRoomsRequired * hotel.Hotel.doubleRate);

            total.Text = total.ToString();

            return dt;
        }

        DataTable CDT(Hotel hotel)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Room Type");
            dt.Columns.Add("Room Rate Per Night ($)");
            dt.Columns.Add("Rooms Required");
            dt.Columns.Add("Sub-Total ($)");

            int singleR = int.Parse(numberD.Text);
            int doubleR;
            var compets = int.Parse(NumberC.Text);
            if(compets % 2 == 0)
            {
                doubleR = compets / 2;
            }
            else
            {
                doubleR = compets / 2;
                singleR += 1;
            }
            

            DataRow dr = dt.NewRow();
            dr["Room Type"] = "Single";
            dr["Room Rate Per Night ($)"] = hotel.singleRate;
            dr["Rooms Required"] = singleR;
            dr["Sub-Total ($)"] = singleR * hotel.singleRate;
            
            DataRow dr2 = dt.NewRow();
            dr2["Room Type"] = "Double";
            dr2["Room Rate Per Night ($)"] = hotel.doubleRate;
            dr2["Rooms Required"] = doubleR;
            dr2["Sub-Total ($)"] = doubleR * hotel.doubleRate;

            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);

            var totals = (singleR * hotel.singleRate) + (doubleR * hotel.doubleRate);

            total.Text = totals.ToString();

            return dt;
        }
    }
}
