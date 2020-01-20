using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Session3
{
    public partial class GuestsSummary : Form
    {
        User users;
        public GuestsSummary(User user)
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

        private void GuestsSummary_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All Guests");
            comboBox1.Items.Add("Delegates");
            comboBox1.Items.Add("Competitors");
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new Session3Entities())
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    var q = db.Arrivals.ToList();
                    chart1.Series.Clear();
                    var count = 0;
                    chart1.Series.Add(new Series("Delegates"));
                    chart1.Series.Add(new Series("Competitors"));
                    chart1.Series["Delegates"].Points.Clear();
                    chart1.Series["Competitors"].Points.Clear();
                    foreach (var item in q)
                    {
                        count++;
                        var noDels = item.numberDelegate;
                        var noHead = item.numberHead;
                        var noComps = item.numberCompetitors;
                        
                        
                        chart1.Series["Delegates"].ChartType = SeriesChartType.StackedColumn;
                        var idx = chart1.Series["Delegates"].Points.AddXY(item.User.countryName, noDels + noHead);
                        //chart1.Series["Delegates"].Points[idx].AxisLabel = item.User.countryName;
                        chart1.Series["Delegates"].Points[idx].IsValueShownAsLabel = true;

                        
                        
                        chart1.Series["Competitors"].ChartType = SeriesChartType.StackedColumn;
                        var idx2 = chart1.Series["Competitors"].Points.AddXY(item.User.countryName, noComps);
                        //chart1.Series["Competitors"].Points[idx2].AxisLabel = item.User.countryName;
                        chart1.Series["Competitors"].Points[idx2].IsValueShownAsLabel = true;

                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    var q = db.Arrivals.ToList();
                    chart1.Series.Clear();
                    var count = 0;
                    foreach (var item in q)
                    {
                        count++;
                        var noDels = item.numberDelegate;
                        var noHead = item.numberHead;
                        //var noComps = item.numberCompetitors;
                        chart1.Series.Add(new Series(item.User.countryName));
                        chart1.Series[item.User.countryName].Points.Clear();
                        var idx = chart1.Series[item.User.countryName].Points.AddXY(count, noDels + noHead);
                        chart1.Series[item.User.countryName].Points[idx].AxisLabel = item.User.countryName;
                        chart1.Series[item.User.countryName].Points[idx].Label = (noDels + noHead).ToString();
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    var q = db.Arrivals.ToList();
                    chart1.Series.Clear();
                    var count = 0;
                    foreach (var item in q)
                    {
                        count++;
                        //var noDels = item.numberDelegate;
                        //var noHead = item.numberHead;
                        var noComps = item.numberCompetitors;
                        chart1.Series.Add(new Series(item.User.countryName));
                        chart1.Series[item.User.countryName].Points.Clear();
                        var idx = chart1.Series[item.User.countryName].Points.AddXY(count, noComps);
                        chart1.Series[item.User.countryName].Points[idx].AxisLabel = item.User.countryName;
                        chart1.Series[item.User.countryName].Points[idx].Label = noComps.ToString();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
