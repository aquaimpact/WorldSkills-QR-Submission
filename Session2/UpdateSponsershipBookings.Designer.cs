namespace Session2
{
    partial class UpdateSponsershipBookings
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UQBtn = new System.Windows.Forms.Button();
            this.NQ = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(628, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 84);
            this.panel1.TabIndex = 5;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(14, 14);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 55);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(254, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Update Sponsorship Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 212);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL ($):";
            // 
            // TotalVal
            // 
            this.TotalVal.AutoSize = true;
            this.TotalVal.Location = new System.Drawing.Point(719, 418);
            this.TotalVal.Name = "TotalVal";
            this.TotalVal.Size = new System.Drawing.Size(89, 20);
            this.TotalVal.TabIndex = 9;
            this.TotalVal.Text = "Total Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "New Quantity:";
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(765, 505);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(84, 42);
            this.DelBtn.TabIndex = 12;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UQBtn
            // 
            this.UQBtn.Location = new System.Drawing.Point(765, 454);
            this.UQBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UQBtn.Name = "UQBtn";
            this.UQBtn.Size = new System.Drawing.Size(84, 40);
            this.UQBtn.TabIndex = 13;
            this.UQBtn.Text = "Update Quantity";
            this.UQBtn.UseVisualStyleBackColor = true;
            this.UQBtn.Click += new System.EventHandler(this.UQBtn_Click);
            // 
            // NQ
            // 
            this.NQ.Location = new System.Drawing.Point(568, 466);
            this.NQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(190, 26);
            this.NQ.TabIndex = 14;
            this.NQ.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // UpdateSponsershipBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.UQBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateSponsershipBookings";
            this.Text = "UpdateSponsershipBookings";
            this.Load += new System.EventHandler(this.UpdateSponsershipBookings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button UQBtn;
        private System.Windows.Forms.NumericUpDown NQ;
    }
}