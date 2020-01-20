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
    public partial class ViewSponsershipSummary : Form
    {
        User users;
        public ViewSponsershipSummary(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponderManagerMainMenu sponderManagerMainMenu = new SponderManagerMainMenu(users);
            sponderManagerMainMenu.Show();
        }

        private void ViewSponsershipSummary_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var q = db.Packages.Select(x => x.packageTier).Distinct().OrderBy(x => x == "Bronze" ? 1 : x == "Silver" ? 2 : 3).ToList();
                tier.Items.Add("All Tiers");
                foreach (var item in q)
                {
                    tier.Items.Add(item);
                }
                tier.SelectedIndex = 0;

                //This screen only shows the packages that the sponsor
                var qq = db.Bookings.Where(x => x.status == "Approved").ToList();
                addchart(qq);

            }
        }

        //When the user selects a different option from the drop‐down list,
        //the chart should automatically refresh.
        private void tier_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                List<Booking> qq = new List<Booking>();
                if (tier.Text == "All Tiers")
                {
                    //This screen only shows the packages that the sponsor
                    qq = db.Bookings.Where(x => x.status == "Approved").ToList();
                }
                else
                {
                    //This screen only shows the packages that the sponsor
                    qq = db.Bookings.Where(x => x.status == "Approved" && x.Package.packageTier == tier.Text).ToList();
                }
                addchart(qq);
            }
        }

        void addchart(List<Booking> bookings)
        {
            //The screen also shows the total value of the packages that 
            //are currently shown on the screen.
            var total = bookings.Sum(x => x.Package.packageValue * x.quantityBooked);
            totalValTxt.Text = total.ToString();

            chart1.Series[0].Points.Clear();

            //The number of approved packages for each tier of
            //package is shown in a pie chart.
            foreach (var item in bookings.GroupBy(x => x.Package.packageName).ToList())
            {
                chart1.Series[0].Points.AddXY(item.Key, item.Sum(x => x.quantityBooked));
            }

            //The legend for the chart should be shown below the chart.
                        chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            //When the user mouseovers a segment of the pie chart, 
            //there should be a pop‐up that shows the name of the 
            //tier, quantity of package bookings approved for that 
            //tier and percentage of that segment out of the entire
            //pie chart that is currently shown.
            chart1.Series[0].ToolTip = "#VALX, #VAL, #PERCENT";
        }
    }
}
