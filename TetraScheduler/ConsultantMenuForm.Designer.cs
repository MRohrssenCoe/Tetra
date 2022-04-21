namespace TetraScheduler
{
    partial class ConsultantMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultantMenuForm));
            this.viewSchedButton = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desiredWeeklyHrsUpDn = new System.Windows.Forms.NumericUpDown();
            this.coeYrUpDn = new System.Windows.Forms.NumericUpDown();
            this.majorListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnameTextbox = new System.Windows.Forms.TextBox();
            this.semExpUpDn = new System.Windows.Forms.NumericUpDown();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeLoginInfo = new System.Windows.Forms.Button();
            this.availabilityBox = new System.Windows.Forms.ListBox();
            this.selectAvailabilityButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desiredWeeklyHrsUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeYrUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semExpUpDn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSchedButton
            // 
            this.viewSchedButton.Location = new System.Drawing.Point(115, 397);
            this.viewSchedButton.Name = "viewSchedButton";
            this.viewSchedButton.Size = new System.Drawing.Size(97, 40);
            this.viewSchedButton.TabIndex = 0;
            this.viewSchedButton.Text = "View Schedule";
            this.viewSchedButton.UseVisualStyleBackColor = true;
            this.viewSchedButton.Click += new System.EventHandler(this.ViewScheduleButtonClick);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(12, 397);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(97, 40);
            this.saveInfoButton.TabIndex = 17;
            this.saveInfoButton.Text = "Save Info";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.desiredWeeklyHrsUpDn);
            this.groupBox3.Controls.Add(this.coeYrUpDn);
            this.groupBox3.Controls.Add(this.majorListbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lnameTextbox);
            this.groupBox3.Controls.Add(this.semExpUpDn);
            this.groupBox3.Controls.Add(this.fnameTextbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 199);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Desired Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year at Coe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // desiredWeeklyHrsUpDn
            // 
            this.desiredWeeklyHrsUpDn.Location = new System.Drawing.Point(363, 128);
            this.desiredWeeklyHrsUpDn.Name = "desiredWeeklyHrsUpDn";
            this.desiredWeeklyHrsUpDn.Size = new System.Drawing.Size(33, 23);
            this.desiredWeeklyHrsUpDn.TabIndex = 20;
            // 
            // coeYrUpDn
            // 
            this.coeYrUpDn.Location = new System.Drawing.Point(363, 101);
            this.coeYrUpDn.Name = "coeYrUpDn";
            this.coeYrUpDn.Size = new System.Drawing.Size(32, 23);
            this.coeYrUpDn.TabIndex = 19;
            // 
            // majorListbox
            // 
            this.majorListbox.FormattingEnabled = true;
            this.majorListbox.Location = new System.Drawing.Point(6, 75);
            this.majorListbox.Name = "majorListbox";
            this.majorListbox.Size = new System.Drawing.Size(206, 94);
            this.majorListbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Semesters of Experience";
            // 
            // lnameTextbox
            // 
            this.lnameTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lnameTextbox.Location = new System.Drawing.Point(218, 22);
            this.lnameTextbox.Name = "lnameTextbox";
            this.lnameTextbox.Size = new System.Drawing.Size(178, 23);
            this.lnameTextbox.TabIndex = 12;
            this.lnameTextbox.Text = "Last Name";
            // 
            // semExpUpDn
            // 
            this.semExpUpDn.Location = new System.Drawing.Point(363, 75);
            this.semExpUpDn.Name = "semExpUpDn";
            this.semExpUpDn.Size = new System.Drawing.Size(33, 23);
            this.semExpUpDn.TabIndex = 13;
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fnameTextbox.Location = new System.Drawing.Point(6, 22);
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(206, 23);
            this.fnameTextbox.TabIndex = 11;
            this.fnameTextbox.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Major";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.changeLoginInfo);
            this.groupBox2.Controls.Add(this.availabilityBox);
            this.groupBox2.Controls.Add(this.selectAvailabilityButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 174);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability";
            // 
            // changeLoginInfo
            // 
            this.changeLoginInfo.Location = new System.Drawing.Point(273, 139);
            this.changeLoginInfo.Name = "changeLoginInfo";
            this.changeLoginInfo.Size = new System.Drawing.Size(111, 23);
            this.changeLoginInfo.TabIndex = 23;
            this.changeLoginInfo.Text = "change u/p";
            this.changeLoginInfo.UseVisualStyleBackColor = true;
            this.changeLoginInfo.Click += new System.EventHandler(this.changeLoginInfo_Click);
            // 
            // availabilityBox
            // 
            this.availabilityBox.FormattingEnabled = true;
            this.availabilityBox.ItemHeight = 15;
            this.availabilityBox.Location = new System.Drawing.Point(7, 23);
            this.availabilityBox.Name = "availabilityBox";
            this.availabilityBox.Size = new System.Drawing.Size(205, 139);
            this.availabilityBox.TabIndex = 22;
            // 
            // selectAvailabilityButton
            // 
            this.selectAvailabilityButton.Location = new System.Drawing.Point(218, 44);
            this.selectAvailabilityButton.Name = "selectAvailabilityButton";
            this.selectAvailabilityButton.Size = new System.Drawing.Size(178, 37);
            this.selectAvailabilityButton.TabIndex = 21;
            this.selectAvailabilityButton.Text = "Select Availability";
            this.selectAvailabilityButton.UseVisualStyleBackColor = true;
            this.selectAvailabilityButton.Click += new System.EventHandler(this.SelectAvailabilityButtonClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(304, 397);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(105, 40);
            this.logoutButton.TabIndex = 21;
            this.logoutButton.Text = "Close Menu";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewSchedButton);
            this.Controls.Add(this.saveInfoButton);
            this.Name = "ConsultantMenuForm";
            this.Text = "Consultant Menu";
            this.Load += new System.EventHandler(this.ConsultantMenuForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desiredWeeklyHrsUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeYrUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semExpUpDn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox majorListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lnameTextbox;
        private System.Windows.Forms.NumericUpDown expNumPicker;
        private System.Windows.Forms.TextBox fnameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button availSelectButton;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Button viewSchedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button selectAvailabilityButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown desiredWeeklyHrsUpDn;
        private System.Windows.Forms.NumericUpDown coeYrUpDn;
        private System.Windows.Forms.NumericUpDown semExpUpDn;
        private System.Windows.Forms.ListBox availabilityBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changeLoginInfo;
    }
}