namespace Session2
{
    partial class SponderManagerMainMenu
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
            this.VSPBtn = new System.Windows.Forms.Button();
            this.ASPBtn = new System.Windows.Forms.Button();
            this.ASBBtn = new System.Windows.Forms.Button();
            this.VSSBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 84);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(243, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sponsorship Manager Main Menu";
            // 
            // VSPBtn
            // 
            this.VSPBtn.Location = new System.Drawing.Point(228, 196);
            this.VSPBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VSPBtn.Name = "VSPBtn";
            this.VSPBtn.Size = new System.Drawing.Size(176, 62);
            this.VSPBtn.TabIndex = 5;
            this.VSPBtn.Text = "View Sponsorship Packages";
            this.VSPBtn.UseVisualStyleBackColor = true;
            this.VSPBtn.Click += new System.EventHandler(this.VSPBtn_Click);
            // 
            // ASPBtn
            // 
            this.ASPBtn.Location = new System.Drawing.Point(470, 196);
            this.ASPBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ASPBtn.Name = "ASPBtn";
            this.ASPBtn.Size = new System.Drawing.Size(178, 62);
            this.ASPBtn.TabIndex = 6;
            this.ASPBtn.Text = "Add Sponsorship Packages";
            this.ASPBtn.UseVisualStyleBackColor = true;
            this.ASPBtn.Click += new System.EventHandler(this.ASPBtn_Click);
            // 
            // ASBBtn
            // 
            this.ASBBtn.Location = new System.Drawing.Point(228, 300);
            this.ASBBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ASBBtn.Name = "ASBBtn";
            this.ASBBtn.Size = new System.Drawing.Size(176, 69);
            this.ASBBtn.TabIndex = 7;
            this.ASBBtn.Text = "Approve Sponsorship Bookings";
            this.ASBBtn.UseVisualStyleBackColor = true;
            this.ASBBtn.Click += new System.EventHandler(this.ASBBtn_Click);
            // 
            // VSSBtn
            // 
            this.VSSBtn.Location = new System.Drawing.Point(470, 300);
            this.VSSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VSSBtn.Name = "VSSBtn";
            this.VSSBtn.Size = new System.Drawing.Size(178, 69);
            this.VSSBtn.TabIndex = 8;
            this.VSSBtn.Text = "View Sponsorship Summary";
            this.VSSBtn.UseVisualStyleBackColor = true;
            this.VSSBtn.Click += new System.EventHandler(this.VSSBtn_Click);
            // 
            // SponderManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.VSSBtn);
            this.Controls.Add(this.ASBBtn);
            this.Controls.Add(this.ASPBtn);
            this.Controls.Add(this.VSPBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SponderManagerMainMenu";
            this.Text = "SponderManagerMainMenu";
            this.Load += new System.EventHandler(this.SponderManagerMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VSPBtn;
        private System.Windows.Forms.Button ASPBtn;
        private System.Windows.Forms.Button ASBBtn;
        private System.Windows.Forms.Button VSSBtn;
    }
}