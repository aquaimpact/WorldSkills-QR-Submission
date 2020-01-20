namespace Session5
{
    partial class EnterMarks
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
            this.Total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Sumbit = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.ComboBox();
            this.session = new System.Windows.Forms.ComboBox();
            this.skill = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
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
            this.label2.Location = new System.Drawing.Point(330, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Marks";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(659, 511);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(51, 20);
            this.Total.TabIndex = 8;
            this.Total.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Marks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Competitor Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Session:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Skill:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(741, 388);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 64);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear Form";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sumbit
            // 
            this.Sumbit.Location = new System.Drawing.Point(741, 459);
            this.Sumbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sumbit.Name = "Sumbit";
            this.Sumbit.Size = new System.Drawing.Size(112, 61);
            this.Sumbit.TabIndex = 15;
            this.Sumbit.Text = "Submit";
            this.Sumbit.UseVisualStyleBackColor = true;
            this.Sumbit.Click += new System.EventHandler(this.Sumbit_Click);
            // 
            // sname
            // 
            this.sname.FormattingEnabled = true;
            this.sname.Location = new System.Drawing.Point(335, 255);
            this.sname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(254, 28);
            this.sname.TabIndex = 16;
            this.sname.SelectedIndexChanged += new System.EventHandler(this.sname_SelectedIndexChanged);
            // 
            // session
            // 
            this.session.FormattingEnabled = true;
            this.session.Location = new System.Drawing.Point(335, 214);
            this.session.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(254, 28);
            this.session.TabIndex = 17;
            this.session.SelectedIndexChanged += new System.EventHandler(this.session_SelectedIndexChanged);
            // 
            // skill
            // 
            this.skill.FormattingEnabled = true;
            this.skill.Location = new System.Drawing.Point(335, 165);
            this.skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(254, 28);
            this.skill.TabIndex = 18;
            this.skill.SelectedIndexChanged += new System.EventHandler(this.skill_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 188);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // EnterMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.session);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.Sumbit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnterMarks";
            this.Text = "EnterMarks";
            this.Load += new System.EventHandler(this.EnterMarks_Load);
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
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Sumbit;
        private System.Windows.Forms.ComboBox sname;
        private System.Windows.Forms.ComboBox session;
        private System.Windows.Forms.ComboBox skill;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}