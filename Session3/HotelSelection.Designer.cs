namespace Session3
{
    partial class HotelSelection
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
            this.RC = new System.Windows.Forms.RadioButton();
            this.PanPac = new System.Windows.Forms.RadioButton();
            this.CharH = new System.Windows.Forms.RadioButton();
            this.HotelRQ = new System.Windows.Forms.RadioButton();
            this.HGP = new System.Windows.Forms.RadioButton();
            this.interCon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LiveTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 102);
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
            this.label7.Location = new System.Drawing.Point(640, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "ASEAN Skills 2020";
            // 
            // RC
            // 
            this.RC.AutoSize = true;
            this.RC.Location = new System.Drawing.Point(773, 736);
            this.RC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(118, 24);
            this.RC.TabIndex = 5;
            this.RC.TabStop = true;
            this.RC.Text = "Ritz-Carlton";
            this.RC.UseVisualStyleBackColor = true;
            this.RC.CheckedChanged += new System.EventHandler(this.RC_CheckedChanged);
            this.RC.Click += new System.EventHandler(this.RC_Click);
            // 
            // PanPac
            // 
            this.PanPac.AutoSize = true;
            this.PanPac.Location = new System.Drawing.Point(648, 626);
            this.PanPac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanPac.Name = "PanPac";
            this.PanPac.Size = new System.Drawing.Size(154, 24);
            this.PanPac.TabIndex = 4;
            this.PanPac.TabStop = true;
            this.PanPac.Text = "Pan Pacific Hotel";
            this.PanPac.UseVisualStyleBackColor = true;
            this.PanPac.Click += new System.EventHandler(this.PanPac_Click);
            // 
            // CharH
            // 
            this.CharH.AutoSize = true;
            this.CharH.Location = new System.Drawing.Point(217, 412);
            this.CharH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CharH.Name = "CharH";
            this.CharH.Size = new System.Drawing.Size(136, 24);
            this.CharH.TabIndex = 3;
            this.CharH.TabStop = true;
            this.CharH.Text = "Charlton Hotel";
            this.CharH.UseVisualStyleBackColor = true;
            this.CharH.Click += new System.EventHandler(this.CharH_Click);
            // 
            // HotelRQ
            // 
            this.HotelRQ.AutoSize = true;
            this.HotelRQ.Location = new System.Drawing.Point(134, 240);
            this.HotelRQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HotelRQ.Name = "HotelRQ";
            this.HotelRQ.Size = new System.Drawing.Size(176, 24);
            this.HotelRQ.TabIndex = 2;
            this.HotelRQ.TabStop = true;
            this.HotelRQ.Text = "Hotel Royal Queens";
            this.HotelRQ.UseVisualStyleBackColor = true;
            this.HotelRQ.Click += new System.EventHandler(this.HotelRQ_Click);
            // 
            // HGP
            // 
            this.HGP.AutoSize = true;
            this.HGP.Location = new System.Drawing.Point(217, 276);
            this.HGP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HGP.Name = "HGP";
            this.HGP.Size = new System.Drawing.Size(171, 24);
            this.HGP.TabIndex = 1;
            this.HGP.TabStop = true;
            this.HGP.Text = "Hotel Grand Pacific";
            this.HGP.UseVisualStyleBackColor = true;
            this.HGP.Click += new System.EventHandler(this.HGP_Click);
            // 
            // interCon
            // 
            this.interCon.AutoSize = true;
            this.interCon.Location = new System.Drawing.Point(360, 220);
            this.interCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interCon.Name = "interCon";
            this.interCon.Size = new System.Drawing.Size(222, 24);
            this.interCon.TabIndex = 0;
            this.interCon.TabStop = true;
            this.interCon.Text = "Intercontinental Singapore";
            this.interCon.UseVisualStyleBackColor = true;
            this.interCon.CheckedChanged += new System.EventHandler(this.interCon_CheckedChanged);
            this.interCon.Click += new System.EventHandler(this.interCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(377, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hotel Selection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session3.Properties.Resources.Hotel_Map_Marking;
            this.pictureBox1.Location = new System.Drawing.Point(54, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LiveTime);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(-5, 906);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 102);
            this.panel2.TabIndex = 11;
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
            // HotelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 966);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.PanPac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CharH);
            this.Controls.Add(this.interCon);
            this.Controls.Add(this.HotelRQ);
            this.Controls.Add(this.HGP);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotelSelection";
            this.Text = "HotelSelection";
            this.Load += new System.EventHandler(this.HotelSelection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RadioButton RC;
        private System.Windows.Forms.RadioButton PanPac;
        private System.Windows.Forms.RadioButton CharH;
        private System.Windows.Forms.RadioButton HotelRQ;
        private System.Windows.Forms.RadioButton HGP;
        private System.Windows.Forms.RadioButton interCon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LiveTime;
        private System.Windows.Forms.Timer timer1;
    }
}