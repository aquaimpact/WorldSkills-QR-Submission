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
    public partial class BookSponderPackages : Form
    {
        User users;
        List<Package> searchList;
        public BookSponderPackages(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void BookSponderPackages_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //By default, when the screen is first loaded, the packages 
                //should be sorted by their package name.
                var q = db.Packages.OrderBy(x => x.packageName).ToList();
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;

                //Populating the package tiers
                var q2 = q.Select(x => x.packageTier).Distinct().ToList();
                tier.Items.Add("");
                foreach (var item in q2)
                {
                    tier.Items.Add(item);
                }
            }
        }
        DataTable CDT(List<Package> packages)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tier");
            dt.Columns.Add("Name");
            dt.Columns.Add("Value ($)");
            dt.Columns.Add("Availabile Qty");
            dt.Columns.Add("Online");
            dt.Columns.Add("Flyer");
            dt.Columns.Add("Banner");
            foreach (var item in packages)
            {
                DataRow dr = dt.NewRow();
                dr["Tier"] = item.packageTier;
                dr["Name"] = item.packageName;
                dr["Value ($)"] = item.packageValue;

                //This table should only show available packages, except 
                //those that have no quantity left for booking
                if (item.packageQuantity == 0)
                {
                    continue;
                }
                dr["Availabile Qty"] = item.packageQuantity;
                dr["ID"] = item.packageId;

                using (var db = new Session2Entities())
                {
                    var ID = item.packageId;
                    var q = db.Benefits.Where(x => x.packageIdFK == ID).ToList();
                    foreach (var itemss in q)
                    {
                        if (itemss.benefitName == "Online")
                        {
                            dr["Online"] = "Yes";
                        }
                        else if (itemss.benefitName == "Flyer")
                        {
                            dr["Flyer"] = "Yes";
                        }
                        else if (itemss.benefitName == "Banner")
                        {
                            dr["Banner"] = "Yes";
                        }
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponserMainMenu sponserMainMenu = new SponserMainMenu(users);
            sponserMainMenu.Show();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                Booking booking = new Booking();
                booking.userIdFK = users.userId;
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                    {
                        var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                        booking.packageIdFK = ID;
                        var quan = int.Parse(dr.Cells["Availabile Qty"].Value.ToString());
                        if (quan >= DQ.Value)
                        {
                            booking.quantityBooked = (int)DQ.Value;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Amount!");
                            return;
                        }
                        booking.status = "Pending";
                        db.Bookings.Add(booking);
                        try
                        {
                            db.SaveChanges();

                            //Will hendle this when the manager approves the booking
                            //var q2 = db.Packages.Where(x => x.packageId == ID).FirstOrDefault();
                            //q2.packageQuantity -= (int)DQ.Value;
                            db.SaveChanges();
                            MessageBox.Show("Success!");
                            var q = db.Packages.ToList();
                            dataGridView1.DataSource = CDT(q);
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.Columns["ID"].Visible = false;
                        }
                        catch (Exception ES)
                        {
                            MessageBox.Show(ES.ToString());
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Pick Only 1!");
                    return;
                }
            }
        }

        private void tier_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering();
        }

        private void budget_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var testval = int.Parse(budget.Text);
                filtering();
            }
            catch
            {
                MessageBox.Show("Invalid Budget!");
                filtering();
            }
        }

        /*Users can filter this table by its tiers, which are listed in a 
        drop‐down list for users to select(from Gold to Silver to Bronze). 
        Sponsors may also have a budget that limits how much they can spend 
        to support this event. So, users can also filter this table based on 
        their available budget, and the table should refresh to only show 
        available packages that are within their budget*/
        void filtering()
        {
            
            using (var db = new Session2Entities())
            {
                var q = db.Packages.ToList();
                if (!string.IsNullOrEmpty(tier.Text))
                {
                    q = q.Where(x => x.packageTier == tier.Text).ToList();
                }
                if (!string.IsNullOrEmpty(budget.Text))
                {
                    try
                    {
                        var val = int.Parse(budget.Text);
                        q = q.Where(x => x.packageValue <= val).ToList();
                    }
                    catch
                    {
                        q = q;
                    }
                    
                }
                if (online.Checked)
                {
                    var q2 = db.Benefits.Where(x => x.benefitName == "Online").ToList();
                    List<Package> packages = new List<Package>();
                    foreach(var item in q2)
                    {
                        var packs = q.Where(x => x.packageId == item.packageIdFK).FirstOrDefault();
                        if(packs != null)
                        {
                            packages.Add(packs);
                        }
                    }
                    q = packages;

                }
                if (Flyers.Checked)
                {
                    var q2 = db.Benefits.Where(x => x.benefitName == "Flyer").ToList();
                    List<Package> packages = new List<Package>();
                    foreach (var item in q2)
                    {
                        var packs = q.Where(x => x.packageId == item.packageIdFK).FirstOrDefault();
                        if (packs != null)
                        {
                            packages.Add(packs);
                        }
                    }
                    q = packages;

                }
                if (Banner.Checked)
                {
                    var q2 = db.Benefits.Where(x => x.benefitName == "Banner").ToList();
                    List<Package> packages = new List<Package>();
                    foreach (var item in q2)
                    {
                        var packs = q.Where(x => x.packageId == item.packageIdFK).FirstOrDefault();
                        if (packs != null)
                        {
                            packages.Add(packs);
                        }
                    }
                    q = packages;

                }
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void online_CheckedChanged(object sender, EventArgs e)
        {
            filtering();
        }

        private void Flyers_CheckedChanged(object sender, EventArgs e)
        {
            filtering();
        }

        private void Banner_CheckedChanged(object sender, EventArgs e)
        {
            filtering();
        }
    }
}
