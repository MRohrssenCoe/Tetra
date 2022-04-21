namespace TetraScheduler
{
    partial class PasswordChangeBox
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
            this.AdminUsernameBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.uLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.cpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminUsernameBox
            // 
            this.AdminUsernameBox.Location = new System.Drawing.Point(156, 87);
            this.AdminUsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminUsernameBox.Name = "AdminUsernameBox";
            this.AdminUsernameBox.Size = new System.Drawing.Size(110, 23);
            this.AdminUsernameBox.TabIndex = 0;
            // 
            // AdminPasswordBox
            // 
            this.AdminPasswordBox.Location = new System.Drawing.Point(156, 124);
            this.AdminPasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPasswordBox.Name = "AdminPasswordBox";
            this.AdminPasswordBox.PasswordChar = '*';
            this.AdminPasswordBox.Size = new System.Drawing.Size(110, 23);
            this.AdminPasswordBox.TabIndex = 1;
            this.AdminPasswordBox.Click += new System.EventHandler(this.AdminPasswordBox_Enter);
            this.AdminPasswordBox.TextChanged += new System.EventHandler(this.AdminPasswordBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Login Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter updated username and password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.Location = new System.Drawing.Point(156, 161);
            this.confirmPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.PasswordChar = '*';
            this.confirmPassBox.Size = new System.Drawing.Size(110, 23);
            this.confirmPassBox.TabIndex = 2;
            this.confirmPassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hitEnterOnLastTab);
            // 
            // uLabel
            // 
            this.uLabel.AutoSize = true;
            this.uLabel.Location = new System.Drawing.Point(77, 87);
            this.uLabel.Name = "uLabel";
            this.uLabel.Size = new System.Drawing.Size(63, 15);
            this.uLabel.TabIndex = 5;
            this.uLabel.Text = "Username:";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(77, 127);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(60, 15);
            this.pLabel.TabIndex = 6;
            this.pLabel.Text = "Password:";
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(43, 164);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(107, 15);
            this.cpLabel.TabIndex = 7;
            this.cpLabel.Text = "Confirm Password:";
            // 
            // PasswordChangeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.Controls.Add(this.cpLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.uLabel);
            this.Controls.Add(this.confirmPassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminPasswordBox);
            this.Controls.Add(this.AdminUsernameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PasswordChangeBox";
            this.Text = "PasswordChangeBox";
            this.Load += new System.EventHandler(this.PasswordChangeBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminUsernameBox;
        private System.Windows.Forms.TextBox AdminPasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.Label uLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label cpLabel;
    }
}