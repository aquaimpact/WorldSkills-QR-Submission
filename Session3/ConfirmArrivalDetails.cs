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
    public partial class ConfirmArrivalDetails : Form
    {
        User users;
        String time;
        List<int> blocked = new List<int>();
        public ConfirmArrivalDetails(User user = null)
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmArrivalDetails_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DataSource = cdt();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            using(var db = new Session3Entities())
            {
                var q = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                if(q != null)
                {
                    if(q.arrivalDate == DateTime.Parse("22 July 2020"))
                    {
                        jul22.Checked = true;
                    }
                    else if(q.arrivalDate == DateTime.Parse("23 July 2020"))
                    {
                        jul23.Checked = true;
                    }
                    time = q.arrivalTime;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if(column.HeaderCell.Value.ToString() == q.arrivalTime)
                        {
                            column.HeaderCell.Style.BackColor = Color.Yellow;
                        }
                    }

                    numericUpDown1.Value = q.numberHead;
                    Dels.Text = q.numberDelegate.ToString();
                    Comps.Text = q.numberCompetitors.ToString();
                    carHeadDel.Text = q.numberCars.ToString();
                    seat19.Text = q.number19seat.ToString();
                    seat42.Text = q.number42seat.ToString();
                }
            }
        }

        DataTable cdt()
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
            DataRow dr = dt.NewRow();
            dr["9AM"] = "9AM";
            dr["10AM"] = "10AM";
            dr["11AM"] = "11AM";
            dr["12PM"] = "12PM";
            dr["1PM"] = "1PM";
            dr["2PM"] = "2PM";
            dr["3PM"] = "3PM";
            dr["4PM"] = "4PM";
            dt.Rows.Add(dr);
            return dt;
        }

        private void book_Click(object sender, EventArgs e)
        {
            using (var db = new Session3Entities())
            {
                var q = db.Arrivals.Where(x => x.userIdFK == users.userId).FirstOrDefault();
                
                //If user first time creating arrivals
                if(q == null)
                {
                    Arrival arrival = new Arrival();
                    if (jul22.Checked == true)
                    {
                        arrival.arrivalDate = DateTime.Parse("22 July 2020");
                    }
                    else if (jul23.Checked == true)
                    {
                        arrival.arrivalDate = DateTime.Parse("23 July 2020");
                    }
                    else
                    {
                        MessageBox.Show("Choose Date!");
                        return;
                    }

                    arrival.userIdFK = users.userId;

                    if (time == null)
                    {
                        MessageBox.Show("You have chosen an invalid timing!");
                        return;
                    }
                    arrival.arrivalTime = time;


                    if (numericUpDown1.Value > 1)
                    {
                        MessageBox.Show("Invalid Head of Deligates!");
                        return;
                    }
                    arrival.numberHead = (int)numericUpDown1.Value;


                    try
                    {
                        arrival.numberDelegate = int.Parse(Dels.Text);
                        arrival.numberCompetitors = int.Parse(Comps.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Deligates or competitors");
                        return;
                    }
                    arrival.numberCars = int.Parse(carHeadDel.Text);
                    arrival.number19seat = int.Parse(seat19.Text);
                    arrival.number42seat = int.Parse(seat42.Text);
                    db.Arrivals.Add(arrival);
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

                //User has created and come back to change
                else
                {
                    if (jul22.Checked == true)
                    {
                        q.arrivalDate = DateTime.Parse("22 July 2020");
                    }
                    else if (jul23.Checked == true)
                    {
                        q.arrivalDate = DateTime.Parse("23 July 2020");
                    }
                    else
                    {
                        MessageBox.Show("Choose Date!");
                        return;
                    }

                    if (time == null)
                    {
                        MessageBox.Show("You have chosen an invalid timing!");
                        return;
                    }
                    q.arrivalTime = time;


                    if (numericUpDown1.Value > 1)
                    {
                        MessageBox.Show("Invalid Head of Deligates!");
                        return;
                    }
                    q.numberHead = (int)numericUpDown1.Value;


                    try
                    {
                        q.numberDelegate = int.Parse(Dels.Text);
                        q.numberCompetitors = int.Parse(Comps.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Deligates or competitors");
                        return;
                    }
                    q.numberCars = int.Parse(carHeadDel.Text);
                    q.number19seat = int.Parse(seat19.Text);
                    q.number42seat = int.Parse(seat42.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "9AM";
            }
            else if (e.ColumnIndex == 1)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "10AM";
            }
            else if (e.ColumnIndex == 2)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "11AM";
            }
            else if (e.ColumnIndex == 3)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "12PM";
            }
            else if (e.ColumnIndex == 4)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "1PM";
            }
            else if (e.ColumnIndex == 5)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "2PM";
            }
            else if (e.ColumnIndex == 6)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "3PM";
            }
            else if (e.ColumnIndex == 7)
            {
                if (blocked.Contains(e.ColumnIndex))
                {
                    time = null;
                    return;
                }
                time = "4PM";
            }
        }

        private void jul22_CheckedChanged(object sender, EventArgs e)
        {
            if (jul22.Checked == true)
            {
                blocked.Clear();
                blocked.Add(1);
                blocked.Add(4);
                blocked.Add(5);

                dataGridView1.Columns["10AM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["1PM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["2PM"].DefaultCellStyle.BackColor = Color.Black;
            }
            else
            {
                dataGridView1.Columns["10AM"].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns["1PM"].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns["2PM"].DefaultCellStyle.BackColor = Color.White;
            }


        }

        private void jul23_CheckedChanged(object sender, EventArgs e)
        {
            if (jul23.Checked == true)
            {
                blocked.Clear();
                blocked.Add(0);
                blocked.Add(3);
                blocked.Add(7);

                dataGridView1.Columns["9AM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["12PM"].DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.Columns["4PM"].DefaultCellStyle.BackColor = Color.Black;
            }
            else
            {
                dataGridView1.Columns["9AM"].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns["12PM"].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns["4PM"].DefaultCellStyle.BackColor = Color.White;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            {
                carHeadDel.Text = "1";
            }
            else
            {
                carHeadDel.Text = "0";
            }

        }

        private void Dels_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Dels.Text))
            {
                Dels.Text = "0";
            }
            numbers();
        }

        private void numbers()
        {
            int dels, comps;
            try
            {
                if (Dels.TextLength == 0)
                {
                    dels = 0;
                }
                else
                {
                    dels = int.Parse(Dels.Text);
                }

                if (Comps.TextLength == 0)
                {
                    comps = 0;
                }
                else
                {
                    comps = int.Parse(Comps.Text);
                }


                int val = dels + comps;
                if (val <= 38)
                {
                    if(val % 19 == 0)
                    {
                        seat19.Text = ((int)(val / 19)).ToString();
                    }
                    else if(val % 19 == val)
                    {
                        seat19.Text = "1";
                    }
                    else
                    {
                        seat19.Text = ((int)(val / 19 + 1)).ToString();
                    }
                    
                }
                else if(val > 38)
                {
                    if (val % 42 == 0)
                    {
                        seat42.Text = ((int)(val / 42)).ToString();
                    }
                    else if (val % 19 == val)
                    {
                        seat42.Text = "1";
                    }
                    else
                    {
                        seat42.Text = ((int)(val / 42)).ToString();
                        var remain = val % 42;
                        if (remain % 19 == 0)
                        {
                            seat19.Text = ((int)(remain / 19)).ToString();
                        }
                        else if (remain % 19 == val)
                        {
                            seat19.Text = "1";
                        }
                        else
                        {
                            seat19.Text = ((int)(remain / 19 + 1)).ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }



        private void Comps_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Comps.Text))
            {
                Comps.Text = "0";
            }
            numbers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
