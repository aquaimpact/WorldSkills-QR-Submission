namespace Session1
{
    partial class Form1
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
            this.CNABtn = new System.Windows.Forms.Button();
            this.RMLBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CNABtn
            // 
            this.CNABtn.Location = new System.Drawing.Point(312, 128);
            this.CNABtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNABtn.Name = "CNABtn";
            this.CNABtn.Size = new System.Drawing.Size(219, 138);
            this.CNABtn.TabIndex = 0;
            this.CNABtn.Text = "Create New Account";
            this.CNABtn.UseVisualStyleBackColor = true;
            this.CNABtn.Click += new System.EventHandler(this.CNABtn_Click);
            // 
            // RMLBtn
            // 
            this.RMLBtn.Location = new System.Drawing.Point(312, 311);
            this.RMLBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RMLBtn.Name = "RMLBtn";
            this.RMLBtn.Size = new System.Drawing.Size(219, 120);
            this.RMLBtn.TabIndex = 1;
            this.RMLBtn.Text = "Resource Manager Login";
            this.RMLBtn.UseVisualStyleBackColor = true;
            this.RMLBtn.Click += new System.EventHandler(this.RMLBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 102);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(210, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020 26 - 28 Jul 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RMLBtn);
            this.Controls.Add(this.CNABtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CNABtn;
        private System.Windows.Forms.Button RMLBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

