namespace Session4
{
    partial class UpdateCompetitorTrainingRecords
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mods = new System.Windows.Forms.TextBox();
            this.skill = new System.Windows.Forms.ComboBox();
            this.progress = new System.Windows.Forms.ComboBox();
            this.compsname = new System.Windows.Forms.ComboBox();
            this.Sortname = new System.Windows.Forms.RadioButton();
            this.SortDate = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 80);
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
            this.label1.Location = new System.Drawing.Point(620, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(198, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update Competitor Training Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by Progress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search By Module Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sort By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Competitor\'s Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Skill:";
            // 
            // mods
            // 
            this.mods.Location = new System.Drawing.Point(291, 268);
            this.mods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(234, 26);
            this.mods.TabIndex = 9;
            this.mods.TextChanged += new System.EventHandler(this.mods_TextChanged);
            // 
            // skill
            // 
            this.skill.FormattingEnabled = true;
            this.skill.Location = new System.Drawing.Point(291, 151);
            this.skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(234, 28);
            this.skill.TabIndex = 10;
            this.skill.SelectedIndexChanged += new System.EventHandler(this.skill_SelectedIndexChanged);
            // 
            // progress
            // 
            this.progress.FormattingEnabled = true;
            this.progress.Location = new System.Drawing.Point(291, 302);
            this.progress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(234, 28);
            this.progress.TabIndex = 11;
            this.progress.SelectedIndexChanged += new System.EventHandler(this.progress_SelectedIndexChanged);
            // 
            // compsname
            // 
            this.compsname.FormattingEnabled = true;
            this.compsname.Location = new System.Drawing.Point(291, 192);
            this.compsname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compsname.Name = "compsname";
            this.compsname.Size = new System.Drawing.Size(234, 28);
            this.compsname.TabIndex = 12;
            this.compsname.SelectedIndexChanged += new System.EventHandler(this.compsname_SelectedIndexChanged);
            // 
            // Sortname
            // 
            this.Sortname.AutoSize = true;
            this.Sortname.Location = new System.Drawing.Point(291, 230);
            this.Sortname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sortname.Name = "Sortname";
            this.Sortname.Size = new System.Drawing.Size(76, 24);
            this.Sortname.TabIndex = 13;
            this.Sortname.TabStop = true;
            this.Sortname.Text = "Name";
            this.Sortname.UseVisualStyleBackColor = true;
            this.Sortname.CheckedChanged += new System.EventHandler(this.Sortname_CheckedChanged);
            // 
            // SortDate
            // 
            this.SortDate.AutoSize = true;
            this.SortDate.Location = new System.Drawing.Point(372, 230);
            this.SortDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortDate.Name = "SortDate";
            this.SortDate.Size = new System.Drawing.Size(102, 24);
            this.SortDate.TabIndex = 14;
            this.SortDate.TabStop = true;
            this.SortDate.Text = "End Date";
            this.SortDate.UseVisualStyleBackColor = true;
            this.SortDate.CheckedChanged += new System.EventHandler(this.SortDate_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 340);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 188);
            this.dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 564);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateCompetitorTrainingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 655);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SortDate);
            this.Controls.Add(this.Sortname);
            this.Controls.Add(this.compsname);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.mods);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateCompetitorTrainingRecords";
            this.Text = "UpdateCompetitorTrainingRecords";
            this.Load += new System.EventHandler(this.UpdateCompetitorTrainingRecords_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mods;
        private System.Windows.Forms.ComboBox skill;
        private System.Windows.Forms.ComboBox progress;
        private System.Windows.Forms.ComboBox compsname;
        private System.Windows.Forms.RadioButton Sortname;
        private System.Windows.Forms.RadioButton SortDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}