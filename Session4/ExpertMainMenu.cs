using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class ExpertMainMenu : Form
    {
        User users;
        public ExpertMainMenu(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateExpertTrainingRecords updateExpertTrainingRecords = new UpdateExpertTrainingRecords(users);
            updateExpertTrainingRecords.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackCompetitorTrainingProgress trackCompetitorTrainingProgress = new TrackCompetitorTrainingProgress(users);
            trackCompetitorTrainingProgress.Show();
        }
    }
}
