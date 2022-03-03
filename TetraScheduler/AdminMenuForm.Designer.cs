
namespace TetraScheduler
{
    partial class AdminMenuForm
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
            this.viewSchedButton = new System.Windows.Forms.Button();
            this.genScheduleButton = new System.Windows.Forms.Button();
            this.viewConsultButton = new System.Windows.Forms.Button();
            this.mixMajorCheck = new System.Windows.Forms.CheckBox();
            this.mixYearsCheck = new System.Windows.Forms.CheckBox();
            this.busyList = new System.Windows.Forms.ListBox();
            this.busyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lastGenLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.viewAdminButton = new System.Windows.Forms.Button();
            this.removeAccButton = new System.Windows.Forms.Button();
            this.addAccButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSchedButton
            // 
            this.viewSchedButton.Location = new System.Drawing.Point(374, 368);
            this.viewSchedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewSchedButton.Name = "viewSchedButton";
            this.viewSchedButton.Size = new System.Drawing.Size(168, 43);
            this.viewSchedButton.TabIndex = 0;
            this.viewSchedButton.Text = "View Current Schedule";
            this.viewSchedButton.UseVisualStyleBackColor = true;
            this.viewSchedButton.Click += new System.EventHandler(this.viewSchedButton_Click);
            // 
            // genScheduleButton
            // 
            this.genScheduleButton.Location = new System.Drawing.Point(85, 364);
            this.genScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genScheduleButton.Name = "genScheduleButton";
            this.genScheduleButton.Size = new System.Drawing.Size(168, 43);
            this.genScheduleButton.TabIndex = 1;
            this.genScheduleButton.Text = "Generate New Schedule";
            this.genScheduleButton.UseVisualStyleBackColor = true;
            this.genScheduleButton.Click += new System.EventHandler(this.genScheduleButton_Click);
            // 
            // viewConsultButton
            // 
            this.viewConsultButton.Location = new System.Drawing.Point(3, 4);
            this.viewConsultButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewConsultButton.Name = "viewConsultButton";
            this.viewConsultButton.Size = new System.Drawing.Size(175, 49);
            this.viewConsultButton.TabIndex = 2;
            this.viewConsultButton.Text = "View Consultant Info";
            this.viewConsultButton.UseVisualStyleBackColor = true;
            // 
            // mixMajorCheck
            // 
            this.mixMajorCheck.AutoSize = true;
            this.mixMajorCheck.Location = new System.Drawing.Point(3, 4);
            this.mixMajorCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mixMajorCheck.Name = "mixMajorCheck";
            this.mixMajorCheck.Size = new System.Drawing.Size(122, 24);
            this.mixMajorCheck.TabIndex = 3;
            this.mixMajorCheck.Text = "Mix of majors";
            this.mixMajorCheck.UseVisualStyleBackColor = true;
            // 
            // mixYearsCheck
            // 
            this.mixYearsCheck.AutoSize = true;
            this.mixYearsCheck.Location = new System.Drawing.Point(5, 37);
            this.mixYearsCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mixYearsCheck.Name = "mixYearsCheck";
            this.mixYearsCheck.Size = new System.Drawing.Size(158, 24);
            this.mixYearsCheck.TabIndex = 4;
            this.mixYearsCheck.Text = "Mix of school years";
            this.mixYearsCheck.UseVisualStyleBackColor = true;
            // 
            // busyList
            // 
            this.busyList.FormattingEnabled = true;
            this.busyList.ItemHeight = 20;
            this.busyList.Location = new System.Drawing.Point(29, 37);
            this.busyList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.busyList.Name = "busyList";
            this.busyList.Size = new System.Drawing.Size(276, 144);
            this.busyList.TabIndex = 5;
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(130, 13);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(79, 20);
            this.busyLabel.TabIndex = 6;
            this.busyLabel.Text = "Busy Shifts";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.genScheduleButton);
            this.panel1.Location = new System.Drawing.Point(14, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 413);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mixMajorCheck);
            this.panel4.Controls.Add(this.mixYearsCheck);
            this.panel4.Location = new System.Drawing.Point(5, 268);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 92);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.busyList);
            this.panel3.Controls.Add(this.busyLabel);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 256);
            this.panel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select Busy Shifts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastGenLabel
            // 
            this.lastGenLabel.AutoSize = true;
            this.lastGenLabel.Location = new System.Drawing.Point(393, 415);
            this.lastGenLabel.Name = "lastGenLabel";
            this.lastGenLabel.Size = new System.Drawing.Size(141, 20);
            this.lastGenLabel.TabIndex = 14;
            this.lastGenLabel.Text = "Last generated: N/A";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.viewAdminButton);
            this.panel10.Controls.Add(this.removeAccButton);
            this.panel10.Controls.Add(this.addAccButton);
            this.panel10.Controls.Add(this.viewConsultButton);
            this.panel10.Location = new System.Drawing.Point(366, 87);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(184, 231);
            this.panel10.TabIndex = 14;
            // 
            // viewAdminButton
            // 
            this.viewAdminButton.Location = new System.Drawing.Point(3, 61);
            this.viewAdminButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewAdminButton.Name = "viewAdminButton";
            this.viewAdminButton.Size = new System.Drawing.Size(175, 49);
            this.viewAdminButton.TabIndex = 5;
            this.viewAdminButton.Text = "View Admin Info";
            this.viewAdminButton.UseVisualStyleBackColor = true;
            // 
            // removeAccButton
            // 
            this.removeAccButton.Location = new System.Drawing.Point(3, 176);
            this.removeAccButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeAccButton.Name = "removeAccButton";
            this.removeAccButton.Size = new System.Drawing.Size(175, 49);
            this.removeAccButton.TabIndex = 4;
            this.removeAccButton.Text = "Remove Account";
            this.removeAccButton.UseVisualStyleBackColor = true;
            this.removeAccButton.Click += new System.EventHandler(this.removeAccButton_Click);
            // 
            // addAccButton
            // 
            this.addAccButton.Location = new System.Drawing.Point(3, 119);
            this.addAccButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAccButton.Name = "addAccButton";
            this.addAccButton.Size = new System.Drawing.Size(175, 49);
            this.addAccButton.TabIndex = 3;
            this.addAccButton.Text = "Add Account";
            this.addAccButton.UseVisualStyleBackColor = true;
            this.addAccButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Schedule Tools";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Account Tools";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(171, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(248, 38);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, [name]!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.lastGenLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.viewSchedButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMenuForm";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewSchedButton;
        private System.Windows.Forms.Button genScheduleButton;
        private System.Windows.Forms.Button viewConsultButton;
        private System.Windows.Forms.CheckBox mixMajorCheck;
        private System.Windows.Forms.CheckBox mixYearsCheck;
        private System.Windows.Forms.ListBox busyList;
        private System.Windows.Forms.Label busyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lastGenLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button viewAdminButton;
        private System.Windows.Forms.Button removeAccButton;
        private System.Windows.Forms.Button addAccButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}