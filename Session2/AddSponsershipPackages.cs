using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class AddSponsershipPackages : Form
    {
        User users;
        public AddSponsershipPackages(User user)
        {
            InitializeComponent();
            users = user;
        }

        private void AddSponsershipPackages_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //The package tier can be Gold, Silver or Bronze only,
                //and users can choose this from a drop‐down list.
                var q = db.Packages.Select(x => x.packageTier).Distinct().OrderBy(x => x == "Bronze" ? 1 : x == "Silver" ? 2 : 3).ToList();
                foreach (var item in q)
                {
                    tier.Items.Add(item);
                }
                tier.SelectedItem = 0;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponderManagerMainMenu sponderManagerMainMenu = new SponderManagerMainMenu(users);
            sponderManagerMainMenu.Show();
        }

        private void tier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tier.Text == "Gold")
            {
                online.Checked = true;
                Flyers.Checked = true;
                Banner.Checked = true;
            }
            else
            {
                online.Checked = false;
                Flyers.Checked = false;
                Banner.Checked = false;
            }
        }

        private void APBtn_Click(object sender, EventArgs e)
        {
            var tiers = tier.Text;
            using (var db = new Session2Entities())
            {
                //Users cannot add a more than one package with the same name
                var q = db.Packages.Where(x => x.packageName == name.Text.Trim()).FirstOrDefault();
                if (q != null)
                {
                    MessageBox.Show("Invalid Package Name!");
                    return;
                }
                Package package = new Package();
                package.packageTier = tiers;
                package.packageName = name.Text;

                //Gold packages must be more than or equal to 
                //$50,000 in value
                if (tiers == "Gold")
                {
                    if (int.Parse(val.Text) >= 50000)
                    {
                        package.packageValue = long.Parse(val.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Package Value! Value must be more then or equals to 50K!");
                        return;
                    }
                }

                //Silver packages can be between $10,000 to $50,000 in value
                else if (tiers == "Silver")
                {
                    if (int.Parse(val.Text) > 10000 && int.Parse(val.Text) < 50000)
                    {
                        package.packageValue = long.Parse(val.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Package Value! Value must be between 10K and 50K!");
                        return;
                    }
                }

                //Bronze packages must be less than or equal to
                //$10,000 in value
                else if (tiers == "Bronze")
                {
                    if (int.Parse(val.Text.ToString()) <= 10000)
                    {
                        package.packageValue = long.Parse(val.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Invalid Package Value! Value must be less then or equals to 10K!");
                        return;
                    }
                }

                //The starting quantity of available packages must be 
                //greater than zero.
                if (quantity.Value == 0)
                {
                    MessageBox.Show("Quantity must be more than 0!");
                    return;
                }
                else
                {
                    package.packageQuantity = (int)quantity.Value;
                }
                try
                {
                    db.Packages.Add(package);
                    db.SaveChanges();

                    //Gold packages must include all three benefits.
                    if (tiers == "Gold")
                    {
                        Benefit benefit = new Benefit();
                        benefit.packageIdFK = package.packageId;
                        benefit.benefitName = "Online";
                        db.Benefits.Add(benefit);

                        Benefit benefit2 = new Benefit();
                        benefit2.packageIdFK = package.packageId;
                        benefit2.benefitName = "Flyer";
                        db.Benefits.Add(benefit2);

                        Benefit benefit3 = new Benefit();
                        benefit3.packageIdFK = package.packageId;
                        benefit3.benefitName = "Banner";
                        db.Benefits.Add(benefit3);
                    }

                    //Silver packages must have two benefits, but the
                    //user can pick any combination of the benefits.
                    else if (tiers == "Silver")
                    {
                        var count = 0;
                        var on = 0;
                        var fly = 0;
                        var ban = 0;
                        if (online.Checked)
                        {
                            count += 1;
                            on = 1;
                        }
                        if (Flyers.Checked)
                        {
                            count += 1;
                            fly = 1;
                        }
                        if (Banner.Checked)
                        {
                            count += 1;
                            ban = 1;
                        }

                        if (count == 2)
                        {
                            if (on == 1)
                            {
                                Benefit benefit = new Benefit();
                                benefit.packageIdFK = package.packageId;
                                benefit.benefitName = "Online";
                                db.Benefits.Add(benefit);
                            }
                            if (fly == 1)
                            {
                                Benefit benefit2 = new Benefit();
                                benefit2.packageIdFK = package.packageId;
                                benefit2.benefitName = "Flyer";
                                db.Benefits.Add(benefit2);
                            }
                            if (ban == 1)
                            {
                                Benefit benefit3 = new Benefit();
                                benefit3.packageIdFK = package.packageId;
                                benefit3.benefitName = "Banner";
                                db.Benefits.Add(benefit3);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Benefits! Silve can only have 2 benefits!");
                            db.Packages.Remove(package);
                            db.SaveChanges();
                            return;
                        }
                    }

                    //Bronze packages only have one benefit,
                    //but the user can pick any of the benefits.
                    else if (tiers == "Bronze")
                    {
                        var count = 0;
                        if (online.Checked)
                        {
                            count += 1;
                        }
                        if (Flyers.Checked)
                        {
                            count += 1;
                        }
                        if (Banner.Checked)
                        {
                            count += 1;
                        }
                        if (count == 1)
                        {
                            if (online.Checked)
                            {
                                Benefit benefit = new Benefit();
                                benefit.packageIdFK = package.packageId;
                                benefit.benefitName = "Online";
                                db.Benefits.Add(benefit);
                            }
                            else if (Flyers.Checked)
                            {
                                Benefit benefit2 = new Benefit();
                                benefit2.packageIdFK = package.packageId;
                                benefit2.benefitName = "Flyer";
                                db.Benefits.Add(benefit2);
                            }
                            else if (Banner.Checked)
                            {
                                Benefit benefit3 = new Benefit();
                                benefit3.packageIdFK = package.packageId;
                                benefit3.benefitName = "Banner";
                                db.Benefits.Add(benefit3);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Benefits! Bronze must have only 1 benefit");
                            db.Packages.Remove(package);
                            db.SaveChanges();
                            return;
                        }

                    }
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }

                    MessageBox.Show("Success!");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }


            }
        }

        private void CFBtn_Click(object sender, EventArgs e)
        {
            tier.Text = null;
            name.Text = null;
            val.Text = null;
            quantity.Value = 0;
            online.Checked = false;
            Flyers.Checked = false;
            Banner.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                path.Text = dialog.FileName; // get name of file
                try
                {
                    using (var db = new Session2Entities())
                    {
                        string[] Lines = File.ReadAllLines(dialog.FileName);
                        string[] Fields = Lines[0].Split(new char[] { ',' });
                        //The system should then append the
                        //information from this CSV file to the 
                        //database
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ',' });
                            Package package = new Package();
                            package.packageTier = Fields[0];
                            package.packageName = Fields[1];
                            package.packageValue = long.Parse(Fields[2]);
                            package.packageQuantity = int.Parse(Fields[3]);

                            db.Packages.Add(package);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Successfully added to DB!");
                    }

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
        }
    }
}
