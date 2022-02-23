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
            this.button1 = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weeklyHrsPicker = new System.Windows.Forms.NumericUpDown();
            this.coeYrPicker = new System.Windows.Forms.NumericUpDown();
            this.majorListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnameTextbox = new System.Windows.Forms.TextBox();
            this.expSemPicker = new System.Windows.Forms.NumericUpDown();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.availabilityBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHrsPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeYrPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expSemPicker)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewScheduleButtonClick);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(14, 531);
            this.saveInfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(111, 49);
            this.saveInfoButton.TabIndex = 17;
            this.saveInfoButton.Text = "Save Info";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.weeklyHrsPicker);
            this.groupBox3.Controls.Add(this.coeYrPicker);
            this.groupBox3.Controls.Add(this.majorListbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lnameTextbox);
            this.groupBox3.Controls.Add(this.expSemPicker);
            this.groupBox3.Controls.Add(this.fnameTextbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(14, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(459, 233);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Desired Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year at Coe";
            // 
            // weeklyHrsPicker
            // 
            this.weeklyHrsPicker.Location = new System.Drawing.Point(415, 171);
            this.weeklyHrsPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weeklyHrsPicker.Name = "weeklyHrsPicker";
            this.weeklyHrsPicker.Size = new System.Drawing.Size(38, 27);
            this.weeklyHrsPicker.TabIndex = 20;
            // 
            // coeYrPicker
            // 
            this.coeYrPicker.Location = new System.Drawing.Point(415, 135);
            this.coeYrPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coeYrPicker.Name = "coeYrPicker";
            this.coeYrPicker.Size = new System.Drawing.Size(37, 27);
            this.coeYrPicker.TabIndex = 19;
            // 
            // majorListbox
            // 
            this.majorListbox.FormattingEnabled = true;
            this.majorListbox.Items.AddRange(new object[] {
            "Accounting",
            "African American Studies",
            "American Studies",
            "Art",
            "Art History",
            "Asian Studies",
            "Biochemistry",
            "Biolgy",
            "Business Administration",
            "Chemistry",
            "Communication Studies",
            "Computer Science",
            "Creative Writing",
            "Data Science",
            "Economics",
            "Education",
            "English",
            "ESL",
            "Environmental Science",
            "Environmental Studies",
            "Film Studies",
            "French",
            "French Studies",
            "General Science",
            "History",
            "Interdisciplinary Studies",
            "International Business",
            "International Economics",
            "International Studies",
            "Kinesiology",
            "Literature",
            "Mathematics",
            "Molecular Biology",
            "Music",
            "Neuroscience",
            "Nursing",
            "Organizational Science",
            "Philosophy",
            "Physics",
            "Political Science",
            "Psychology",
            "Public Relations",
            "Religion",
            "ROTC",
            "Social & Criminal Justice",
            "Sociology",
            "Spanish",
            "Spanish Studies",
            "Theatre Arts",
            "Writing",
            "Pre-Actuarial Science",
            "Pre-Architecture",
            "Pre-Athletic Training",
            "Pre-Dental",
            "Pre-Engineering",
            "Pre-Law",
            "Pre-Med",
            "Pre-Pharmacy",
            "Pre-Physical Therapy",
            "Pre-Physician Assistant",
            "Pre-Podiatry",
            "Pre-Public Health",
            "Pre-Veterinary",
            "Pre-Music Therapy"});
            this.majorListbox.Location = new System.Drawing.Point(7, 100);
            this.majorListbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.majorListbox.Name = "majorListbox";
            this.majorListbox.Size = new System.Drawing.Size(235, 92);
            this.majorListbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Semesters of Experience";
            // 
            // lnameTextbox
            // 
            this.lnameTextbox.Location = new System.Drawing.Point(249, 29);
            this.lnameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnameTextbox.Name = "lnameTextbox";
            this.lnameTextbox.Size = new System.Drawing.Size(203, 27);
            this.lnameTextbox.TabIndex = 12;
            // 
            // expSemPicker
            // 
            this.expSemPicker.Location = new System.Drawing.Point(416, 100);
            this.expSemPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expSemPicker.Name = "expSemPicker";
            this.expSemPicker.Size = new System.Drawing.Size(37, 27);
            this.expSemPicker.TabIndex = 13;
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Location = new System.Drawing.Point(7, 29);
            this.fnameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(235, 27);
            this.fnameTextbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Major";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.availabilityBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(14, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(459, 232);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability";
            // 
            // availabilityBox
            // 
            this.availabilityBox.FormattingEnabled = true;
            this.availabilityBox.ItemHeight = 20;
            this.availabilityBox.Location = new System.Drawing.Point(8, 31);
            this.availabilityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.availabilityBox.Name = "availabilityBox";
            this.availabilityBox.Size = new System.Drawing.Size(234, 184);
            this.availabilityBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "Select Availability";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SelectAvailabilityButtonClick);
            // 
            // ConsultantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveInfoButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultantMenuForm";
            this.Text = "ConsultantMenuForm";
            this.Load += new System.EventHandler(this.ConsultantMenuForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHrsPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeYrPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expSemPicker)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown weeklyHrsPicker;
        private System.Windows.Forms.NumericUpDown coeYrPicker;
        private System.Windows.Forms.NumericUpDown expSemPicker;
        private System.Windows.Forms.ListBox availabilityBox;
    }
}