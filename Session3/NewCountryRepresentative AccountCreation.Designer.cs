namespace Session3
{
    partial class NewCountryRepresentative_AccountCreation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.PassC = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LiveTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(144, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Country Representative Account Creation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID (For Login):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 102);
            this.panel1.TabIndex = 6;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(303, 242);
            this.UserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(258, 26);
            this.UserId.TabIndex = 8;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(303, 285);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(258, 26);
            this.Pass.TabIndex = 9;
            // 
            // PassC
            // 
            this.PassC.Location = new System.Drawing.Point(303, 339);
            this.PassC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassC.Name = "PassC";
            this.PassC.Size = new System.Drawing.Size(258, 26);
            this.PassC.TabIndex = 10;
            this.PassC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(303, 191);
            this.Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(258, 28);
            this.Country.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LiveTime);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(2, 495);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 102);
            this.panel2.TabIndex = 12;
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
            // NewCountryRepresentative_AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.PassC);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewCountryRepresentative_AccountCreation";
            this.Text = "NewCountryRepresentative_AccountCreation";
            this.Load += new System.EventHandler(this.NewCountryRepresentative_AccountCreation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox PassC;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LiveTime;
        private System.Windows.Forms.Timer timer1;
    }
}