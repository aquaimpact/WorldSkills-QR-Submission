namespace Session1
{
    partial class CreateNewAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UName = new System.Windows.Forms.TextBox();
            this.PassC = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.UType = new System.Windows.Forms.ComboBox();
            this.CABtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Account Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-Enter Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "User ID (For Login):";
            // 
            // UName
            // 
            this.UName.Location = new System.Drawing.Point(288, 186);
            this.UName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(330, 26);
            this.UName.TabIndex = 6;
            // 
            // PassC
            // 
            this.PassC.Location = new System.Drawing.Point(288, 365);
            this.PassC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassC.Name = "PassC";
            this.PassC.PasswordChar = '*';
            this.PassC.Size = new System.Drawing.Size(330, 26);
            this.PassC.TabIndex = 7;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(288, 314);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(330, 26);
            this.Pass.TabIndex = 8;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(288, 256);
            this.UID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(330, 26);
            this.UID.TabIndex = 9;
            // 
            // UType
            // 
            this.UType.FormattingEnabled = true;
            this.UType.Location = new System.Drawing.Point(288, 425);
            this.UType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UType.Name = "UType";
            this.UType.Size = new System.Drawing.Size(330, 28);
            this.UType.TabIndex = 10;
            this.UType.SelectedIndexChanged += new System.EventHandler(this.UType_SelectedIndexChanged);
            // 
            // CABtn
            // 
            this.CABtn.Location = new System.Drawing.Point(288, 486);
            this.CABtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CABtn.Name = "CABtn";
            this.CABtn.Size = new System.Drawing.Size(331, 45);
            this.CABtn.TabIndex = 11;
            this.CABtn.Text = "Create Account";
            this.CABtn.UseVisualStyleBackColor = true;
            this.CABtn.Click += new System.EventHandler(this.CABtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 102);
            this.panel1.TabIndex = 13;
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
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CABtn);
            this.Controls.Add(this.UType);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.PassC);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateNewAccount";
            this.Text = "CreateNewAccount";
            this.Load += new System.EventHandler(this.CreateNewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.TextBox PassC;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.ComboBox UType;
        private System.Windows.Forms.Button CABtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label7;
    }
}