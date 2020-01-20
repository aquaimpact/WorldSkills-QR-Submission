namespace Session4
{
    partial class UpdateExpertTrainingRecords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SortDate = new System.Windows.Forms.RadioButton();
            this.Sortname = new System.Windows.Forms.RadioButton();
            this.compsname = new System.Windows.Forms.ComboBox();
            this.skill = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 80);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(632, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 480);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 188);
            this.dataGridView1.TabIndex = 29;
            // 
            // SortDate
            // 
            this.SortDate.AutoSize = true;
            this.SortDate.Location = new System.Drawing.Point(388, 221);
            this.SortDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortDate.Name = "SortDate";
            this.SortDate.Size = new System.Drawing.Size(102, 24);
            this.SortDate.TabIndex = 28;
            this.SortDate.TabStop = true;
            this.SortDate.Text = "End Date";
            this.SortDate.UseVisualStyleBackColor = true;
            this.SortDate.CheckedChanged += new System.EventHandler(this.SortDate_CheckedChanged);
            // 
            // Sortname
            // 
            this.Sortname.AutoSize = true;
            this.Sortname.Location = new System.Drawing.Point(307, 221);
            this.Sortname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sortname.Name = "Sortname";
            this.Sortname.Size = new System.Drawing.Size(76, 24);
            this.Sortname.TabIndex = 27;
            this.Sortname.TabStop = true;
            this.Sortname.Text = "Name";
            this.Sortname.UseVisualStyleBackColor = true;
            this.Sortname.CheckedChanged += new System.EventHandler(this.Sortname_CheckedChanged);
            // 
            // compsname
            // 
            this.compsname.FormattingEnabled = true;
            this.compsname.Location = new System.Drawing.Point(307, 184);
            this.compsname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compsname.Name = "compsname";
            this.compsname.Size = new System.Drawing.Size(234, 28);
            this.compsname.TabIndex = 26;
            this.compsname.SelectedIndexChanged += new System.EventHandler(this.compsname_SelectedIndexChanged);
            // 
            // skill
            // 
            this.skill.FormattingEnabled = true;
            this.skill.Location = new System.Drawing.Point(307, 142);
            this.skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(234, 28);
            this.skill.TabIndex = 24;
            this.skill.SelectedIndexChanged += new System.EventHandler(this.skill_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Skill:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Competitor\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sort By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(214, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Update Competitor Training Records";
            // 
            // UpdateExpertTrainingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SortDate);
            this.Controls.Add(this.Sortname);
            this.Controls.Add(this.compsname);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateExpertTrainingRecords";
            this.Text = "UpdateExpertTrainingRecords";
            this.Load += new System.EventHandler(this.UpdateExpertTrainingRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton SortDate;
        private System.Windows.Forms.RadioButton Sortname;
        private System.Windows.Forms.ComboBox compsname;
        private System.Windows.Forms.ComboBox skill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}