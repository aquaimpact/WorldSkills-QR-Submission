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
    public partial class Assign_Seating : Form
    {
        public Assign_Seating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Assign_Seating_Load(object sender, EventArgs e)
        {
            using (var db = new Session5Entities())
            {
                //The user must first choose the skill that they want to focus on, from the drop‐down list.
                //The system currently only supports two skills – Software Solutions and Web Tech.
                var q = db.Skills.ToList();
                foreach (var item in q)
                {
                    comboBox1.Items.Add(item.skillName);
                }
            }
        }

        int val = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session5Entities())
            {
                //Once a skill is chosen, the screen shows the total number of competitors for that skill who have
                //already been assigned seats and the number still without seats
                listBox1.Items.Clear();
                var ID = comboBox1.SelectedIndex + 1;
                var q = db.Competitors.Where(x => x.skillIdFK == ID).ToList();

                AssignedNumber.Text = q.Where(x => x.assignedSeat != 0).Count().ToString();
                UnassignedNumber.Text = q.Where(x => x.assignedSeat == 0).Count().ToString();
                val = q.Where(x => x.assignedSeat == 0).Count();
                foreach (var item in q)
                {
                    //On the right of the screen will be a list of all the competitors(i.e.competitor’s name and
                    //their country) who have not been assigned to any seats yet.
                    if (item.assignedSeat == 0)
                    {
                        listBox1.Items.Add(item.competitorName + ", " + item.competitorCountry);
                    }
                }
                dataGridView1.DataSource = cdt(q.Count());

            }
        }

        DataTable cdt(int compNo)
        {
            /*Both values cannot be manually changed but they will be updated accordingly every time the allocation of seats
            on the screen changes. The layout of the venue is shown on the left of the screen and it is
            generated dynamically based on the total number of competitors for the skill (i.e. if there
            are 6 competitors in the skill, then a layout with six seats is generated). The seat
            numbering runs from left to right and top to bottom, starting with seat number 1 at the
            top left corner(refer to the wireframe for a sample seating plan for six competitors).Each
            seat will show the seat number.*/
            DataTable dt = new DataTable();
            dt.Columns.Add("S1");
            dt.Columns.Add("S2");
            if (compNo % 2 == 0)
            {
                for (int i = 0; i < compNo; i += 2)
                {
                    DataRow dr = dt.NewRow();
                    dr["S1"] = i + 1;
                    dr["S2"] = i + 2;
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                for (int i = 0; i < compNo + 1; i += 2)
                {
                    DataRow dr = dt.NewRow();
                    dr["S1"] = i + 1;
                    dr["S2"] = i + 2;
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }


        private void RandomAssign_Click(object sender, EventArgs e)
        {
            using (var db2 = new Session5Entities())
            {
                var idss = comboBox1.SelectedIndex + 1;
                var itemss = db2.Competitors.Where(x => x.skillIdFK == idss).ToList();
                dataGridView1.DataSource = cdt(itemss.Count());
                foreach (var item in itemss)
                {
                    int row, col;
                    DataGridViewCell dc;
                Random:
                    //To help the user, the system has an option to randomly assign the seats. Each time that this button is clicked, the
                    //system will automatically randomly assign the competitors to a seat.
                    Random random = new Random();
                    while (true)
                    {
                        row = random.Next(0, dataGridView1.Rows.Count);
                        col = random.Next(0, dataGridView1.Columns.Count);
                        dc = dataGridView1.Rows[row].Cells[col];
                        if (dc.Style.BackColor != Color.LightBlue)
                        {
                            break;
                        }
                    }

                    using (var db = new Session5Entities())
                    {
                        #region The only constraint is that two competitors from the same country cannot be seated in front or behind one another(e.g.with reference to the wireframe, if the competitor from Malaysia is sitting at seat number 3, then the other competitor from Malaysia cannot sit in seat number 1 or 5.
                        var q = db.Competitors.Where(x => x.competitorName == item.competitorName).FirstOrDefault();
                        if (dc.RowIndex - 1 < 0)
                        {
                            if (dataGridView1.Rows[row + 1].Cells[col].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                            {
                                goto Random;
                            }
                        }
                        else
                        {
                            try
                            {
                                if (dataGridView1.Rows[row + 1].Cells[col].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                {
                                    goto Random;
                                }
                            }
                            catch
                            {

                            }
                            if (dataGridView1.Rows[row - 1].Cells[col].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                            {
                                goto Random;
                            }
                        }
                        #endregion

                        dc.Value = dc.Value + "\n" + q.competitorId;
                        listBox1.Items.Clear();
                        dc.Style.BackColor = Color.LightBlue;
                        dc.Style.WrapMode = DataGridViewTriState.True;
                        dc.ToolTipText = "Name: " + q.competitorName + "\n" + "Country: " + q.competitorCountry;
                        UnassignedNumber.Text = listBox1.Items.Count.ToString();
                        AssignedNumber.Text = (val - listBox1.Items.Count).ToString();

                    }
                }
            }


        }

        private void ManualAssign_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                //So, when the user clicks on a seat and clicks on the name of a competitor from the “Unassigned” list and clicks on
                //the “Manually Assign” button, the system will check for the same seating constraint
                //stated above.
                foreach (DataGridViewCell dc in dataGridView1.SelectedCells)
                {
                    //When the seat is not taken:
                    if (dc.Style.BackColor != Color.LightBlue)
                    {
                        using (var db = new Session5Entities())
                        {
                            if (listBox1.SelectedItem != null)
                            {
                                var name = listBox1.SelectedItem.ToString().Split(',').First();
                                var q = db.Competitors.Where(x => x.competitorName == name).FirstOrDefault();
                                if (dc.RowIndex - 1 < 0)
                                {
                                    if (dataGridView1.Rows[dc.RowIndex + 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                    {
                                        MessageBox.Show("Competitor with the same country cannot be placed together!");
                                        return;
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        if (dataGridView1.Rows[dc.RowIndex + 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                        {
                                            MessageBox.Show("Competitor with the same country cannot be placed together!");
                                            return;
                                        }
                                    }
                                    catch
                                    {

                                    }
                                    if (dataGridView1.Rows[dc.RowIndex - 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                    {
                                        MessageBox.Show("Competitor with the same country cannot be placed together!");
                                        return;
                                    }
                                }

                                //If there is no constraint, then this competitor is assigned to this seat, and
                                //the layout is updated accordingly to show who is sitting in that seat and the competitor’s
                                //name is removed from the “Unassigned” list.
                                dc.Value = dc.Value + "\n" + q.competitorId;
                                listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
                                dc.Style.BackColor = Color.LightBlue;
                                dc.Style.WrapMode = DataGridViewTriState.True;
                                dc.ToolTipText = "Name: " + q.competitorName + "\n" + "Country: " + q.competitorCountry;
                                UnassignedNumber.Text = listBox1.Items.Count.ToString();
                                AssignedNumber.Text = (val - listBox1.Items.Count).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Please select someone!");
                                return;
                            }
                        }
                    }
                    //When the seat is taken:
                    else
                    {
                        using (var db = new Session5Entities())
                        {
                            if (listBox1.SelectedItem != null)
                            {
                                var name = listBox1.SelectedItem.ToString().Split(',').First();
                                var q = db.Competitors.Where(x => x.competitorName == name).FirstOrDefault();
                                if (dc.RowIndex - 1 < 0)
                                {
                                    if (dataGridView1.Rows[dc.RowIndex + 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                    {
                                        MessageBox.Show("Competitor with the same country cannot be placed together!");
                                        return;
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        if (dataGridView1.Rows[dc.RowIndex + 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                        {
                                            MessageBox.Show("Competitor with the same country cannot be placed together!");
                                            return;
                                        }
                                    }
                                    catch
                                    {

                                    }
                                    if (dataGridView1.Rows[dc.RowIndex - 1].Cells[dc.ColumnIndex].Value.ToString().Contains(q.competitorId.Substring(0, 2)))
                                    {
                                        MessageBox.Show("Competitor with the same country cannot be placed together!");
                                        return;
                                    }
                                }

                                //If the seat was previously occupied by
                                // another competitor, then this competitor’s name is added to the “Unassigned” list.
                                dc.Style.BackColor = Color.Transparent;
                                var ID = dc.Value.ToString().Substring(1).Trim();
                                dc.Value = dc.Value.ToString().Substring(0, 1);

                                var sID = comboBox1.SelectedIndex + 1;
                                var comq = db.Competitors.Where(x => x.competitorId == ID && x.skillIdFK == sID).FirstOrDefault();
                                listBox1.Items.Add(comq.competitorName + ", " + comq.competitorCountry);
                                UnassignedNumber.Text = listBox1.Items.Count.ToString();
                                AssignedNumber.Text = (val - listBox1.Items.Count).ToString();

                                dc.Value = dc.Value + "\n" + q.competitorId;
                                listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
                                dc.Style.BackColor = Color.LightBlue;
                                dc.Style.WrapMode = DataGridViewTriState.True;
                                dc.ToolTipText = "Name: " + q.competitorName + "\n" + "Country: " + q.competitorCountry;
                                UnassignedNumber.Text = listBox1.Items.Count.ToString();
                                AssignedNumber.Text = (val - listBox1.Items.Count).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Please select someone!");
                                return;
                            }
                        }

                    }
                }
            }
        }

        //Alternatively, the user may want to swap the seats of two competitors. In such cases,
        //they can click on two seats and the “Swap Seats” button to make the swap.
        private void SwapSeat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 2)
            {
                DataGridViewCell dc1 = dataGridView1.SelectedCells[0];
                DataGridViewCell dc2 = dataGridView1.SelectedCells[1];

                if (dc1.Style.BackColor != Color.LightBlue || dc2.Style.BackColor != Color.LightBlue)
                {
                    MessageBox.Show("Swapping required you to have assigned people to the seat!");
                    return;
                }
                else
                {
                    var ID1 = dc1.Value.ToString().Substring(1, 3).Trim();
                    var ID1f = dc1.Value.ToString().Substring(1, 4).Trim();
                    var ID2 = dc2.Value.ToString().Substring(1, 3).Trim();
                    var ID2f = dc2.Value.ToString().Substring(1, 4).Trim();

                    using (var db = new Session5Entities())
                    {
                        if (dc1.RowIndex - 1 < 0)
                        {
                            if (dataGridView1.Rows[dc1.RowIndex + 1].Cells[dc1.ColumnIndex].Value.ToString().Contains(ID2))
                            {
                                MessageBox.Show("Competitor with the same country cannot be placed together!");
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                if (dataGridView1.Rows[dc1.RowIndex + 1].Cells[dc1.ColumnIndex].Value.ToString().Contains(ID2))
                                {
                                    MessageBox.Show("Competitor with the same country cannot be placed together!");
                                    return;
                                }
                            }
                            catch
                            {

                            }
                            if (dataGridView1.Rows[dc1.RowIndex - 1].Cells[dc1.ColumnIndex].Value.ToString().Contains(ID2))
                            {
                                MessageBox.Show("Competitor with the same country cannot be placed together!");
                                return;
                            }
                        }

                        if (dc2.RowIndex - 1 < 0)
                        {
                            if (dataGridView1.Rows[dc2.RowIndex + 1].Cells[dc2.ColumnIndex].Value.ToString().Contains(ID1))
                            {
                                MessageBox.Show("Competitor with the same country cannot be placed together!");
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                if (dataGridView1.Rows[dc2.RowIndex + 1].Cells[dc2.ColumnIndex].Value.ToString().Contains(ID1))
                                {
                                    MessageBox.Show("Competitor with the same country cannot be placed together!");
                                    return;
                                }
                            }
                            catch
                            {

                            }
                            if (dataGridView1.Rows[dc2.RowIndex - 1].Cells[dc2.ColumnIndex].Value.ToString().Contains(ID1))
                            {
                                MessageBox.Show("Competitor with the same country cannot be placed together!");
                                return;
                            }
                        }


                        dc1.Value = dc1.Value.ToString().Substring(0, 1);
                        dc2.Value = dc2.Value.ToString().Substring(0, 1);

                        dc1.Value = dc1.Value + "\n" + ID2f;
                        dc2.Value = dc2.Value + "\n" + ID1f;
                        dc1.Style.BackColor = Color.LightBlue;
                        dc2.Style.BackColor = Color.LightBlue;
                        dc1.Style.WrapMode = DataGridViewTriState.True;
                        dc2.Style.WrapMode = DataGridViewTriState.True;


                        var skillsID = comboBox1.SelectedIndex + 1;
                        var q1 = db.Competitors.Where(x => x.competitorId == ID2f && x.skillIdFK == skillsID).FirstOrDefault();
                        dc1.ToolTipText = "Name: " + q1.competitorName + "\n" + "Country: " + q1.competitorCountry;
                        var q2 = db.Competitors.Where(x => x.competitorId == ID1f && x.skillIdFK == skillsID).FirstOrDefault();
                        dc2.ToolTipText = "Name: " + q2.competitorName + "\n" + "Country: " + q2.competitorCountry;
                    }
                }
            }
            else
            {
                MessageBox.Show("Swapping requires you to select 2 seats!");
                return;
            }

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            var skill = comboBox1.SelectedIndex + 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell dc in row.Cells)
                {
                    if (string.IsNullOrEmpty(dc.Value.ToString()) == false)
                    {
                        var seatNo = dc.Value.ToString().Substring(0, 1);
                        var ID = dc.Value.ToString().Substring(1).Trim();
                        using (var db = new Session5Entities())
                        {
                            var q = db.Competitors.Where(x => x.skillIdFK == skill && x.competitorId == ID).FirstOrDefault();
                            try
                            {
                                q.assignedSeat = int.Parse(seatNo);
                                try
                                {
                                    db.SaveChanges();
                                    MessageBox.Show("Success!");
                                }
                                catch (Exception es)
                                {
                                    MessageBox.Show(es.ToString());
                                }
                            }
                            catch
                            {
                                continue;
                            }

                        }
                    }
                }
            }
        }
    }
}
