
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
            this.startBusy = new System.Windows.Forms.DateTimePicker();
            this.endBusy = new System.Windows.Forms.DateTimePicker();
            this.addBusy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeAllBusy = new System.Windows.Forms.Button();
            this.removeSelectBusy = new System.Windows.Forms.Button();
            this.lastGenLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.viewAdminButton = new System.Windows.Forms.Button();
            this.removeAccButton = new System.Windows.Forms.Button();
            this.addAccButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSchedButton
            // 
            this.viewSchedButton.Location = new System.Drawing.Point(327, 276);
            this.viewSchedButton.Name = "viewSchedButton";
            this.viewSchedButton.Size = new System.Drawing.Size(147, 32);
            this.viewSchedButton.TabIndex = 0;
            this.viewSchedButton.Text = "View Current Schedule";
            this.viewSchedButton.UseVisualStyleBackColor = true;
            this.viewSchedButton.Click += new System.EventHandler(this.viewSchedButton_Click);
            // 
            // genScheduleButton
            // 
            this.genScheduleButton.Location = new System.Drawing.Point(74, 273);
            this.genScheduleButton.Name = "genScheduleButton";
            this.genScheduleButton.Size = new System.Drawing.Size(147, 32);
            this.genScheduleButton.TabIndex = 1;
            this.genScheduleButton.Text = "Generate New Schedule";
            this.genScheduleButton.UseVisualStyleBackColor = true;
            this.genScheduleButton.Click += new System.EventHandler(this.genScheduleButton_Click);
            // 
            // viewConsultButton
            // 
            this.viewConsultButton.Location = new System.Drawing.Point(3, 3);
            this.viewConsultButton.Name = "viewConsultButton";
            this.viewConsultButton.Size = new System.Drawing.Size(153, 37);
            this.viewConsultButton.TabIndex = 2;
            this.viewConsultButton.Text = "View Consultant Info";
            this.viewConsultButton.UseVisualStyleBackColor = true;
            // 
            // mixMajorCheck
            // 
            this.mixMajorCheck.AutoSize = true;
            this.mixMajorCheck.Location = new System.Drawing.Point(3, 3);
            this.mixMajorCheck.Name = "mixMajorCheck";
            this.mixMajorCheck.Size = new System.Drawing.Size(99, 19);
            this.mixMajorCheck.TabIndex = 3;
            this.mixMajorCheck.Text = "Mix of majors";
            this.mixMajorCheck.UseVisualStyleBackColor = true;
            // 
            // mixYearsCheck
            // 
            this.mixYearsCheck.AutoSize = true;
            this.mixYearsCheck.Location = new System.Drawing.Point(4, 28);
            this.mixYearsCheck.Name = "mixYearsCheck";
            this.mixYearsCheck.Size = new System.Drawing.Size(128, 19);
            this.mixYearsCheck.TabIndex = 4;
            this.mixYearsCheck.Text = "Mix of school years";
            this.mixYearsCheck.UseVisualStyleBackColor = true;
            // 
            // busyList
            // 
            this.busyList.FormattingEnabled = true;
            this.busyList.ItemHeight = 15;
            this.busyList.Location = new System.Drawing.Point(25, 28);
            this.busyList.Name = "busyList";
            this.busyList.Size = new System.Drawing.Size(242, 109);
            this.busyList.TabIndex = 5;
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(114, 10);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(64, 15);
            this.busyLabel.TabIndex = 6;
            this.busyLabel.Text = "Busy Shifts";
            // 
            // startBusy
            // 
            this.startBusy.Location = new System.Drawing.Point(3, 3);
            this.startBusy.Name = "startBusy";
            this.startBusy.Size = new System.Drawing.Size(90, 23);
            this.startBusy.TabIndex = 8;
            // 
            // endBusy
            // 
            this.endBusy.Location = new System.Drawing.Point(118, 3);
            this.endBusy.Name = "endBusy";
            this.endBusy.Size = new System.Drawing.Size(90, 23);
            this.endBusy.TabIndex = 9;
            // 
            // addBusy
            // 
            this.addBusy.Location = new System.Drawing.Point(214, 3);
            this.addBusy.Name = "addBusy";
            this.addBusy.Size = new System.Drawing.Size(62, 23);
            this.addBusy.TabIndex = 10;
            this.addBusy.Text = "Add";
            this.addBusy.UseVisualStyleBackColor = true;
            this.addBusy.Click += new System.EventHandler(this.addBusy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.genScheduleButton);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 310);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mixMajorCheck);
            this.panel4.Controls.Add(this.mixYearsCheck);
            this.panel4.Location = new System.Drawing.Point(4, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 50);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.busyList);
            this.panel3.Controls.Add(this.busyLabel);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 211);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.removeAllBusy);
            this.panel2.Controls.Add(this.removeSelectBusy);
            this.panel2.Controls.Add(this.startBusy);
            this.panel2.Controls.Add(this.addBusy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.endBusy);
            this.panel2.Location = new System.Drawing.Point(3, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 61);
            this.panel2.TabIndex = 7;
            // 
            // removeAllBusy
            // 
            this.removeAllBusy.Location = new System.Drawing.Point(3, 32);
            this.removeAllBusy.Name = "removeAllBusy";
            this.removeAllBusy.Size = new System.Drawing.Size(134, 23);
            this.removeAllBusy.TabIndex = 13;
            this.removeAllBusy.Text = "Remove All";
            this.removeAllBusy.UseVisualStyleBackColor = true;
            this.removeAllBusy.Click += new System.EventHandler(this.removeAllBusy_Click);
            // 
            // removeSelectBusy
            // 
            this.removeSelectBusy.Location = new System.Drawing.Point(156, 32);
            this.removeSelectBusy.Name = "removeSelectBusy";
            this.removeSelectBusy.Size = new System.Drawing.Size(124, 23);
            this.removeSelectBusy.TabIndex = 12;
            this.removeSelectBusy.Text = "Remove Selected";
            this.removeSelectBusy.UseVisualStyleBackColor = true;
            this.removeSelectBusy.Click += new System.EventHandler(this.removeSelectBusy_Click);
            // 
            // lastGenLabel
            // 
            this.lastGenLabel.AutoSize = true;
            this.lastGenLabel.Location = new System.Drawing.Point(344, 311);
            this.lastGenLabel.Name = "lastGenLabel";
            this.lastGenLabel.Size = new System.Drawing.Size(112, 15);
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
            this.panel10.Location = new System.Drawing.Point(320, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(161, 174);
            this.panel10.TabIndex = 14;
            // 
            // viewAdminButton
            // 
            this.viewAdminButton.Location = new System.Drawing.Point(3, 46);
            this.viewAdminButton.Name = "viewAdminButton";
            this.viewAdminButton.Size = new System.Drawing.Size(153, 37);
            this.viewAdminButton.TabIndex = 5;
            this.viewAdminButton.Text = "View Admin Info";
            this.viewAdminButton.UseVisualStyleBackColor = true;
            // 
            // removeAccButton
            // 
            this.removeAccButton.Location = new System.Drawing.Point(3, 132);
            this.removeAccButton.Name = "removeAccButton";
            this.removeAccButton.Size = new System.Drawing.Size(153, 37);
            this.removeAccButton.TabIndex = 4;
            this.removeAccButton.Text = "Remove Account";
            this.removeAccButton.UseVisualStyleBackColor = true;
            // 
            // addAccButton
            // 
            this.addAccButton.Location = new System.Drawing.Point(3, 89);
            this.addAccButton.Name = "addAccButton";
            this.addAccButton.Size = new System.Drawing.Size(153, 37);
            this.addAccButton.TabIndex = 3;
            this.addAccButton.Text = "Add Account";
            this.addAccButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Schedule Tools";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Account Tools";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(150, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(192, 30);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, [name]!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 385);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.lastGenLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.viewSchedButton);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenuForm";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker startBusy;
        private System.Windows.Forms.DateTimePicker endBusy;
        private System.Windows.Forms.Button addBusy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeAllBusy;
        private System.Windows.Forms.Button removeSelectBusy;
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
    }
}