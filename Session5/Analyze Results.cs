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

namespace Session5
{
    public partial class Analyze_Results : Form
    {
        Session5Entities db = new Session5Entities();
        public Analyze_Results()
        {
            InitializeComponent();
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Easiest Session
            //Easiest Session
            var ID = skill.SelectedIndex + 1;
            var competition = db.Competitions.Where(x => x.skillIdFK == ID).ToList();

            var maxmax = 0.0;
            var sessionNo = 0;
            var competNo = 0;
            foreach (var item in competition)
            {
                var results = db.Results.Where(x => x.competitionIdFK == item.competitionId);
                if (results.FirstOrDefault() != null)
                {
                    var avg = results.Average(x => x.totalMarks);
                    if (avg > maxmax)
                    {
                        maxmax = avg;
                        competNo = item.competitionId;
                        sessionNo = item.sessionNo;
                    }
                }
            }
            var highResult = db.Results.Where(x => x.competitionIdFK == competNo).ToList();
            if (highResult.Count() != 0)
            {
                var lol = highResult.Max(x => x.totalMarks);
                var lol2 = highResult.Min(x => x.totalMarks);
                ES.Text = sessionNo.ToString() + " (" + lol2 + " - " + lol + ")";
            }
            else
            {
                ES.Text = "";
            }
            #endregion

            #region Toughest Session
            //Toughest Session
            var min = 100000.0;

            var session = 0;
            var compet = 0;
            foreach (var item in competition)
            {
                var results = db.Results.Where(x => x.competitionIdFK == item.competitionId);
                if (results.FirstOrDefault() != null)
                {
                    var avg = results.Average(x => x.totalMarks);
                    if (avg < min)
                    {
                        min = avg;
                        compet = item.competitionId;
                        session = item.sessionNo;
                    }
                }
            }
            var results1 = db.Results.Where(x => x.competitionIdFK == compet).ToList();
            if (results1.FirstOrDefault() != null)
            {
                var lol = results1.Max(x => x.totalMarks);
                var lol2 = results1.Min(x => x.totalMarks);
                TS.Text = session.ToString() + " (" + lol2 + " - " + lol + ")";
            }
            else
            {
                TS.Text = "";
            }
            #endregion

            #region Median Results
            //Median
            var q = db.Skills.Where(x => x.skillId == ID).FirstOrDefault();
            var medianmark = q.expectedMedianMark;
            var q2 = db.Results.Where(x => x.Competition.skillIdFK == ID).OrderBy(x => x.totalMarks).ToList();
            if(q2.Count != 0)
            {
                if (q2.Count() % 2 == 0)
                {
                    var mid = q2.Count() / 2;
                    var mid1 = mid + 1;
                    var totalMedianMark = (q2[mid-1].totalMarks + q2[mid1-1].totalMarks) / 2;
                    if (totalMedianMark > medianmark)
                    {
                        //Show green
                        panel3.Visible = true;
                        panel2.Visible = false;
                    }
                    else
                    {
                        //Show red
                        panel3.Visible = false;
                        panel2.Visible = true;
                    }
                    MM.Text = totalMedianMark.ToString();
                }
                else
                {
                    int mid = q2.Count() / 2;
                    mid += 1;
                    var lol = q2[mid].totalMarks;
                    if (lol > medianmark)
                    {
                        panel3.Visible = true;
                        panel2.Visible = false;
                    }
                    else
                    {
                        panel3.Visible = false;
                        panel2.Visible = true;
                    }
                    MM.Text = lol.ToString();
                }
            }
            else
            {
                MM.Text = "";
            }
            #endregion
            
            #region Best Performing Country
            //Best
            var qq = db.Results.Where(x => x.Competition.skillIdFK == ID);
            Dictionary<string, double> i = new Dictionary<string, double>();
            if (qq.FirstOrDefault() != null)
            {
                var lol = qq.GroupBy(x => x.Competitor.competitorCountry).ToList();
                foreach(var item in lol)
                {
                    i.Add(item.Key, item.Average(x => x.totalMarks));
                }
            }

            var max = 0.0;
            var country = "";
            foreach (KeyValuePair<string, double> entry in i)
            {
                if (entry.Value > max)
                {
                    max = entry.Value;
                    country = entry.Key;
                }
            }

            BPC.Text = country;
            var pics = new List<string>

                {

                    @"D:\WorldSkills\Sessions\Session5\Images\singapore_flag1.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\flagmalaysia.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\indonesia2.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\flg_philippine1.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\flg_thailand.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\brunei_flag.png",

                    @"D:\WorldSkills\Sessions\Session5\Images\flag_cambodia.png"

                };

            if (country == "Malaysia")
            {
                pictureBox1.Image = Image.FromFile(pics[1]);
            }
            else if (country == "Indonesia")
            {
                pictureBox1.Image = Image.FromFile(pics[2]);
            }
            else if (country == "Philippines")
            {
                pictureBox1.Image = Image.FromFile(pics[3]);
            }
            else if (country == "Thailand")
            {
                pictureBox1.Image = Image.FromFile(pics[4]);
            }
            else if (country == "Brunei")
            {
                pictureBox1.Image = Image.FromFile(pics[5]);
            }
            
            #endregion

            #region Creating the Trend Graph
            using (var db = new Session5Entities())
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Trend of Competitors Results");
                var results = db.Results.Where(x => x.Competitor.skillIdFK == ID).GroupBy(x => x.Competition.sessionNo).ToList();
                var currSession = 0;
                foreach (var item in results)
                {
                    var sessionNum = "Session " + item.Key.ToString();
                    foreach(var items in item)
                    {
                        try
                        {
                            chart1.Series.Add(new Series(items.Competitor.competitorName));
                        }
                        catch
                        {

                        }
                        chart1.Series[items.Competitor.competitorName].ChartType = SeriesChartType.Line;
                        var idx = chart1.Series[items.Competitor.competitorName].Points.AddXY(sessionNum, items.totalMarks);
                        currSession = item.Key;
                        chart1.Series[items.Competitor.competitorName].Points[idx].AxisLabel = sessionNum;
                        chart1.Series[items.Competitor.competitorName].IsValueShownAsLabel = true;
                    }
                }
                var remaining = db.Competitions.Where(x => x.sessionNo > currSession && x.skillIdFK == ID);
                if (remaining.FirstOrDefault() != null)
                {
                    var rem = remaining.ToList();
                    foreach (var item in remaining)
                    {
                        for (int ii = 0; ii < chart1.Series.ToList().Count(); ii++)
                        {
                            chart1.Series[ii].Points.AddXY("Session " + item.sessionNo.ToString(), 0);
                        }
                    }
                }
            }
            #endregion

        }

        private void Analyze_Results_Load(object sender, EventArgs e)
        {
            var q = db.Skills.ToList();
            foreach( var item in q)
            {
                skill.Items.Add(item.skillName);
            }
        }

        private void BPC_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
        }
    }
}
