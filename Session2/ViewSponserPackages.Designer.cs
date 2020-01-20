namespace Session2
{
    partial class ViewSponserPackages
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tier = new System.Windows.Forms.RadioButton();
            this.QD = new System.Windows.Forms.RadioButton();
            this.Name = new System.Windows.Forms.RadioButton();
            this.valASC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 6;
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
            this.label2.Location = new System.Drawing.Point(288, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "View Sponsor Packages";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort By:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // tier
            // 
            this.tier.AutoSize = true;
            this.tier.Location = new System.Drawing.Point(128, 151);
            this.tier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(60, 24);
            this.tier.TabIndex = 10;
            this.tier.TabStop = true;
            this.tier.Text = "Tier";
            this.tier.UseVisualStyleBackColor = true;
            this.tier.CheckedChanged += new System.EventHandler(this.tier_CheckedChanged);
            // 
            // QD
            // 
            this.QD.AutoSize = true;
            this.QD.Location = new System.Drawing.Point(294, 209);
            this.QD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QD.Name = "QD";
            this.QD.Size = new System.Drawing.Size(188, 24);
            this.QD.TabIndex = 11;
            this.QD.TabStop = true;
            this.QD.Text = "Quantity (Decreasing)";
            this.QD.UseVisualStyleBackColor = true;
            this.QD.CheckedChanged += new System.EventHandler(this.QD_CheckedChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(196, 151);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(76, 24);
            this.Name.TabIndex = 12;
            this.Name.TabStop = true;
            this.Name.Text = "Name";
            this.Name.UseVisualStyleBackColor = true;
            this.Name.CheckedChanged += new System.EventHandler(this.Name_CheckedChanged);
            // 
            // valASC
            // 
            this.valASC.AutoSize = true;
            this.valASC.Location = new System.Drawing.Point(128, 209);
            this.valASC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valASC.Name = "valASC";
            this.valASC.Size = new System.Drawing.Size(160, 24);
            this.valASC.TabIndex = 13;
            this.valASC.TabStop = true;
            this.valASC.Text = "Value(Ascending)";
            this.valASC.UseVisualStyleBackColor = true;
            this.valASC.CheckedChanged += new System.EventHandler(this.valASC_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewSponserPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valASC);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.QD);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.Name = "ViewSponserPackages";
            this.Text = "ViewSponserPackages";
            this.Load += new System.EventHandler(this.ViewSponserPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton tier;
        private System.Windows.Forms.RadioButton QD;
        private System.Windows.Forms.RadioButton Name;
        private System.Windows.Forms.RadioButton valASC;
        private System.Windows.Forms.Button button1;
    }
}