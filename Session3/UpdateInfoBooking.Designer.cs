namespace Session3
{
    partial class UpdateInfoBooking
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalVal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HOD = new System.Windows.Forms.NumericUpDown();
            this.Dels = new System.Windows.Forms.TextBox();
            this.Comps = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LiveTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 102);
            this.panel1.TabIndex = 7;
            // 
            // Back
            // 
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Location = new System.Drawing.Point(22, 30);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(110, 55);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(626, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "ASEAN Skills 2020";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(309, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Update Info / Booking";
            // 
            // totalVal
            // 
            this.totalVal.AutoSize = true;
            this.totalVal.Location = new System.Drawing.Point(758, 500);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(51, 20);
            this.totalVal.TabIndex = 10;
            this.totalVal.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOTAL ($):";
            // 
            // HOD
            // 
            this.HOD.Location = new System.Drawing.Point(359, 189);
            this.HOD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HOD.Name = "HOD";
            this.HOD.Size = new System.Drawing.Size(112, 26);
            this.HOD.TabIndex = 37;
            this.HOD.ValueChanged += new System.EventHandler(this.HOD_ValueChanged);
            // 
            // Dels
            // 
            this.Dels.Location = new System.Drawing.Point(359, 224);
            this.Dels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dels.Name = "Dels";
            this.Dels.Size = new System.Drawing.Size(112, 26);
            this.Dels.TabIndex = 36;
            // 
            // Comps
            // 
            this.Comps.Location = new System.Drawing.Point(359, 259);
            this.Comps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Comps.Name = "Comps";
            this.Comps.Size = new System.Drawing.Size(112, 26);
            this.Comps.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Head of Delegation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(478, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Competitors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "No of Pax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Delegates (excluding head)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(834, 181);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // update
            // 
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(754, 539);
            this.update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 55);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LiveTime);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(1, 632);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 102);
            this.panel2.TabIndex = 39;
            // 
            // LiveTime
            // 
            this.LiveTime.AutoSize = true;
            this.LiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LiveTime.ForeColor = System.Drawing.SystemColors.Control;
            this.LiveTime.Location = new System.Drawing.Point(627, 25);
            this.LiveTime.Name = "LiveTime";
            this.LiveTime.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LiveTime.Size = new System.Drawing.Size(191, 25);
            this.LiveTime.TabIndex = 1;
            this.LiveTime.Text = "ASEAN Skills 2020";
            this.LiveTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateInfoBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HOD);
            this.Controls.Add(this.Dels);
            this.Controls.Add(this.Comps);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateInfoBooking";
            this.Text = "UpdateInfoBooking";
            this.Load += new System.EventHandler(this.UpdateInfoBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HOD;
        private System.Windows.Forms.TextBox Dels;
        private System.Windows.Forms.TextBox Comps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LiveTime;
        private System.Windows.Forms.Timer timer1;
    }
}