namespace Session5
{
    partial class Assign_Seating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnassignedNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AssignedNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RandomAssign = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.SwapSeat = new System.Windows.Forms.Button();
            this.ManualAssign = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 91);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(606, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(489, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 164);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(385, 300);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(344, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Assign Seating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Skill:";
            // 
            // UnassignedNumber
            // 
            this.UnassignedNumber.AutoSize = true;
            this.UnassignedNumber.Location = new System.Drawing.Point(695, 217);
            this.UnassignedNumber.Name = "UnassignedNumber";
            this.UnassignedNumber.Size = new System.Drawing.Size(51, 20);
            this.UnassignedNumber.TabIndex = 11;
            this.UnassignedNumber.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unassigned Competitors:";
            // 
            // AssignedNumber
            // 
            this.AssignedNumber.AutoSize = true;
            this.AssignedNumber.Location = new System.Drawing.Point(324, 217);
            this.AssignedNumber.Name = "AssignedNumber";
            this.AssignedNumber.Size = new System.Drawing.Size(18, 20);
            this.AssignedNumber.TabIndex = 13;
            this.AssignedNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Assigned Competitors:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RandomAssign
            // 
            this.RandomAssign.Location = new System.Drawing.Point(489, 438);
            this.RandomAssign.Name = "RandomAssign";
            this.RandomAssign.Size = new System.Drawing.Size(149, 53);
            this.RandomAssign.TabIndex = 16;
            this.RandomAssign.Text = "Randomly Assign";
            this.RandomAssign.UseVisualStyleBackColor = true;
            this.RandomAssign.Click += new System.EventHandler(this.RandomAssign_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(678, 497);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(146, 53);
            this.Confirm.TabIndex = 17;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // SwapSeat
            // 
            this.SwapSeat.Location = new System.Drawing.Point(489, 497);
            this.SwapSeat.Name = "SwapSeat";
            this.SwapSeat.Size = new System.Drawing.Size(149, 53);
            this.SwapSeat.TabIndex = 18;
            this.SwapSeat.Text = "Swap Seats";
            this.SwapSeat.UseVisualStyleBackColor = true;
            this.SwapSeat.Click += new System.EventHandler(this.SwapSeat_Click);
            // 
            // ManualAssign
            // 
            this.ManualAssign.Location = new System.Drawing.Point(678, 438);
            this.ManualAssign.Name = "ManualAssign";
            this.ManualAssign.Size = new System.Drawing.Size(146, 53);
            this.ManualAssign.TabIndex = 19;
            this.ManualAssign.Text = "Manually Assign";
            this.ManualAssign.UseVisualStyleBackColor = true;
            this.ManualAssign.Click += new System.EventHandler(this.ManualAssign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Unassigned";
            // 
            // Assign_Seating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManualAssign);
            this.Controls.Add(this.SwapSeat);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.RandomAssign);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AssignedNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnassignedNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Assign_Seating";
            this.Text = "Assign_Seating";
            this.Load += new System.EventHandler(this.Assign_Seating_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UnassignedNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AssignedNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RandomAssign;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button SwapSeat;
        private System.Windows.Forms.Button ManualAssign;
        private System.Windows.Forms.Label label4;
    }
}