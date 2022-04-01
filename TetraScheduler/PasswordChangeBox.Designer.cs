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
            this.SuspendLayout();
            // 
            // AdminUsernameBox
            // 
            this.AdminUsernameBox.Location = new System.Drawing.Point(159, 115);
            this.AdminUsernameBox.Name = "AdminUsernameBox";
            this.AdminUsernameBox.Size = new System.Drawing.Size(125, 27);
            this.AdminUsernameBox.TabIndex = 0;
            // 
            // AdminPasswordBox
            // 
            this.AdminPasswordBox.Location = new System.Drawing.Point(159, 192);
            this.AdminPasswordBox.Name = "AdminPasswordBox";
            this.AdminPasswordBox.PasswordChar = '*';
            this.AdminPasswordBox.Size = new System.Drawing.Size(125, 27);
            this.AdminPasswordBox.TabIndex = 1;
            this.AdminPasswordBox.TextChanged += new System.EventHandler(this.AdminPasswordBox_TextChanged);
            
            this.AdminPasswordBox.Click += new System.EventHandler(this.AdminPasswordBox_Enter);
            this.AdminPasswordBox.Enter += new System.EventHandler(this.AdminPasswordBox_Enter);
            this.AdminPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminPasswordBox_KeyPress);
            this.AdminPasswordBox.Leave += new System.EventHandler(this.AdminPasswordBox_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new credentials for the administrator account:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordChangeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminPasswordBox);
            this.Controls.Add(this.AdminUsernameBox);
            this.Name = "PasswordChangeBox";
            this.Text = "PasswordChangeBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminUsernameBox;
        private System.Windows.Forms.TextBox AdminPasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        }
}