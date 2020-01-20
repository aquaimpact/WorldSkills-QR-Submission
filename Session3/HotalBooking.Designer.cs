namespace Session3
{
    partial class HotalBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberC = new System.Windows.Forms.Label();
            this.numberD = new System.Windows.Forms.Label();
            this.HotalName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LiveTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(2, 1);
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
            this.label1.Location = new System.Drawing.Point(359, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hotel Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Competitors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Delegates (excluding head)";
            // 
            // NumberC
            // 
            this.NumberC.AutoSize = true;
            this.NumberC.Location = new System.Drawing.Point(344, 238);
            this.NumberC.Name = "NumberC";
            this.NumberC.Size = new System.Drawing.Size(51, 20);
            this.NumberC.TabIndex = 11;
            this.NumberC.Text = "label4";
            // 
            // numberD
            // 
            this.numberD.AutoSize = true;
            this.numberD.Location = new System.Drawing.Point(344, 201);
            this.numberD.Name = "numberD";
            this.numberD.Size = new System.Drawing.Size(51, 20);
            this.numberD.TabIndex = 12;
            this.numberD.Text = "label5";
            // 
            // HotalName
            // 
            this.HotalName.AutoSize = true;
            this.HotalName.Location = new System.Drawing.Point(344, 166);
            this.HotalName.Name = "HotalName";
            this.HotalName.Size = new System.Drawing.Size(49, 20);
            this.HotalName.TabIndex = 13;
            this.HotalName.Text = "name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "No of Pax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hotel Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 180);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(728, 469);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(60, 20);
            this.total.TabIndex = 17;
            this.total.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(631, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "TOTAL ($):";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(651, 508);
            this.book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(137, 40);
            this.book.TabIndex = 19;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LiveTime);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(2, 575);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 102);
            this.panel2.TabIndex = 20;
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
            // HotalBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HotalName);
            this.Controls.Add(this.numberD);
            this.Controls.Add(this.NumberC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotalBooking";
            this.Text = "HotalBooking";
            this.Load += new System.EventHandler(this.HotalBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberC;
        private System.Windows.Forms.Label numberD;
        private System.Windows.Forms.Label HotalName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LiveTime;
        private System.Windows.Forms.Timer timer1;
    }
}