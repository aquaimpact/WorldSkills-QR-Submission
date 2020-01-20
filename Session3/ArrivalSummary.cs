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
    public partial class ArrivalSummary : Form
    {
        User users;
        public ArrivalSummary(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu(users);
            adminMainMenu.Show();
        }

        private void ArrivalSummary_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using( var db = new Session3Entities())
            {
                var date = DateTime.Parse("22 July 2020");
                var q = db.Arrivals.Where(x => x.arrivalDate == date).ToList();
                dataGridView1.DataSource = cdt(q);
                dataGridView1.Columns["10AM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["1PM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["2PM"].DefaultCellStyle.BackColor = Color.Black;

                dataGridView1.Columns["10AM"].HeaderCell.Style.BackColor = Color.Black;
                dataGridView1.Columns["1PM"].HeaderCell.Style.BackColor = Color.Black;
                dataGridView1.Columns["2PM"].HeaderCell.Style.BackColor = Color.Black;

                var date2 = DateTime.Parse("23 July 2020");
                var q2 = db.Arrivals.Where(x => x.arrivalDate == date2).ToList();
                dataGridView2.DataSource = cdt(q2);
                dataGridView2.Columns["9AM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView2.Columns["12PM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView2.Columns["4PM"].DefaultCellStyle.BackColor = Color.Black;

                dataGridView1.Columns["9AM"].HeaderCell.Style.BackColor = Color.Black;
                dataGridView2.Columns["12PM"].HeaderCell.Style.BackColor = Color.Black;
                dataGridView2.Columns["4PM"].HeaderCell.Style.BackColor = Color.Black;
            }
        }

        DataTable cdt(List<Arrival> arrivals)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("9AM");
            dt.Columns.Add("10AM");
            dt.Columns.Add("11AM");
            dt.Columns.Add("12PM");
            dt.Columns.Add("1PM");
            dt.Columns.Add("2PM");
            dt.Columns.Add("3PM");
            dt.Columns.Add("4PM");
            foreach( var item in arrivals)
            {
                DataRow dr = dt.NewRow();
                var cars = 0;
                switch (item.arrivalTime)
                {
                    
                    case "9AM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["9AM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "10AM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["10AM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "11AM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["11AM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "12PM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["12PM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "1PM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["1PM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "2PM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["2PM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "3PM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["3PM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;

                    case "4PM":
                        cars = item.numberCars + item.number42seat + item.number19seat;
                        dr["4PM"] = item.User.countryName + "\n (" + cars.ToString() + " veh)";
                        break;
                }
                dt.Rows.Add(dr);
            }
            
            return dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
