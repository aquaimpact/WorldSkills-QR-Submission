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
    public partial class EnterMarks : Form
    {
        Session5Entities db = new Session5Entities();
        List<List<string>> strs = new List<List<string>>();
        public EnterMarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EnterMarks_Load(object sender, EventArgs e)
        {
            //The user must first choose the skill that they want to focus on, from the drop‐down list.
            //The system currently only supports two skills – Software Solutions and Web Tech.
            var q = db.Skills.ToList();
            foreach (var item in q)
            {
                skill.Items.Add(item.skillName);
            }
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Once the user selects a skill, the names of all the competitors in that skill are added to the
            //drop‐down list for competitors’ names.
            var ID = skill.SelectedIndex + 1;
            var q = db.Competitors.Where(x => x.skillIdFK == ID).ToList();
            var qq = db.Competitions.Where(x => x.skillIdFK == ID).ToList();
            sname.Items.Clear();
            sname.Text = null;
            foreach (var item in q)
            {
                sname.Items.Add(item.competitorName);
            }

            //Once the user selects a skill, the number of available sessions in the drop‐down list is updated
            //based on the skill selected(i.e.each skill could have a different number of sessions)
            session.Items.Clear();
            session.Text = null;
            foreach (var item in qq)
            {
                session.Items.Add(item.sessionNo);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void session_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the user selects a session, the table is
            //automatically updated to show one row for each question in that session.  
            var ID = skill.SelectedIndex + 1;
            var text = session.SelectedIndex + 1;
            var ses = session.SelectedIndex + 1;
            var qw = db.Competitions.Where(x => x.skillIdFK == ID && x.sessionNo == ses).FirstOrDefault();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cdt(qw);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["MM"].Visible = false;
            BTGV();
        }

        DataTable cdt(Competition competition)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MM");
            dt.Columns.Add("Question");
            dt.Columns.Add("Marks");
            if (competition.q1MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 1";
                dr["Marks"] = 0;
                dr["MM"] = competition.q1MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.q2MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 2";
                dr["Marks"] = 0;
                dr["MM"] = competition.q2MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.q3MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 3";
                dr["Marks"] = 0;
                dr["MM"] = competition.q3MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.q4MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 4";
                dr["Marks"] = 0;
                dr["MM"] = competition.q4MaxMarks;
                dt.Rows.Add(dr);
            }
            return dt;
        }


        void BTGV()
        {
            DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
            List<String> items = new List<String>();
            items.Add("Good");
            items.Add("Average");
            items.Add("Poor");
            cmbdgv.DataSource = items;
            cmbdgv.HeaderText = "Grades";
            dataGridView1.Columns.Insert(2, cmbdgv);
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
                if (dr.Cells[2].Value != null)
                {
                    var grade = dr.Cells[2].Value.ToString();
                    using (var db = new Session5Entities())
                    {
                        double marks = 0;
                        var mm = double.Parse(dr.Cells[0].Value.ToString());
                        if (grade == "Good")
                        {
                            marks = mm;
                        }
                        else if (grade == "Average")
                        {
                            marks = mm * 0.65;
                        }
                        else if (grade == "Poor")
                        {
                            marks = mm * 0.2;
                        }
                        var mark = decimal.Round(decimal.Parse(marks.ToString()), 1);
                        dr.Cells[3].Value = mark;
                    }
                }
            }
            if (e.ColumnIndex == 3)
            {
                var total = 0.0;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    var marks = double.Parse(dr.Cells[3].Value.ToString());
                    total += marks;
                }
                Total.Text = total.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                dr.Cells[2].Value = null;
                dr.Cells[3].Value = 0;
            }
        }

        private void Sumbit_Click(object sender, EventArgs e)
        {
            
            using (var db = new Session5Entities())
            {
                var name = sname.Text;
                var q = db.Results.Where(x => x.Competitor.competitorName == name).FirstOrDefault();
                if(q != null)
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        if (dr.Cells[1].Value.ToString().Contains("1"))
                        {
                            q.q1Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("2"))
                        {
                            q.q2Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("3"))
                        {
                            q.q3Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("4"))
                        {
                            q.q4Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }
                    }

                    try
                    {
                        q.totalMarks = double.Parse(Total.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid total marks!");
                        return;
                    }

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Successful!");

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
                else
                {
                    Result result = new Result();
                    var ID = skill.SelectedIndex + 1;
                    var ses = session.SelectedIndex + 1;
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Invalid name!");
                        return;
                    }
                    if (string.IsNullOrEmpty(skill.Text))
                    {
                        MessageBox.Show("Invalid skill!");
                        return;
                    }
                    if (string.IsNullOrEmpty(session.Text))
                    {
                        MessageBox.Show("Invalid session!");
                        return;
                    }
                    var comps = db.Competitors.Where(x => x.competitorName == name).FirstOrDefault();
                    var comp = db.Competitions.Where(x => x.skillIdFK == ID && x.sessionNo == ses).FirstOrDefault();
                    result.recordsIdFK = comps.recordsId;
                    result.competitionIdFK = comp.competitionId;
                    result.q1Marks = 0;
                    result.q2Marks = 0;
                    result.q3Marks = 0;
                    result.q4Marks = 0;
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        if (dr.Cells[1].Value.ToString().Contains("1"))
                        {
                            result.q1Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("2"))
                        {
                            result.q2Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("3"))
                        {
                            result.q3Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }

                        if (dr.Cells[1].Value.ToString().Contains("4"))
                        {
                            result.q4Marks = double.Parse(dr.Cells[3].Value.ToString());
                        }
                    }
                    try
                    {
                        result.totalMarks = double.Parse(Total.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid total marks!");
                    }

                    try
                    {
                        db.Results.Add(result);
                        db.SaveChanges();
                        MessageBox.Show("Successful!");

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
        }

        private void sname_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session5Entities())
            {
                var ID = skill.SelectedIndex + 1;
                var ses = session.SelectedIndex + 1;

                var name = sname.Text;
                var IDs = db.Competitors.Where(x => x.competitorName == name).FirstOrDefault();
                var qw = db.Competitions.Where(x => x.skillIdFK == ID && x.sessionNo == ses).FirstOrDefault();
                var q = db.Results.Where(x => x.recordsIdFK == IDs.recordsId && x.competitionIdFK == qw.competitionId).FirstOrDefault();
                if (q == null)
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = cdt(qw);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["MM"].Visible = false;
                    BTGV();
                }
                else
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = ucdt(q);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns["MM"].Visible = false;
                    BTGV();
                }
            }
        }

        DataTable ucdt(Result competition)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MM");
            dt.Columns.Add("Question");
            dt.Columns.Add("Marks");
            if (competition.Competition.q1MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 1";
                dr["Marks"] = competition.q1Marks;
                dr["MM"] = competition.Competition.q1MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.Competition.q2MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 2";
                dr["Marks"] = competition.q2Marks;
                dr["MM"] = competition.Competition.q2MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.Competition.q3MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 3";
                dr["Marks"] = competition.q3Marks;
                dr["MM"] = competition.Competition.q3MaxMarks;
                dt.Rows.Add(dr);
            }
            if (competition.Competition.q4MaxMarks != 0)
            {
                DataRow dr = dt.NewRow();
                dr["Question"] = "Question 4";
                dr["Marks"] = competition.q4Marks;
                dr["MM"] = competition.Competition.q4MaxMarks;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
