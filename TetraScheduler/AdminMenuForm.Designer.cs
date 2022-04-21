
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mixYearsCheck = new System.Windows.Forms.CheckBox();
            this.mixMajorCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mixSemestersCheck = new System.Windows.Forms.CheckBox();
            this.shiftLengthUpDn = new System.Windows.Forms.NumericUpDown();
            this.consultantsNeededUpDn = new System.Windows.Forms.NumericUpDown();
            this.busyConsultantsUpDn = new System.Windows.Forms.NumericUpDown();
            this.consecutiveShiftsUpDn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.busyListBox = new System.Windows.Forms.ListBox();
            this.busyLabel = new System.Windows.Forms.Label();
            this.selectBusyShiftsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.editScheduleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.lastGenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.removeAccountButton = new System.Windows.Forms.Button();
            this.viewAdminButton = new System.Windows.Forms.Button();
            this.addAccButton = new System.Windows.Forms.Button();
            this.viewConsultButton = new System.Windows.Forms.Button();
            this.AddMajorButton = new System.Windows.Forms.Button();
            this.removeAccButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewSchedButton = new System.Windows.Forms.Button();
            this.sundayCheck = new System.Windows.Forms.CheckBox();
            this.mondayCheck = new System.Windows.Forms.CheckBox();
            this.wednesdayCheck = new System.Windows.Forms.CheckBox();
            this.thursdayCheck = new System.Windows.Forms.CheckBox();
            this.fridayCheck = new System.Windows.Forms.CheckBox();
            this.saturdayCheck = new System.Windows.Forms.CheckBox();
            this.tuesdayCheck = new System.Windows.Forms.CheckBox();
            this.openTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.daysbox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLengthUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsNeededUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyConsultantsUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveShiftsUpDn)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(192, 30);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, [name]!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save Admin Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mixYearsCheck);
            this.panel1.Controls.Add(this.mixMajorCheck);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mixSemestersCheck);
            this.panel1.Controls.Add(this.shiftLengthUpDn);
            this.panel1.Controls.Add(this.consultantsNeededUpDn);
            this.panel1.Controls.Add(this.busyConsultantsUpDn);
            this.panel1.Controls.Add(this.consecutiveShiftsUpDn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.busyListBox);
            this.panel1.Controls.Add(this.busyLabel);
            this.panel1.Controls.Add(this.selectBusyShiftsButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(10, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 429);
            this.panel1.TabIndex = 12;
            // 
            // mixYearsCheck
            // 
            this.mixYearsCheck.AutoSize = true;
            this.mixYearsCheck.Location = new System.Drawing.Point(36, 191);
            this.mixYearsCheck.Name = "mixYearsCheck";
            this.mixYearsCheck.Size = new System.Drawing.Size(128, 19);
            this.mixYearsCheck.TabIndex = 63;
            this.mixYearsCheck.Text = "Mix of school years";
            this.mixYearsCheck.UseVisualStyleBackColor = true;
            // 
            // mixMajorCheck
            // 
            this.mixMajorCheck.AutoSize = true;
            this.mixMajorCheck.Location = new System.Drawing.Point(36, 170);
            this.mixMajorCheck.Name = "mixMajorCheck";
            this.mixMajorCheck.Size = new System.Drawing.Size(99, 19);
            this.mixMajorCheck.TabIndex = 62;
            this.mixMajorCheck.Text = "Mix of majors";
            this.mixMajorCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 72;
            this.label8.Text = "Shift length in Minutes";
            // 
            // mixSemestersCheck
            // 
            this.mixSemestersCheck.AutoSize = true;
            this.mixSemestersCheck.Location = new System.Drawing.Point(36, 211);
            this.mixSemestersCheck.Name = "mixSemestersCheck";
            this.mixSemestersCheck.Size = new System.Drawing.Size(189, 19);
            this.mixSemestersCheck.TabIndex = 64;
            this.mixSemestersCheck.Text = "Mix of semesters of experience";
            this.mixSemestersCheck.UseVisualStyleBackColor = true;
            // 
            // shiftLengthUpDn
            // 
            this.shiftLengthUpDn.Location = new System.Drawing.Point(240, 320);
            this.shiftLengthUpDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shiftLengthUpDn.Name = "shiftLengthUpDn";
            this.shiftLengthUpDn.Size = new System.Drawing.Size(37, 23);
            this.shiftLengthUpDn.TabIndex = 71;
            this.shiftLengthUpDn.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // consultantsNeededUpDn
            // 
            this.consultantsNeededUpDn.Location = new System.Drawing.Point(240, 268);
            this.consultantsNeededUpDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultantsNeededUpDn.Name = "consultantsNeededUpDn";
            this.consultantsNeededUpDn.Size = new System.Drawing.Size(37, 23);
            this.consultantsNeededUpDn.TabIndex = 67;
            this.consultantsNeededUpDn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // busyConsultantsUpDn
            // 
            this.busyConsultantsUpDn.Location = new System.Drawing.Point(240, 295);
            this.busyConsultantsUpDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.busyConsultantsUpDn.Name = "busyConsultantsUpDn";
            this.busyConsultantsUpDn.Size = new System.Drawing.Size(37, 23);
            this.busyConsultantsUpDn.TabIndex = 68;
            this.busyConsultantsUpDn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // consecutiveShiftsUpDn
            // 
            this.consecutiveShiftsUpDn.Location = new System.Drawing.Point(240, 243);
            this.consecutiveShiftsUpDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consecutiveShiftsUpDn.Name = "consecutiveShiftsUpDn";
            this.consecutiveShiftsUpDn.Size = new System.Drawing.Size(37, 23);
            this.consecutiveShiftsUpDn.TabIndex = 65;
            this.consecutiveShiftsUpDn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 70;
            this.label5.Text = "Consultants per busy shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Max num. of consecutive shifts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "Consultants per shift";
            // 
            // busyListBox
            // 
            this.busyListBox.FormattingEnabled = true;
            this.busyListBox.ItemHeight = 15;
            this.busyListBox.Location = new System.Drawing.Point(36, 25);
            this.busyListBox.Name = "busyListBox";
            this.busyListBox.Size = new System.Drawing.Size(242, 109);
            this.busyListBox.TabIndex = 59;
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(117, 7);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(64, 15);
            this.busyLabel.TabIndex = 60;
            this.busyLabel.Text = "Busy Shifts";
            // 
            // selectBusyShiftsButton
            // 
            this.selectBusyShiftsButton.Location = new System.Drawing.Point(91, 139);
            this.selectBusyShiftsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBusyShiftsButton.Name = "selectBusyShiftsButton";
            this.selectBusyShiftsButton.Size = new System.Drawing.Size(128, 22);
            this.selectBusyShiftsButton.TabIndex = 61;
            this.selectBusyShiftsButton.Text = "Select Busy Shifts";
            this.selectBusyShiftsButton.UseVisualStyleBackColor = true;
            this.selectBusyShiftsButton.Click += new System.EventHandler(this.selectBusyShiftsClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 32);
            this.button2.TabIndex = 58;
            this.button2.Text = "Generate Schedule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.genScheduleButton_Click);
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Location = new System.Drawing.Point(340, 430);
            this.editScheduleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(150, 32);
            this.editScheduleButton.TabIndex = 54;
            this.editScheduleButton.Text = "Edit Schedule";
            this.editScheduleButton.UseVisualStyleBackColor = true;
            this.editScheduleButton.Click += new System.EventHandler(this.editScheduleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Open Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Close Time";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(674, 430);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 32);
            this.logoutButton.TabIndex = 44;
            this.logoutButton.Text = "Close Menu";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // lastGenLabel
            // 
            this.lastGenLabel.AutoSize = true;
            this.lastGenLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastGenLabel.Location = new System.Drawing.Point(496, 400);
            this.lastGenLabel.Name = "lastGenLabel";
            this.lastGenLabel.Size = new System.Drawing.Size(112, 15);
            this.lastGenLabel.TabIndex = 41;
            this.lastGenLabel.Text = "Last generated: N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(705, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Account Tools";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.button5);
            this.panel10.Controls.Add(this.removeAccountButton);
            this.panel10.Controls.Add(this.viewAdminButton);
            this.panel10.Controls.Add(this.addAccButton);
            this.panel10.Controls.Add(this.viewConsultButton);
            this.panel10.Location = new System.Drawing.Point(664, 47);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(162, 211);
            this.panel10.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Mass Add Consultants";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.Location = new System.Drawing.Point(4, 129);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Size = new System.Drawing.Size(153, 37);
            this.removeAccountButton.TabIndex = 6;
            this.removeAccountButton.Text = "Remove Account";
            this.removeAccountButton.UseVisualStyleBackColor = true;
            // 
            // viewAdminButton
            // 
            this.viewAdminButton.Location = new System.Drawing.Point(3, 45);
            this.viewAdminButton.Name = "viewAdminButton";
            this.viewAdminButton.Size = new System.Drawing.Size(153, 37);
            this.viewAdminButton.TabIndex = 5;
            this.viewAdminButton.Text = "Change User Access Level";
            this.viewAdminButton.UseVisualStyleBackColor = true;
            this.viewAdminButton.Click += new System.EventHandler(this.viewAdminButton_Click);
            // 
            // addAccButton
            // 
            this.addAccButton.Location = new System.Drawing.Point(3, 88);
            this.addAccButton.Name = "addAccButton";
            this.addAccButton.Size = new System.Drawing.Size(153, 37);
            this.addAccButton.TabIndex = 3;
            this.addAccButton.Text = "Add Account";
            this.addAccButton.UseVisualStyleBackColor = true;
            this.addAccButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // viewConsultButton
            // 
            this.viewConsultButton.Location = new System.Drawing.Point(4, 2);
            this.viewConsultButton.Name = "viewConsultButton";
            this.viewConsultButton.Size = new System.Drawing.Size(153, 37);
            this.viewConsultButton.TabIndex = 2;
            this.viewConsultButton.Text = "View Consultant Info";
            this.viewConsultButton.UseVisualStyleBackColor = true;
            this.viewConsultButton.Click += new System.EventHandler(this.viewConsultButton_Click);
            // 
            // AddMajorButton
            // 
            this.AddMajorButton.Location = new System.Drawing.Point(669, 263);
            this.AddMajorButton.Name = "AddMajorButton";
            this.AddMajorButton.Size = new System.Drawing.Size(153, 37);
            this.AddMajorButton.TabIndex = 8;
            this.AddMajorButton.Text = "Change Available Majors";
            this.AddMajorButton.UseVisualStyleBackColor = true;
            this.AddMajorButton.Click += new System.EventHandler(this.AddMajorButton_Click);
            // 
            // removeAccButton
            // 
            this.removeAccButton.Location = new System.Drawing.Point(3, 132);
            this.removeAccButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeAccButton.Name = "removeAccButton";
            this.removeAccButton.Size = new System.Drawing.Size(153, 37);
            this.removeAccButton.TabIndex = 4;
            this.removeAccButton.Text = "Remove Account";
            this.removeAccButton.UseVisualStyleBackColor = true;
            this.removeAccButton.Click += new System.EventHandler(this.removeAccButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 33);
            this.button1.TabIndex = 54;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewSchedButton
            // 
            this.viewSchedButton.Location = new System.Drawing.Point(496, 430);
            this.viewSchedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewSchedButton.Name = "viewSchedButton";
            this.viewSchedButton.Size = new System.Drawing.Size(150, 32);
            this.viewSchedButton.TabIndex = 40;
            this.viewSchedButton.Text = "View Current Schedule";
            this.viewSchedButton.UseVisualStyleBackColor = true;
            this.viewSchedButton.Click += new System.EventHandler(this.viewSchedButton_Click);
            // 
            // sundayCheck
            // 
            this.sundayCheck.AutoSize = true;
            this.sundayCheck.Location = new System.Drawing.Point(209, 8);
            this.sundayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sundayCheck.Name = "sundayCheck";
            this.sundayCheck.Size = new System.Drawing.Size(65, 19);
            this.sundayCheck.TabIndex = 45;
            this.sundayCheck.Text = "Sunday";
            this.sundayCheck.UseVisualStyleBackColor = true;
            this.sundayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // mondayCheck
            // 
            this.mondayCheck.AutoSize = true;
            this.mondayCheck.Checked = true;
            this.mondayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mondayCheck.Location = new System.Drawing.Point(209, 25);
            this.mondayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mondayCheck.Name = "mondayCheck";
            this.mondayCheck.Size = new System.Drawing.Size(70, 19);
            this.mondayCheck.TabIndex = 46;
            this.mondayCheck.Text = "Monday";
            this.mondayCheck.UseVisualStyleBackColor = true;
            this.mondayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // wednesdayCheck
            // 
            this.wednesdayCheck.AutoSize = true;
            this.wednesdayCheck.Checked = true;
            this.wednesdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wednesdayCheck.Location = new System.Drawing.Point(209, 59);
            this.wednesdayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wednesdayCheck.Name = "wednesdayCheck";
            this.wednesdayCheck.Size = new System.Drawing.Size(87, 19);
            this.wednesdayCheck.TabIndex = 47;
            this.wednesdayCheck.Text = "Wednesday";
            this.wednesdayCheck.UseVisualStyleBackColor = true;
            this.wednesdayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // thursdayCheck
            // 
            this.thursdayCheck.AutoSize = true;
            this.thursdayCheck.Checked = true;
            this.thursdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thursdayCheck.Location = new System.Drawing.Point(209, 76);
            this.thursdayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thursdayCheck.Name = "thursdayCheck";
            this.thursdayCheck.Size = new System.Drawing.Size(74, 19);
            this.thursdayCheck.TabIndex = 48;
            this.thursdayCheck.Text = "Thursday";
            this.thursdayCheck.UseVisualStyleBackColor = true;
            this.thursdayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // fridayCheck
            // 
            this.fridayCheck.AutoSize = true;
            this.fridayCheck.Checked = true;
            this.fridayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fridayCheck.Location = new System.Drawing.Point(209, 93);
            this.fridayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fridayCheck.Name = "fridayCheck";
            this.fridayCheck.Size = new System.Drawing.Size(58, 19);
            this.fridayCheck.TabIndex = 49;
            this.fridayCheck.Text = "Friday";
            this.fridayCheck.UseVisualStyleBackColor = true;
            this.fridayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // saturdayCheck
            // 
            this.saturdayCheck.AutoSize = true;
            this.saturdayCheck.Location = new System.Drawing.Point(209, 112);
            this.saturdayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saturdayCheck.Name = "saturdayCheck";
            this.saturdayCheck.Size = new System.Drawing.Size(72, 19);
            this.saturdayCheck.TabIndex = 50;
            this.saturdayCheck.Text = "Saturday";
            this.saturdayCheck.UseVisualStyleBackColor = true;
            this.saturdayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // tuesdayCheck
            // 
            this.tuesdayCheck.AutoSize = true;
            this.tuesdayCheck.Checked = true;
            this.tuesdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tuesdayCheck.Location = new System.Drawing.Point(209, 42);
            this.tuesdayCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuesdayCheck.Name = "tuesdayCheck";
            this.tuesdayCheck.Size = new System.Drawing.Size(69, 19);
            this.tuesdayCheck.TabIndex = 51;
            this.tuesdayCheck.Text = "Tuesday";
            this.tuesdayCheck.UseVisualStyleBackColor = true;
            this.tuesdayCheck.CheckedChanged += new System.EventHandler(this.toggleDaysOnOff);
            // 
            // openTimePicker
            // 
            this.openTimePicker.CustomFormat = "hh:mm tt";
            this.openTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.openTimePicker.Location = new System.Drawing.Point(12, 139);
            this.openTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openTimePicker.Name = "openTimePicker";
            this.openTimePicker.ShowUpDown = true;
            this.openTimePicker.Size = new System.Drawing.Size(92, 23);
            this.openTimePicker.TabIndex = 52;
            this.openTimePicker.Value = new System.DateTime(1969, 1, 2, 9, 0, 0, 0);
            this.openTimePicker.ValueChanged += new System.EventHandler(this.handle_TimePickUpdate);
            // 
            // closeTimePicker
            // 
            this.closeTimePicker.CustomFormat = "hh:mm tt";
            this.closeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.closeTimePicker.Location = new System.Drawing.Point(121, 139);
            this.closeTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeTimePicker.Name = "closeTimePicker";
            this.closeTimePicker.ShowUpDown = true;
            this.closeTimePicker.Size = new System.Drawing.Size(92, 23);
            this.closeTimePicker.TabIndex = 53;
            this.closeTimePicker.Value = new System.DateTime(1969, 1, 1, 17, 0, 0, 0);
            this.closeTimePicker.ValueChanged += new System.EventHandler(this.handle_TimePickUpdate);
            // 
            // daysbox
            // 
            this.daysbox.FormattingEnabled = true;
            this.daysbox.ItemHeight = 15;
            this.daysbox.Location = new System.Drawing.Point(12, 8);
            this.daysbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysbox.Name = "daysbox";
            this.daysbox.Size = new System.Drawing.Size(191, 109);
            this.daysbox.TabIndex = 54;
            this.daysbox.SelectedIndexChanged += new System.EventHandler(this.handle_DayClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(353, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Open Times";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.daysbox);
            this.panel2.Controls.Add(this.thursdayCheck);
            this.panel2.Controls.Add(this.fridayCheck);
            this.panel2.Controls.Add(this.sundayCheck);
            this.panel2.Controls.Add(this.wednesdayCheck);
            this.panel2.Controls.Add(this.closeTimePicker);
            this.panel2.Controls.Add(this.saturdayCheck);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.mondayCheck);
            this.panel2.Controls.Add(this.tuesdayCheck);
            this.panel2.Controls.Add(this.openTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(340, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 190);
            this.panel2.TabIndex = 56;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 485);
            this.Controls.Add(this.AddMajorButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.editScheduleButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.lastGenLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.viewSchedButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMenuForm";
            this.Text = "Tetra Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLengthUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsNeededUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyConsultantsUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveShiftsUpDn)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button logoutButton;
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
        private System.Windows.Forms.DateTimePicker openTimePicker;
        private System.Windows.Forms.DateTimePicker closeTimePicker;
        private System.Windows.Forms.Button editScheduleButton;
        private System.Windows.Forms.ListBox daysbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeAccountButton;
        private System.Windows.Forms.CheckBox mixYearsCheck;
        private System.Windows.Forms.CheckBox mixMajorCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox mixSemestersCheck;
        private System.Windows.Forms.NumericUpDown shiftLengthUpDn;
        private System.Windows.Forms.NumericUpDown consultantsNeededUpDn;
        private System.Windows.Forms.NumericUpDown busyConsultantsUpDn;
        private System.Windows.Forms.NumericUpDown consecutiveShiftsUpDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox busyListBox;
        private System.Windows.Forms.Label busyLabel;
        private System.Windows.Forms.Button selectBusyShiftsButton;
        private System.Windows.Forms.Button AddMajorButton;
        private System.Windows.Forms.Button button5;
    }
}