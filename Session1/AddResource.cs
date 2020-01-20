using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class AddResource : Form
    {
        List<Resource_Allocation> RA = new List<Resource_Allocation>();
        public AddResource()
        {
            InitializeComponent();
        }

        private void AddResource_Load(object sender, EventArgs e)
        {
            using(var db = new Session1Entities())
            {
                var query = db.Resource_Type.ToList();
                foreach(var item in query)
                {
                    type.Items.Add(item.resTypeName);
                }

                var query2 = db.Skills.ToList();
                foreach(var item in query2)
                {
                    skills.Items.Add(item.skillName);
                }
                skills.Visible = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using(var db = new Session1Entities())
            {
                Resource resource = new Resource();
                var query = db.Resources.Where(x => x.resName == name.Text).FirstOrDefault();
                if (query != null)
                {
                    MessageBox.Show("Resource Name is already used!");
                    return;
                }
                else
                {
                    resource.resName = name.Text;
                    resource.resTypeIdFK = type.SelectedIndex + 1;
                    resource.remainingQuantity = (int)quantity.Value;
                    try
                    {
                        db.Resources.Add(resource);
                        if (skills.CheckedItems.Count > 0)
                        {
                            foreach (var item in skills.CheckedItems)
                            {
                                var name = item.ToString();
                                var val = db.Skills.Where(x => x.skillName == name).FirstOrDefault();
                                var ID = resource.resId;
                                Resource_Allocation resource_ = new Resource_Allocation();
                                resource_.resIdFK = ID;
                                resource_.skillIdFK = val.skillId;
                                RA.Add(resource_);
                            }
                            try
                            {
                                if (RA.Count == 0)
                                {
                                    var ID = resource.resId;
                                    Resource_Allocation resource_ = new Resource_Allocation();
                                    resource_.resIdFK = ID;
                                    db.Resource_Allocation.Add(resource_);
                                }
                                foreach (var item in RA)
                                {
                                    db.Resource_Allocation.Add(item);
                                }

                                db.SaveChanges();
                                MessageBox.Show("Created Successfully!");
                                this.Hide();

                            }
                            catch (Exception es)
                            {
                                MessageBox.Show(es.ToString());
                            }
                        }
                        else
                        {
                            var ID = resource.resId;
                            Resource_Allocation resource_ = new Resource_Allocation();
                            resource_.resIdFK = ID;
                            db.Resource_Allocation.Add(resource_);
                            try
                            {
                                db.SaveChanges();
                            }catch(Exception es)
                            {
                                MessageBox.Show(es.ToString());
                            }
                            
                            MessageBox.Show("Created Successfully!");
                            this.Hide();
                        }
                        
                    }
                    catch(Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            if(quantity.Value == 0)
            {
                skills.Visible = false;
            }
            else
            {
                skills.Visible = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResouceManagement resouceManagement = new ResouceManagement();
            resouceManagement.Show();
        }
    }
}
