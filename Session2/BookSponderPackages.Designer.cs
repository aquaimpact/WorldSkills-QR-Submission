namespace Session2
{
    partial class BookSponderPackages
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
            this.p = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tier = new System.Windows.Forms.ComboBox();
            this.online = new System.Windows.Forms.CheckBox();
            this.Flyers = new System.Windows.Forms.CheckBox();
            this.Banner = new System.Windows.Forms.CheckBox();
            this.BookBtn = new System.Windows.Forms.Button();
            this.DQ = new System.Windows.Forms.NumericUpDown();
            this.budget = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQ)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 84);
            this.panel1.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(246, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Sponsorship Packages";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(14, 515);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(131, 20);
            this.p.TabIndex = 6;
            this.p.Text = "Desired Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter By Benefit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Filter by Budget:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Filter By Tier:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 224);
            this.dataGridView1.TabIndex = 10;
            // 
            // tier
            // 
            this.tier.FormattingEnabled = true;
            this.tier.Location = new System.Drawing.Point(328, 154);
            this.tier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(270, 28);
            this.tier.TabIndex = 12;
            this.tier.SelectedIndexChanged += new System.EventHandler(this.tier_SelectedIndexChanged);
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(328, 229);
            this.online.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(80, 24);
            this.online.TabIndex = 13;
            this.online.Text = "Online";
            this.online.UseVisualStyleBackColor = true;
            this.online.CheckedChanged += new System.EventHandler(this.online_CheckedChanged);
            // 
            // Flyers
            // 
            this.Flyers.AutoSize = true;
            this.Flyers.Location = new System.Drawing.Point(446, 229);
            this.Flyers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Flyers.Name = "Flyers";
            this.Flyers.Size = new System.Drawing.Size(77, 24);
            this.Flyers.TabIndex = 14;
            this.Flyers.Text = "Flyers";
            this.Flyers.UseVisualStyleBackColor = true;
            this.Flyers.CheckedChanged += new System.EventHandler(this.Flyers_CheckedChanged);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Location = new System.Drawing.Point(562, 230);
            this.Banner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(87, 24);
            this.Banner.TabIndex = 15;
            this.Banner.Text = "Banner";
            this.Banner.UseVisualStyleBackColor = true;
            this.Banner.CheckedChanged += new System.EventHandler(this.Banner_CheckedChanged);
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(770, 508);
            this.BookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(84, 44);
            this.BookBtn.TabIndex = 16;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // DQ
            // 
            this.DQ.Location = new System.Drawing.Point(153, 512);
            this.DQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DQ.Name = "DQ";
            this.DQ.Size = new System.Drawing.Size(169, 26);
            this.DQ.TabIndex = 17;
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(328, 191);
            this.budget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(270, 26);
            this.budget.TabIndex = 11;
            this.budget.TextChanged += new System.EventHandler(this.budget_TextChanged);
            // 
            // BookSponderPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.DQ);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Flyers);
            this.Controls.Add(this.online);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookSponderPackages";
            this.Text = "BookSponderPackages";
            this.Load += new System.EventHandler(this.BookSponderPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tier;
        private System.Windows.Forms.CheckBox online;
        private System.Windows.Forms.CheckBox Flyers;
        private System.Windows.Forms.CheckBox Banner;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.NumericUpDown DQ;
        private System.Windows.Forms.TextBox budget;
    }
}