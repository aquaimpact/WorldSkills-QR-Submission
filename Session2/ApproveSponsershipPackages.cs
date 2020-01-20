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
    public partial class ApproveSponsershipPackages : Form
    {
        User users;
        public ApproveSponsershipPackages(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void ApproveSponsershipPackages_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var q = db.Bookings.OrderBy(x => x.status == "Pending" ? 1 : x.status == "Approved" ? 2 : 3).ThenBy(x => x.User.name).ToList();
                dataGridView1.DataSource = cdt(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        DataTable cdt(List<Booking> bookings)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Company Name");
            dt.Columns.Add("Package Name");
            dt.Columns.Add("Status");
            foreach (var item in bookings)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = item.bookingId;
                dr["Company Name"] = item.User.name;
                dr["Package Name"] = item.Package.packageName;
                dr["Status"] = item.status;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponderManagerMainMenu sponderManagerMainMenu = new SponderManagerMainMenu(users);
            sponderManagerMainMenu.Show();
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells[0].Value.ToString());

                    var q = db.Bookings.Where(x => x.bookingId == ID).FirstOrDefault();
                    if(q.Package.packageQuantity < q.quantityBooked)
                    {
                        MessageBox.Show("Cannot be approved as not enough quantity availabile");
                        return;
                    }
                    else{
                        q.Package.packageQuantity -= q.quantityBooked;
                    }
                    
                    q.status = "Approved";
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }

                var qq = db.Bookings.OrderBy(x => x.status == "Pending" ? 1 : x.status == "Approved" ? 2 : 3).ThenBy(x => x.User.name).ToList();
                dataGridView1.DataSource = cdt(qq);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells[0].Value.ToString());

                    var q = db.Bookings.Where(x => x.bookingId == ID).FirstOrDefault();

                    //Since it is rejected, the amounts will all not minus from the package quantity
                    q.status = "Rejected";
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }

                var qq = db.Bookings.OrderBy(x => x.status == "Pending" ? 1 : x.status == "Approved" ? 2 : 3).ThenBy(x => x.User.name).ToList();
                dataGridView1.DataSource = cdt(qq);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }
    }
}
