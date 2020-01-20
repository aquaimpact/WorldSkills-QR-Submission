namespace Session5
{
    partial class Analyze_Results
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MM = new System.Windows.Forms.Label();
            this.TS = new System.Windows.Forms.Label();
            this.ES = new System.Windows.Forms.Label();
            this.BPC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.skill = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(326, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Analyze Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Easiest Session:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toughest Session:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Median Mark:";
            // 
            // MM
            // 
            this.MM.AutoSize = true;
            this.MM.Location = new System.Drawing.Point(368, 337);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(51, 20);
            this.MM.TabIndex = 11;
            this.MM.Text = "label6";
            // 
            // TS
            // 
            this.TS.AutoSize = true;
            this.TS.Location = new System.Drawing.Point(368, 307);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(51, 20);
            this.TS.TabIndex = 12;
            this.TS.Text = "label7";
            // 
            // ES
            // 
            this.ES.AutoSize = true;
            this.ES.Location = new System.Drawing.Point(368, 274);
            this.ES.Name = "ES";
            this.ES.Size = new System.Drawing.Size(51, 20);
            this.ES.TabIndex = 13;
            this.ES.Text = "label8";
            // 
            // BPC
            // 
            this.BPC.AutoSize = true;
            this.BPC.Location = new System.Drawing.Point(368, 211);
            this.BPC.Name = "BPC";
            this.BPC.Size = new System.Drawing.Size(51, 20);
            this.BPC.TabIndex = 14;
            this.BPC.Text = "label9";
            this.BPC.Click += new System.EventHandler(this.BPC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Best Performing Country:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Skill:";
            // 
            // skill
            // 
            this.skill.FormattingEnabled = true;
            this.skill.Location = new System.Drawing.Point(368, 170);
            this.skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(250, 28);
            this.skill.TabIndex = 17;
            this.skill.SelectedIndexChanged += new System.EventHandler(this.skill_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 384);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(785, 200);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Image = global::Session5.Properties.Resources.updown;
            this.panel3.Location = new System.Drawing.Point(471, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 50);
            this.panel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panel3.TabIndex = 23;
            this.panel3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Image = global::Session5.Properties.Resources.updown___Copy;
            this.panel2.Location = new System.Drawing.Point(438, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 50);
            this.panel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panel2.TabIndex = 22;
            this.panel2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(466, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Analyze_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BPC);
            this.Controls.Add(this.ES);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Analyze_Results";
            this.Text = "Analyze_Results";
            this.Load += new System.EventHandler(this.Analyze_Results_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MM;
        private System.Windows.Forms.Label TS;
        private System.Windows.Forms.Label ES;
        private System.Windows.Forms.Label BPC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox skill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox panel2;
        private System.Windows.Forms.PictureBox panel3;
    }
}