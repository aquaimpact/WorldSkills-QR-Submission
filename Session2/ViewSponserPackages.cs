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
    public partial class ViewSponserPackages : Form
    {
        User users;
        public ViewSponserPackages(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void ViewSponserPackages_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //They can see a table of all the sponsorship packages 
                //for this event, including those with zero quantity.

                //When the screen is first loaded, by default, the 
                //packages should be sorted by their tier and name
                var q = db.Packages.OrderBy(x => x.packageTier == "Bronze" ? 1 : x.packageTier == "Silver" ? 2 : 3).ThenBy(x => x.packageName).ToList();
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
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


        //The user can, however, choose to view this table in 
        //different ways. The user can sort the table according to 
        //the tier(from Gold to Silver to Bronze) or by name.The 
        //user can also choose to sort the table by the value of 
        //each package, either in ascending or descending order.
        private void tier_CheckedChanged(object sender, EventArgs e)
        {
            
            using(var db = new Session2Entities())
            {
                if (tier.Checked)
                {
                    var q = db.Packages.OrderBy(x => x.packageTier == "Bronze" ? 1: x.packageTier == "Silver" ? 2: 3).ToList();
                    dataGridView1.DataSource = CDT(q);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
        }

        private void Name_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                if (Name.Checked)
                {
                    var q = db.Packages.OrderBy(x => x.packageName).ToList();
                    dataGridView1.DataSource = CDT(q);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
        }

        private void valASC_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                if (valASC.Checked)
                {
                    var q = db.Packages.OrderBy(x => x.packageValue).ToList();
                    dataGridView1.DataSource = CDT(q);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
        }

        private void QD_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                if (QD.Checked)
                {
                    var q = db.Packages.OrderByDescending(x => x.packageQuantity).ToList();
                    dataGridView1.DataSource = CDT(q);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponderManagerMainMenu sponderManagerMainMenu = new SponderManagerMainMenu(users);
            sponderManagerMainMenu.Show();
        }

        void removeFilter()
        {
            using (var db = new Session2Entities())
            {

                var q = db.Packages.ToList();
                dataGridView1.DataSource = CDT(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tier.Checked)
            {
                tier.Checked = false;
            }
            if (Name.Checked)
            {
                Name.Checked = false;
            }
            if (QD.Checked)
            {
                QD.Checked = false;
            }
            if (valASC.Checked)
            {
                valASC.Checked = false;
            }
            removeFilter();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
