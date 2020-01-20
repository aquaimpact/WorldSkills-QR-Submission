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
    public partial class ViewResults : Form
    {
        Session5Entities db = new Session5Entities();
        public ViewResults()
        {
            InitializeComponent();
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {
            var Q = db.Skills.ToList();
            foreach( var item in Q)
            {
                skill.Items.Add(item.skillName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = skill.SelectedIndex + 1;
            var q = db.Competitions.Where(x => x.skillIdFK == ID).ToList();
            total.Text = q.Count().ToString();
            var count = 0;

            #region populating Data grid View
            //Go through each session
            foreach ( var item in q)
            {
                //Get the results for that session (for those that are there)
                var q2 = db.Results.Where(x => x.competitionIdFK == item.competitionId).ToList();
                foreach( var i in q2)
                {
                    if (i.q1Marks == 0)
                    {
                        count = 0;
                        continue;
                    }
                    else if(i.q2Marks == 0)
                    {
                        count = 0;
                        continue;
                    }
                    else if (i.q3Marks == 0)
                    {
                        count = 0;
                        continue;

                    }
                    else if (i.q4Marks == 0)
                    {
                        count = 0;
                        continue;

                    }
                    count += 1;
                }

                var q3 = db.Competitors.Where(x => x.skillIdFK == ID).ToList();
                foreach(var i in q3)
                {
                    var q4 = db.Results.Where(x => x.recordsIdFK == i.recordsId).FirstOrDefault();
                    if(q4 == null)
                    {
                        count = 0;
                        continue;
                    }
                }
            }

            completed.Text = count.ToString();

            var qq = db.Competitors.Where(x => x.skillIdFK == ID).ToList();
            dataGridView1.DataSource = cdt(qq);
            dataGridView1.Columns["MM"].Visible = false;
            #endregion

            #region Getting the Gold, Silver and Bronze People
            //Lists that contain all the G,S and B people!
            Dictionary<string, double> vsG = new Dictionary<string, double>();
            Dictionary<string, double> vsS = new Dictionary<string, double>();
            Dictionary<string, double> vsB = new Dictionary<string, double>();

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                var total = double.Parse(dr.Cells["Total Marks"].Value.ToString());
                var max = double.Parse(dr.Cells["MM"].Value.ToString());
                if (total > max * 0.8)
                {
                    vsG.Add(dr.Cells["Competitor"].Value.ToString(), total);
                }
                else if( total > max * 0.75)
                {
                    vsS.Add(dr.Cells["Competitor"].Value.ToString(), total);
                }
                else if(total > max * 0.71)
                {
                    vsB.Add(dr.Cells["Competitor"].Value.ToString(), total);
                }
            }

            if(vsG.Count > 1)
            {
                var vsG2 = vsG.OrderByDescending(x => x.Value).ToList();
                var maxN = vsG2[0].Value;
                vsG.Clear();
                for (int i = 0; i < vsG2.Count(); i++)
                {
                    if(vsG2[i].Value == maxN || vsG2[i].Value >= maxN - 2.0)
                    {
                        vsG.Add(vsG2[i].Key, vsG2[i].Value);
                    }
                    else
                    {
                        vsS.Add(vsG2[i].Key, vsG2[i].Value);
                    }
                }
            }

            if (vsS.Count > 1)
            {
                var vsS2 = vsS.OrderByDescending(x => x.Value).ToList();
                var maxN = vsS2[0].Value;
                vsS.Clear();
                for (int i = 0; i < vsS2.Count(); i++)
                {
                    if (vsS2[i].Value == maxN || vsS2[i].Value >= maxN - 2.0)
                    {
                        vsS.Add(vsS2[i].Key, vsS2[i].Value);
                    }
                    else
                    {
                        vsB.Add(vsS2[i].Key, vsS2[i].Value);
                    }
                }
            }

            if (vsB.Count > 1)
            {
                var vsB2 = vsB.OrderByDescending(x => x.Value).ToList();
                var maxN = vsB2[0].Value;
                vsB.Clear();
                for (int i = 0; i < vsB2.Count(); i++)
                {
                    if (vsB2[i].Value == maxN || vsB2[i].Value >= maxN - 2.0)
                    {
                        vsB.Add(vsB2[i].Key, vsB2[i].Value);
                    }
                }
            }

            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Columns.Clear();
            dataGridView2.DataSource = cdt1(vsG);
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn.HeaderText = "Image";
            dataGridView2.Columns.Add(dataGridViewImageColumn);
            dataGridView2.Columns[0].Visible = false;

            DataGridViewImageColumn dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn1.HeaderText = "Image";
            dataGridView3.DataSource = cdt1(vsS);
            dataGridView3.Columns.Add(dataGridViewImageColumn1);
            dataGridView3.Columns[0].Visible = false;

            DataGridViewImageColumn dataGridViewImageColumn2 = new DataGridViewImageColumn();
            dataGridViewImageColumn2.HeaderText = "Image";
            dataGridView4.DataSource = cdt1(vsB);
            dataGridView4.Columns.Add(dataGridViewImageColumn2);
            dataGridView4.Columns[0].Visible = false;

            //Testing Code!
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                var key = dr.Cells[0].Value.ToString();
                dr.Cells[1].Style.BackColor = Color.Transparent;
                if (key.Equals("Singapore"))
                {
                    dr.Cells[1].Value = imageList1.Images[6];
                }
                else if (key.Equals("Malaysia"))
                {
                    dr.Cells[1].Value = imageList1.Images[2];
                }
                else if (key.Equals("Indonesia"))
                {
                    dr.Cells[1].Value = imageList1.Images[5];
                }
                else if (key.Equals("Philippines"))
                {
                    dr.Cells[1].Value = imageList1.Images[3];
                }
                else if (key.Equals("Thailand"))
                {
                    dr.Cells[1].Value = imageList1.Images[4];
                }
                else if (key.Equals("Brunei"))
                {
                    dr.Cells[1].Value = imageList1.Images[0];
                }
                else if (key.Equals("Cambodia"))
                {
                    dr.Cells[1].Value = imageList1.Images[1];
                }
            }
            foreach (DataGridViewRow dr in dataGridView3.Rows)
            {
                var key = dr.Cells[0].Value.ToString();
                dr.Cells[1].Style.BackColor = Color.Transparent;
                if (key.Equals("Singapore"))
                {
                    dr.Cells[1].Value = imageList1.Images[6];
                }
                else if (key.Equals("Malaysia"))
                {
                    dr.Cells[1].Value = imageList1.Images[2];
                }
                else if (key.Equals("Indonesia"))
                {
                    dr.Cells[1].Value = imageList1.Images[5];
                }
                else if (key.Equals("Philippines"))
                {
                    dr.Cells[1].Value = imageList1.Images[3];
                }
                else if (key.Equals("Thailand"))
                {
                    dr.Cells[1].Value = imageList1.Images[4];
                }
                else if (key.Equals("Brunei"))
                {
                    dr.Cells[1].Value = imageList1.Images[0];
                }
                else if (key.Equals("Cambodia"))
                {
                    dr.Cells[1].Value = imageList1.Images[1];
                }
            }
            foreach (DataGridViewRow dr in dataGridView4.Rows)
            {
                var key = dr.Cells[0].Value.ToString();
                dr.Cells[1].Style.BackColor = Color.Transparent;
                if (key.Equals("Singapore"))
                {
                    dr.Cells[1].Value = imageList1.Images[6];
                }
                else if (key.Equals("Malaysia"))
                {
                    dr.Cells[1].Value = imageList1.Images[2];
                }
                else if (key.Equals("Indonesia"))
                {
                    dr.Cells[1].Value = imageList1.Images[5];
                }
                else if (key.Equals("Philippines"))
                {
                    dr.Cells[1].Value = imageList1.Images[3];
                }
                else if (key.Equals("Thailand"))
                {
                    dr.Cells[1].Value = imageList1.Images[4];
                }
                else if (key.Equals("Brunei"))
                {
                    dr.Cells[1].Value = imageList1.Images[0];
                }
                else if (key.Equals("Cambodia"))
                {
                    dr.Cells[1].Value = imageList1.Images[1];
                }
            }
            #endregion

        }

        DataTable cdt(List<Competitor> competitors)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Competitor");
            dt.Columns.Add("Country");
            dt.Columns.Add("Total Marks");
            dt.Columns.Add("MM");
            foreach( var item in competitors)
            {
                DataRow dr = dt.NewRow();
                dr["Competitor"] = item.competitorName;
                dr["Country"] = item.competitorCountry;
                var ID = skill.SelectedIndex + 1;
                var q = db.Results.Where(x => x.recordsIdFK == item.recordsId);
                if( q.FirstOrDefault() != null)
                {
                    dr["Total Marks"] = q.Sum(x => x.totalMarks);
                    var lols = db.Competitions.Where(x => x.skillIdFK == ID);
                    var q1 = lols.Sum(x => x.q1MaxMarks);
                    var q2 = lols.Sum(x => x.q2MaxMarks);
                    var q3 = lols.Sum(x => x.q3MaxMarks);
                    var q4 = lols.Sum(x => x.q4MaxMarks);
                    dr["MM"] = q1 + q2 + q3 + q4;
                    dt.Rows.Add(dr);
                }
                else
                {
                    continue;
                }
                
            }
            return dt;
        }

        DataTable cdt1(Dictionary<string, double> keyValuePairs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Col1");

            foreach(var item in keyValuePairs)
            {
                DataRow dr = dt.NewRow();
                using(var db = new Session5Entities())
                {
                    var q = db.Competitors.Where(x => x.competitorName == item.Key).FirstOrDefault();
                    dr["Col1"] = q.competitorCountry;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

       

        
    }
}
