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
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign_Seating assign_Seating = new Assign_Seating();
            assign_Seating.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterMarks enterMarks = new EnterMarks();
            enterMarks.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewResults viewResults = new ViewResults();
            viewResults.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analyze_Results analyze_Results = new Analyze_Results();
            analyze_Results.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculateBonus calculateBonus = new CalculateBonus();
            calculateBonus.Show();
        }
    }
}
