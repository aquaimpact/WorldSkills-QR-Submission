namespace Session2
{
    partial class SponserMainMenu
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
            this.BSPBtn = new System.Windows.Forms.Button();
            this.USPBtn = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 84);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(255, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sponsor Main Menu";
            // 
            // BSPBtn
            // 
            this.BSPBtn.Location = new System.Drawing.Point(261, 191);
            this.BSPBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BSPBtn.Name = "BSPBtn";
            this.BSPBtn.Size = new System.Drawing.Size(281, 49);
            this.BSPBtn.TabIndex = 4;
            this.BSPBtn.Text = "Book Sponsorship Package";
            this.BSPBtn.UseVisualStyleBackColor = true;
            this.BSPBtn.Click += new System.EventHandler(this.BSPBtn_Click);
            // 
            // USPBtn
            // 
            this.USPBtn.Location = new System.Drawing.Point(261, 272);
            this.USPBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.USPBtn.Name = "USPBtn";
            this.USPBtn.Size = new System.Drawing.Size(281, 55);
            this.USPBtn.TabIndex = 5;
            this.USPBtn.Text = "Update Sponsorship Package";
            this.USPBtn.UseVisualStyleBackColor = true;
            this.USPBtn.Click += new System.EventHandler(this.USPBtn_Click);
            // 
            // SponserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.USPBtn);
            this.Controls.Add(this.BSPBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SponserMainMenu";
            this.Text = "SponserMainMenu";
            this.Load += new System.EventHandler(this.SponserMainMenu_Load);
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
        private System.Windows.Forms.Button BSPBtn;
        private System.Windows.Forms.Button USPBtn;
    }
}