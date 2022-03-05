
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
            this.label3 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.genScheduleButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.busyLabel = new System.Windows.Forms.Label();
            this.busyListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mixYearsCheck = new System.Windows.Forms.CheckBox();
            this.mixMajorCheck = new System.Windows.Forms.CheckBox();
            this.mixSemestersCheck = new System.Windows.Forms.CheckBox();
            this.ConsecutiveShiftsBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.shiftLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.busyConsultantsPerShiftBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consultantsPerShiftBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lastGenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.viewAdminButton = new System.Windows.Forms.Button();
            this.removeAccButton = new System.Windows.Forms.Button();
            this.addAccButton = new System.Windows.Forms.Button();
            this.viewConsultButton = new System.Windows.Forms.Button();
            this.viewSchedButton = new System.Windows.Forms.Button();
            this.sundayCheck = new System.Windows.Forms.CheckBox();
            this.mondayCheck = new System.Windows.Forms.CheckBox();
            this.wednesdayCheck = new System.Windows.Forms.CheckBox();
            this.thursdayCheck = new System.Windows.Forms.CheckBox();
            this.fridayCheck = new System.Windows.Forms.CheckBox();
            this.saturdayCheck = new System.Windows.Forms.CheckBox();
            this.tuesdayCheck = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ConsecutiveShiftsBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyConsultantsPerShiftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsPerShiftBox)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
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
            // genScheduleButton
            // 
            this.genScheduleButton.Location = new System.Drawing.Point(3, 509);
            this.genScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genScheduleButton.Name = "genScheduleButton";
            this.genScheduleButton.Size = new System.Drawing.Size(168, 43);
            this.genScheduleButton.TabIndex = 1;
            this.genScheduleButton.Text = "Generate Schedule";
            this.genScheduleButton.UseVisualStyleBackColor = true;
            this.genScheduleButton.Click += new System.EventHandler(this.genScheduleButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 509);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save Admin Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(131, 11);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(79, 20);
            this.busyLabel.TabIndex = 19;
            this.busyLabel.Text = "Busy Shifts";
            // 
            // busyListBox
            // 
            this.busyListBox.FormattingEnabled = true;
            this.busyListBox.ItemHeight = 20;
            this.busyListBox.Location = new System.Drawing.Point(30, 35);
            this.busyListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.busyListBox.Name = "busyListBox";
            this.busyListBox.Size = new System.Drawing.Size(276, 144);
            this.busyListBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Select Busy Shifts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectBusyShiftsClick);
            // 
            // mixYearsCheck
            // 
            this.mixYearsCheck.AutoSize = true;
            this.mixYearsCheck.Location = new System.Drawing.Point(30, 259);
            this.mixYearsCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mixYearsCheck.Name = "mixYearsCheck";
            this.mixYearsCheck.Size = new System.Drawing.Size(158, 24);
            this.mixYearsCheck.TabIndex = 22;
            this.mixYearsCheck.Text = "Mix of school years";
            this.mixYearsCheck.UseVisualStyleBackColor = true;
            // 
            // mixMajorCheck
            // 
            this.mixMajorCheck.AutoSize = true;
            this.mixMajorCheck.Location = new System.Drawing.Point(30, 231);
            this.mixMajorCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mixMajorCheck.Name = "mixMajorCheck";
            this.mixMajorCheck.Size = new System.Drawing.Size(122, 24);
            this.mixMajorCheck.TabIndex = 21;
            this.mixMajorCheck.Text = "Mix of majors";
            this.mixMajorCheck.UseVisualStyleBackColor = true;
            // 
            // mixSemestersCheck
            // 
            this.mixSemestersCheck.AutoSize = true;
            this.mixSemestersCheck.Location = new System.Drawing.Point(30, 285);
            this.mixSemestersCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mixSemestersCheck.Name = "mixSemestersCheck";
            this.mixSemestersCheck.Size = new System.Drawing.Size(236, 24);
            this.mixSemestersCheck.TabIndex = 23;
            this.mixSemestersCheck.Text = "Mix of semesters of experience";
            this.mixSemestersCheck.UseVisualStyleBackColor = true;
            // 
            // ConsecutiveShiftsBox
            // 
            this.ConsecutiveShiftsBox.Location = new System.Drawing.Point(275, 311);
            this.ConsecutiveShiftsBox.Name = "ConsecutiveShiftsBox";
            this.ConsecutiveShiftsBox.Size = new System.Drawing.Size(42, 27);
            this.ConsecutiveShiftsBox.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.shiftLengthUpDown);
            this.panel1.Controls.Add(this.busyConsultantsPerShiftBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ConsecutiveShiftsBox);
            this.panel1.Controls.Add(this.consultantsPerShiftBox);
            this.panel1.Controls.Add(this.mixSemestersCheck);
            this.panel1.Controls.Add(this.mixMajorCheck);
            this.panel1.Controls.Add(this.mixYearsCheck);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.busyListBox);
            this.panel1.Controls.Add(this.busyLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.genScheduleButton);
            this.panel1.Location = new System.Drawing.Point(14, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 558);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Shift length in Minutes";
            // 
            // shiftLengthUpDown
            // 
            this.shiftLengthUpDown.Location = new System.Drawing.Point(275, 413);
            this.shiftLengthUpDown.Name = "shiftLengthUpDown";
            this.shiftLengthUpDown.Size = new System.Drawing.Size(42, 27);
            this.shiftLengthUpDown.TabIndex = 56;
            this.shiftLengthUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // busyConsultantsPerShiftBox
            // 
            this.busyConsultantsPerShiftBox.Location = new System.Drawing.Point(275, 380);
            this.busyConsultantsPerShiftBox.Name = "busyConsultantsPerShiftBox";
            this.busyConsultantsPerShiftBox.Size = new System.Drawing.Size(42, 27);
            this.busyConsultantsPerShiftBox.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Consultants per busy shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Consultants per shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Schedule for consecutive shifts?";
            // 
            // consultantsPerShiftBox
            // 
            this.consultantsPerShiftBox.Location = new System.Drawing.Point(275, 344);
            this.consultantsPerShiftBox.Name = "consultantsPerShiftBox";
            this.consultantsPerShiftBox.Size = new System.Drawing.Size(42, 27);
            this.consultantsPerShiftBox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Open Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Close Time";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 43);
            this.button2.TabIndex = 44;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lastGenLabel
            // 
            this.lastGenLabel.AutoSize = true;
            this.lastGenLabel.Location = new System.Drawing.Point(597, 415);
            this.lastGenLabel.Name = "lastGenLabel";
            this.lastGenLabel.Size = new System.Drawing.Size(141, 20);
            this.lastGenLabel.TabIndex = 41;
            this.lastGenLabel.Text = "Last generated: N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Account Tools";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.viewAdminButton);
            this.panel10.Controls.Add(this.removeAccButton);
            this.panel10.Controls.Add(this.addAccButton);
            this.panel10.Controls.Add(this.viewConsultButton);
            this.panel10.Location = new System.Drawing.Point(570, 87);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(184, 231);
            this.panel10.TabIndex = 42;
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
            // viewSchedButton
            // 
            this.viewSchedButton.Location = new System.Drawing.Point(578, 360);
            this.viewSchedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewSchedButton.Name = "viewSchedButton";
            this.viewSchedButton.Size = new System.Drawing.Size(168, 43);
            this.viewSchedButton.TabIndex = 40;
            this.viewSchedButton.Text = "View Current Schedule";
            this.viewSchedButton.UseVisualStyleBackColor = true;
            this.viewSchedButton.Click += new System.EventHandler(this.viewSchedButton_Click);
            this.viewSchedButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewSchedButton_MouseClick);
            // 
            // sundayCheck
            // 
            this.sundayCheck.AutoSize = true;
            this.sundayCheck.Location = new System.Drawing.Point(377, 87);
            this.sundayCheck.Name = "sundayCheck";
            this.sundayCheck.Size = new System.Drawing.Size(79, 24);
            this.sundayCheck.TabIndex = 45;
            this.sundayCheck.Text = "Sunday";
            this.sundayCheck.UseVisualStyleBackColor = true;
            // 
            // mondayCheck
            // 
            this.mondayCheck.AutoSize = true;
            this.mondayCheck.Checked = true;
            this.mondayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mondayCheck.Location = new System.Drawing.Point(377, 117);
            this.mondayCheck.Name = "mondayCheck";
            this.mondayCheck.Size = new System.Drawing.Size(85, 24);
            this.mondayCheck.TabIndex = 46;
            this.mondayCheck.Text = "Monday";
            this.mondayCheck.UseVisualStyleBackColor = true;
            this.mondayCheck.CheckedChanged += new System.EventHandler(this.mondayCheck_CheckedChanged);
            // 
            // wednesdayCheck
            // 
            this.wednesdayCheck.AutoSize = true;
            this.wednesdayCheck.Checked = true;
            this.wednesdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wednesdayCheck.Location = new System.Drawing.Point(377, 177);
            this.wednesdayCheck.Name = "wednesdayCheck";
            this.wednesdayCheck.Size = new System.Drawing.Size(107, 24);
            this.wednesdayCheck.TabIndex = 47;
            this.wednesdayCheck.Text = "Wednesday";
            this.wednesdayCheck.UseVisualStyleBackColor = true;
            this.wednesdayCheck.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // thursdayCheck
            // 
            this.thursdayCheck.AutoSize = true;
            this.thursdayCheck.Checked = true;
            this.thursdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thursdayCheck.Location = new System.Drawing.Point(377, 207);
            this.thursdayCheck.Name = "thursdayCheck";
            this.thursdayCheck.Size = new System.Drawing.Size(90, 24);
            this.thursdayCheck.TabIndex = 48;
            this.thursdayCheck.Text = "Thursday";
            this.thursdayCheck.UseVisualStyleBackColor = true;
            // 
            // fridayCheck
            // 
            this.fridayCheck.AutoSize = true;
            this.fridayCheck.Checked = true;
            this.fridayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fridayCheck.Location = new System.Drawing.Point(377, 237);
            this.fridayCheck.Name = "fridayCheck";
            this.fridayCheck.Size = new System.Drawing.Size(71, 24);
            this.fridayCheck.TabIndex = 49;
            this.fridayCheck.Text = "Friday";
            this.fridayCheck.UseVisualStyleBackColor = true;
            // 
            // saturdayCheck
            // 
            this.saturdayCheck.AutoSize = true;
            this.saturdayCheck.Location = new System.Drawing.Point(377, 267);
            this.saturdayCheck.Name = "saturdayCheck";
            this.saturdayCheck.Size = new System.Drawing.Size(89, 24);
            this.saturdayCheck.TabIndex = 50;
            this.saturdayCheck.Text = "Saturday";
            this.saturdayCheck.UseVisualStyleBackColor = true;
            this.saturdayCheck.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // tuesdayCheck
            // 
            this.tuesdayCheck.AutoSize = true;
            this.tuesdayCheck.Checked = true;
            this.tuesdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tuesdayCheck.Location = new System.Drawing.Point(377, 147);
            this.tuesdayCheck.Name = "tuesdayCheck";
            this.tuesdayCheck.Size = new System.Drawing.Size(85, 24);
            this.tuesdayCheck.TabIndex = 51;
            this.tuesdayCheck.Text = "Tuesday";
            this.tuesdayCheck.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 27);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(1969, 1, 2, 9, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(380, 379);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 27);
            this.dateTimePicker2.TabIndex = 53;
            this.dateTimePicker2.Value = new System.DateTime(1969, 1, 1, 17, 0, 0, 0);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 658);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tuesdayCheck);
            this.Controls.Add(this.saturdayCheck);
            this.Controls.Add(this.fridayCheck);
            this.Controls.Add(this.thursdayCheck);
            this.Controls.Add(this.wednesdayCheck);
            this.Controls.Add(this.mondayCheck);
            this.Controls.Add(this.sundayCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lastGenLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.viewSchedButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMenuForm";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsecutiveShiftsBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyConsultantsPerShiftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsPerShiftBox)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button genScheduleButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label busyLabel;
        private System.Windows.Forms.ListBox busyListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mixYearsCheck;
        private System.Windows.Forms.CheckBox mixMajorCheck;
        private System.Windows.Forms.CheckBox mixSemestersCheck;
        private System.Windows.Forms.NumericUpDown ConsecutiveShiftsBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lastGenLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button viewAdminButton;
        private System.Windows.Forms.Button removeAccButton;
        private System.Windows.Forms.Button addAccButton;
        private System.Windows.Forms.Button viewConsultButton;
        private System.Windows.Forms.Button viewSchedButton;
        private System.Windows.Forms.CheckBox sundayCheck;
        private System.Windows.Forms.CheckBox mondayCheck;
        private System.Windows.Forms.CheckBox wednesdayCheck;
        private System.Windows.Forms.CheckBox thursdayCheck;
        private System.Windows.Forms.CheckBox fridayCheck;
        private System.Windows.Forms.CheckBox saturdayCheck;
        private System.Windows.Forms.CheckBox tuesdayCheck;
        private System.Windows.Forms.NumericUpDown consultantsPerShiftBox;
        private System.Windows.Forms.NumericUpDown busyConsultantsPerShiftBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown shiftLengthUpDown;
    }
}