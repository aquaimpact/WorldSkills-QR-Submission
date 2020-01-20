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
    public partial class UpdateSponsershipBookings : Form
    {
        User users;
        int val;
        public UpdateSponsershipBookings(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponserMainMenu sponserMainMenu = new SponserMainMenu(users);
            sponserMainMenu.Show();
        }

        private void UpdateSponsershipBookings_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //This table should only include the package
                //bookings that the sponsor manager has Approved
                var q = db.Bookings.Where(x => x.userIdFK == users.userId && x.status == "Approved")
                    //When the screen is loaded, the packages should 
                    //be sorted by their tier and then individual value.
                    .OrderBy(x => x.Package.packageTier == "Bronze" ? 1 : x.Package.packageTier == "Silver" ? 2 : 3)
                    .ThenBy(x => x.Package.packageValue)
                    .ToList();
                dataGridView1.DataSource = cdt(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID1"].Visible = false;
                TotalVal.Text = val.ToString();
            }
        }
        DataTable cdt(List<Booking> packages)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID1");
            dt.Columns.Add("Tier");
            dt.Columns.Add("Name");
            dt.Columns.Add("Individual Value($)");
            dt.Columns.Add("Quantity Booked");
            dt.Columns.Add("Sub-Total Value($)");
            int vals = 0;
            foreach (var item in packages)
            {
                DataRow dr = dt.NewRow();
                dr["ID1"] = item.bookingId;
                dr["Tier"] = item.Package.packageTier;
                dr["Name"] = item.Package.packageName;
                dr["Individual Value($)"] = item.Package.packageValue;
                dr["Quantity Booked"] = item.quantityBooked;

                //The table should also show the sub‐total 
                //value for each package that they booked,
                dr["Sub-Total Value($)"] = item.quantityBooked * item.Package.packageValue;
                dt.Rows.Add(dr);

                //as well as the total value for all the packages below the table.
                vals += (int)(item.quantityBooked * item.Package.packageValue);
            }
            val = vals;
            return dt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UQBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells["ID1"].Value.ToString());
                    var quantity = int.Parse(dr.Cells["Quantity Booked"].Value.ToString());
                    using (var db = new Session2Entities())
                    {
                        var q = db.Bookings.Where(x => x.bookingId == ID).FirstOrDefault();
                        //This feature should not allow a user to reduce the number of packages to zero.
                        if (NQ.Value == 0)
                        {
                            MessageBox.Show("Invalid Quantity! IF you want, please delete it!");
                            return;
                        }

                        //the system should check to ensure that there are sufficient
                        //packages available before the user can increase the quantity they wish to book
                        if (q.Package.packageQuantity > NQ.Value)
                        {
                            q.quantityBooked = (int)NQ.Value;
                            if ((int)NQ.Value < quantity)
                            {
                                q.Package.packageQuantity += quantity - (int)NQ.Value;
                            }
                            else
                            {
                                q.Package.packageQuantity -= (int)NQ.Value;
                            }
                        }
                        else
                        {
                            //If there are insufficient packages, the system should notify the user and not process the update.
                            MessageBox.Show("Invalid Quantity!");
                            return;
                        }
                        try
                        {
                            db.SaveChanges();

                            //This table should only include the package
                            //bookings that the sponsor manager has Approved
                            var q1 = db.Bookings.Where(x => x.userIdFK == users.userId && x.status == "Approved")
                                        //When the screen is loaded, the packages should 
                                        //be sorted by their tier and then individual value.
                                        .OrderBy(x => x.Package.packageTier == "Bronze" ? 1 : x.Package.packageTier == "Silver" ? 2 : 3)
                                        .ThenBy(x => x.Package.packageValue)
                                        .ToList();

                            //Once package is updated or deleted, the table should automatically refresh to show the updated
                            //information.
                            dataGridView1.DataSource = cdt(q1);
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.Columns["ID1"].Visible = false;
                            TotalVal.Text = val.ToString();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.ToString());
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("ERROR!");
                return;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells["ID1"].Value.ToString());
                    var quantity = int.Parse(dr.Cells["Quantity Booked"].Value.ToString());
                    using (var db = new Session2Entities())
                    {
                        var q = db.Bookings.Where(x => x.bookingId == ID).FirstOrDefault();
                        q.Package.packageQuantity += quantity;
                        db.Bookings.Remove(q);

                        try
                        {
                            db.SaveChanges();

                            //This table should only include the package
                            //bookings that the sponsor manager has Approved
                            var q1 = db.Bookings.Where(x => x.userIdFK == users.userId && x.status == "Approved")
                                        //When the screen is loaded, the packages should 
                                        //be sorted by their tier and then individual value.
                                        .OrderBy(x => x.Package.packageTier == "Bronze" ? 1 : x.Package.packageTier == "Silver" ? 2 : 3)
                                        .ThenBy(x => x.Package.packageValue)
                                        .ToList();

                            //Once package is updated or deleted, the table should automatically refresh to show the updated
                            //information.
                            dataGridView1.DataSource = cdt(q1);
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.Columns["ID1"].Visible = false;
                            TotalVal.Text = val.ToString();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.ToString());
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("ERROR!");
                return;
            }

        }
    }
}
