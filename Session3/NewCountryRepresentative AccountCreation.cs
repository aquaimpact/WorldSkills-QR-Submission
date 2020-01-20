using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class NewCountryRepresentative_AccountCreation : Form
    {
        public NewCountryRepresentative_AccountCreation()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCountryRepresentative_AccountCreation_Load(object sender, EventArgs e)
        {
            timer1.Start();
            using (var db = new Session3Entities())
            {
                List<String> Countrys = new List<string>();
                Countrys.Add("Brunei");
                Countrys.Add("Cambodia");
                Countrys.Add("Indonesia");
                Countrys.Add("Laos");
                Countrys.Add("Malaysia");
                Countrys.Add("Myanmar");
                Countrys.Add("Philippines");
                Countrys.Add("Singapore");
                Countrys.Add("Thailand");
                Countrys.Add("Vietnam");

                foreach (var item in Countrys)
                {
                    //So, the drop‐down list should only show
                    //the countries with no country rep account.
                    var q = db.Users.Where(x => x.countryName == item && x.userTypeIdFK == 2).FirstOrDefault();
                    if (q == null)
                    {
                        Country.Items.Add(item);
                    }
                    else
                    {
                        continue;
                    }

                }
                Country.SelectedIndex = 0;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Session3Entities())
            {
                User user = new User();
                var val = UserId.Text;
                //The user ID should consist of a minimum of 8 characters.
                if (val.Length < 8)
                {
                    MessageBox.Show("Invalid User ID! User ID should consist of a minimum of 8 characters");
                    return;
                }
                else
                {
                    var q = db.Users.Where(x => x.userId == val).FirstOrDefault();
                    if (q == null)
                    {
                        if (val.Any(char.IsSymbol))
                        {
                            MessageBox.Show("The ID should only include Upper case letters, Lower case letters and numbers 0 – 9.");
                            return;
                        }
                        else
                        {
                            user.userId = val;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User ID Taken!");
                        return;
                    }

                }
                var val2 = Country.Text;
                user.countryName = val2;
                if (Pass.Text != PassC.Text)
                {
                    MessageBox.Show("Password Not match!");
                    return;
                }
                else
                {
                    user.passwd = Pass.Text;
                }
                user.userTypeIdFK = 2;

                db.Users.Add(user);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success!");
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString();
        }
    }
}
