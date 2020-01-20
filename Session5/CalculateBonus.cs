using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class CalculateBonus : Form
    {

        public CalculateBonus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
        }

        private void CalculateBonus_Load(object sender, EventArgs e)
        {
            using(var db = new Session5Entities())
            {
                var q = db.Skills.ToList();
                foreach(var item in q)
                {
                    skill.Items.Add(item.skillName);
                }
            }
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new Session5Entities())
            {
                var skillidx = skill.SelectedIndex + 1;
                var q = db.Competitors.Where(x => x.skillIdFK == skillidx).ToList();
                name.Items.Clear();
                foreach(var item in q)
                {
                    name.Items.Add(item.competitorName);
                }
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            using( var db = new Session5Entities())
            {
                var id = skill.SelectedIndex + 1;
                var q = db.Competitions.Where(x => x.skillIdFK == id).ToList();
                dataGridView1.DataSource = cdt(q);
            }
        }

        DataTable cdt(List<Competition> competitions)
        {
            double bonus = 0.00;
            double totalamt = 0.00;

            DataTable dt = new DataTable();
            dt.Columns.Add("Question");
            dt.Columns.Add("Marks Received");
            dt.Columns.Add("Max Possible Marks");
            dt.Columns.Add("Amount Received ($)");
            foreach(var item in competitions)
            {
                if(item.sessionNo == 1)
                {
                    //Header
                    DataRow dr = dt.NewRow();
                    dr["Question"] = "Session 1 (Total marks = " + (item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks).ToString() + " )";
                    dt.Rows.Add(dr);

                    using(var db = new Session5Entities())
                    {
                        var total = item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks;
                        var compname = name.Text;
                        var q = db.Results.Where(x => x.Competitor.competitorName == compname && x.competitionIdFK == item.competitionId).FirstOrDefault();
                        if (item.q1MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 1";
                            try
                            {
                                dr2["Marks Received"] = q.q1Marks;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                var mm = (double)item.q1MaxMarks;
                                var m = q.q1Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q2MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 2";
                            try
                            {
                                dr2["Marks Received"] = q.q2Marks;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                var mm = (double)item.q2MaxMarks;
                                var m = q.q2Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q3MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 3";
                            try
                            {
                                dr2["Marks Received"] = q.q3Marks;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                var mm = (double)item.q3MaxMarks;
                                var m = q.q3Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q4MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 4";
                            try
                            {
                                dr2["Marks Received"] = q.q4Marks;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                var mm = (double)item.q4MaxMarks;
                                var m = q.q4Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }

                        //Bonuses
                        try
                        {
                            if (q.totalMarks > total * 0.75)
                            {
                                bonus += 5;
                            }
                            var median = item.Skill.expectedMedianMark;
                            if (q.totalMarks > median)
                            {
                                bonus += 10;
                            }
                        }
                        catch
                        {
                            
                        }
                    }
                }
                if (item.sessionNo == 2)
                {
                    //Header
                    DataRow dr = dt.NewRow();
                    dr["Question"] = "Session 2 (Total marks = " + (item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks).ToString() + " )";
                    dt.Rows.Add(dr);

                    using (var db = new Session5Entities())
                    {
                        var total = item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks;
                        var compname = name.Text;
                        var q = db.Results.Where(x => x.Competitor.competitorName == compname && x.competitionIdFK == item.competitionId).FirstOrDefault();
                        if (item.q1MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 1";
                            try
                            {
                                dr2["Marks Received"] = q.q1Marks;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                var mm = (double)item.q1MaxMarks;
                                var m = q.q1Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q2MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 2";
                            try
                            {
                                dr2["Marks Received"] = q.q2Marks;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                var mm = (double)item.q2MaxMarks;
                                var m = q.q2Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q3MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 3";
                            try
                            {
                                dr2["Marks Received"] = q.q3Marks;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                var mm = (double)item.q3MaxMarks;
                                var m = q.q3Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q4MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 4";
                            try
                            {
                                dr2["Marks Received"] = q.q4Marks;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                var mm = (double)item.q4MaxMarks;
                                var m = q.q4Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }

                        //Bonuses
                        try
                        {
                            if (q.totalMarks > total * 0.75)
                            {
                                bonus += 5;
                            }
                            var median = item.Skill.expectedMedianMark;
                            if (q.totalMarks > median)
                            {
                                bonus += 10;
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                if (item.sessionNo == 3)
                {
                    //Header
                    DataRow dr = dt.NewRow();
                    dr["Question"] = "Session 3 (Total marks = " + (item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks).ToString() + " )";
                    dt.Rows.Add(dr);

                    using (var db = new Session5Entities())
                    {
                        var total = item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks;
                        var compname = name.Text;
                        var q = db.Results.Where(x => x.Competitor.competitorName == compname && x.competitionIdFK == item.competitionId).FirstOrDefault();
                        if (item.q1MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 1";
                            try
                            {
                                dr2["Marks Received"] = q.q1Marks;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                var mm = (double)item.q1MaxMarks;
                                var m = q.q1Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q2MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 2";
                            try
                            {
                                dr2["Marks Received"] = q.q2Marks;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                var mm = (double)item.q2MaxMarks;
                                var m = q.q2Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q3MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 3";
                            try
                            {
                                dr2["Marks Received"] = q.q3Marks;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                var mm = (double)item.q3MaxMarks;
                                var m = q.q3Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q4MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 4";
                            try
                            {
                                dr2["Marks Received"] = q.q4Marks;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                var mm = (double)item.q4MaxMarks;
                                var m = q.q4Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }

                        //Bonuses
                        try
                        {
                            if (q.totalMarks > total * 0.75)
                            {
                                bonus += 5;
                            }
                            var median = item.Skill.expectedMedianMark;
                            if (q.totalMarks > median)
                            {
                                bonus += 10;
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                if (item.sessionNo == 4)
                {
                    //Header
                    DataRow dr = dt.NewRow();
                    dr["Question"] = "Session 4 (Total marks = " + (item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks).ToString() + " )";
                    dt.Rows.Add(dr);

                    using (var db = new Session5Entities())
                    {
                        var total = item.q1MaxMarks + item.q2MaxMarks + item.q3MaxMarks + item.q4MaxMarks;
                        var compname = name.Text;
                        var q = db.Results.Where(x => x.Competitor.competitorName == compname && x.competitionIdFK == item.competitionId).FirstOrDefault();
                        if (item.q1MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 1";
                            try
                            {
                                dr2["Marks Received"] = q.q1Marks;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                var mm = (double)item.q1MaxMarks;
                                var m = q.q1Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q1MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q2MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 2";
                            try
                            {
                                dr2["Marks Received"] = q.q2Marks;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                var mm = (double)item.q2MaxMarks;
                                var m = q.q2Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q2MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q3MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 3";
                            try
                            {
                                dr2["Marks Received"] = q.q3Marks;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                var mm = (double)item.q3MaxMarks;
                                var m = q.q3Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q3MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }
                        if (item.q4MaxMarks != 0)
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["Question"] = "Question 4";
                            try
                            {
                                dr2["Marks Received"] = q.q4Marks;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                var mm = (double)item.q4MaxMarks;
                                var m = q.q4Marks;
                                var mt = (double)total;
                                double maxamt = (mm / mt) * 100.0;
                                double givenamt = (m / mm) * maxamt;
                                dr2["Amount Received ($)"] = givenamt;
                                totalamt += givenamt;
                            }
                            catch
                            {
                                dr2["Marks Received"] = 0;
                                dr2["Max Possible Marks"] = item.q4MaxMarks;
                                dr2["Amount Received ($)"] = 0;
                                totalamt += 0;
                            }
                            dt.Rows.Add(dr2);
                        }

                        //Bonuses
                        try
                        {
                            if (q.totalMarks > total * 0.75)
                            {
                                bonus += 5;
                            }
                            var median = item.Skill.expectedMedianMark;
                            if (q.totalMarks > median)
                            {
                                bonus += 10;
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }

            totalBonus.Text = "$" + bonus.ToString();
            TotalAmtReceive.Text = "$" + Decimal.Round((decimal)totalamt, 2).ToString();
            return dt;
        }
    }
}
