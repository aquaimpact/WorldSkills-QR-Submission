namespace Session2
{
    partial class AddSponsershipPackages
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tier = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.online = new System.Windows.Forms.CheckBox();
            this.Flyers = new System.Windows.Forms.CheckBox();
            this.Banner = new System.Windows.Forms.CheckBox();
            this.CFBtn = new System.Windows.Forms.Button();
            this.APBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.val = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 84);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(237, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Sponsorship Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "File Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filter By Benefit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Availabile Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Package Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tier:";
            // 
            // tier
            // 
            this.tier.FormattingEnabled = true;
            this.tier.Location = new System.Drawing.Point(258, 146);
            this.tier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(272, 28);
            this.tier.TabIndex = 15;
            this.tier.SelectedIndexChanged += new System.EventHandler(this.tier_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(258, 182);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(272, 26);
            this.name.TabIndex = 16;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(202, 469);
            this.path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(272, 26);
            this.path.TabIndex = 19;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(258, 298);
            this.online.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(80, 24);
            this.online.TabIndex = 20;
            this.online.Text = "Online";
            this.online.UseVisualStyleBackColor = true;
            // 
            // Flyers
            // 
            this.Flyers.AutoSize = true;
            this.Flyers.Location = new System.Drawing.Point(375, 298);
            this.Flyers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Flyers.Name = "Flyers";
            this.Flyers.Size = new System.Drawing.Size(77, 24);
            this.Flyers.TabIndex = 21;
            this.Flyers.Text = "Flyers";
            this.Flyers.UseVisualStyleBackColor = true;
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Location = new System.Drawing.Point(493, 298);
            this.Banner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(87, 24);
            this.Banner.TabIndex = 22;
            this.Banner.Text = "Banner";
            this.Banner.UseVisualStyleBackColor = true;
            // 
            // CFBtn
            // 
            this.CFBtn.Location = new System.Drawing.Point(202, 368);
            this.CFBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CFBtn.Name = "CFBtn";
            this.CFBtn.Size = new System.Drawing.Size(145, 44);
            this.CFBtn.TabIndex = 23;
            this.CFBtn.Text = "ClearFormBtn";
            this.CFBtn.UseVisualStyleBackColor = true;
            this.CFBtn.Click += new System.EventHandler(this.CFBtn_Click);
            // 
            // APBtn
            // 
            this.APBtn.Location = new System.Drawing.Point(390, 368);
            this.APBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.APBtn.Name = "APBtn";
            this.APBtn.Size = new System.Drawing.Size(140, 44);
            this.APBtn.TabIndex = 24;
            this.APBtn.Text = "Add Packages";
            this.APBtn.UseVisualStyleBackColor = true;
            this.APBtn.Click += new System.EventHandler(this.APBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 465);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 25;
            this.button3.Text = "Upload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(258, 254);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(272, 26);
            this.quantity.TabIndex = 27;
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(257, 215);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(273, 26);
            this.val.TabIndex = 28;
            // 
            // AddSponsershipPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.val);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.APBtn);
            this.Controls.Add(this.CFBtn);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Flyers);
            this.Controls.Add(this.online);
            this.Controls.Add(this.path);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSponsershipPackages";
            this.Text = "AddSponsershipPackages";
            this.Load += new System.EventHandler(this.AddSponsershipPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tier;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.CheckBox online;
        private System.Windows.Forms.CheckBox Flyers;
        private System.Windows.Forms.CheckBox Banner;
        private System.Windows.Forms.Button CFBtn;
        private System.Windows.Forms.Button APBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.TextBox val;
    }
}