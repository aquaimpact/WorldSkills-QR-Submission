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
    public partial class UpdateInfoBooking : Form
    {
        User users;
        string carHeadDel;
        public UpdateInfoBooking(User user)
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

        private void UpdateInfoBooking_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using (var db = new Session3Entities())
            {
                var q = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                if (q == null)
                {
                    MessageBox.Show("Please Book Something First!");
                    this.Hide();
                    CountryRepresentativeMainMenu countryRepresentativeMainMenu = new CountryRepresentativeMainMenu(users);
                    countryRepresentativeMainMenu.Show();
                }
                else
                {
                    var q2 = db.Hotel_Booking.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    dataGridView1.DataSource = CDTU(q2);

                    HOD.Value = q.numberHead;
                    Dels.Text = q.numberDelegate.ToString();
                    Comps.Text = q.numberCompetitors.ToString();
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

            var total = (hotel.numSingleRoomsRequired * hotel.Hotel.singleRate) + (hotel.numDoubleRoomsRequired * hotel.Hotel.doubleRate);

            totalVal.Text = total.ToString();

            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);

            return dt;
        }

        private void HOD_ValueChanged(object sender, EventArgs e)
        {
            if (HOD.Value == 1)
            {
                carHeadDel = "1";
            }
            else
            {
                carHeadDel = "0";
            }
        }

        int oldD, oldS;

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells["Rooms Required"].Value != null && dataGridView1.Rows[1].Cells["Rooms Required"].Value != null)
            {
                var singleR = dataGridView1.Rows[0].Cells["Rooms Required"].Value.ToString();
                var doubleR = dataGridView1.Rows[1].Cells["Rooms Required"].Value.ToString();
                using (var db = new Session3Entities())
                {
                    var q2 = db.Hotel_Booking.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    oldD = q2.numDoubleRoomsRequired;
                    oldS = q2.numSingleRoomsRequired;

                    if (int.Parse(singleR) <= q2.Hotel.numSingleRoomsTotal - q2.Hotel.numSingleRoomsBooked)
                    {
                        q2.numSingleRoomsRequired = int.Parse(singleR);
                        q2.Hotel.numSingleRoomsBooked -= oldS;
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
                        q2.Hotel.numDoubleRoomsBooked -= oldD;
                        q2.Hotel.numDoubleRoomsBooked += int.Parse(doubleR);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount of Double Rooms!");
                        return;
                    }

                    var q = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                    
                    if(HOD.Value > 1)
                    {
                        MessageBox.Show("Invalid Head of Delegate");
                        return;
                    }
                    q.numberHead = (int)HOD.Value;
                    try
                    {
                        q.numberDelegate = int.Parse(Dels.Text);
                        q.numberCompetitors = int.Parse(Comps.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Delegates or Competitors");
                        return;
                    }
                   
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Success!");
                        this.Hide();
                        CountryRepresentativeMainMenu countryRepresentativeMainMenu = new CountryRepresentativeMainMenu(users);
                        countryRepresentativeMainMenu.Show();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
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
            totalVal.Text = totals.ToString();
        }
    }
}
