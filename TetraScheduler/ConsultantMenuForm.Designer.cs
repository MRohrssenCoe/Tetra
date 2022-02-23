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
            this.button2 = new System.Windows.Forms.Button();
            this.availabilityBox = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHrsPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeYrPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expSemPicker)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(12, 398);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(97, 37);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 175);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Desired Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year at Coe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // weeklyHrsPicker
            // 
            this.weeklyHrsPicker.Location = new System.Drawing.Point(363, 128);
            this.weeklyHrsPicker.Name = "weeklyHrsPicker";
            this.weeklyHrsPicker.Size = new System.Drawing.Size(33, 23);
            this.weeklyHrsPicker.TabIndex = 20;
            // 
            // coeYrPicker
            // 
            this.coeYrPicker.Location = new System.Drawing.Point(363, 101);
            this.coeYrPicker.Name = "coeYrPicker";
            this.coeYrPicker.Size = new System.Drawing.Size(32, 23);
            this.coeYrPicker.TabIndex = 19;
            // 
            // majorListbox
            // 
            this.majorListbox.FormattingEnabled = true;
            this.majorListbox.Items.AddRange(new object[] {
            "Business administration and management",
            "Biology/biological sciences",
            "Psychology",
            "Neuroscience",
            "Registered nursing/registered nurse",
            "Computer science",
            "Physics",
            "Economics",
            "Political science and government",
            "Mathematics",
            "Accounting",
            "Kinesiology and exercise science",
            "Chemistry",
            "Art/art studies",
            "Asian studies/civilization",
            "Speech communication and rhetoric",
            "Public relations, advertising, and applied communication",
            "Elementary education and teaching",
            "Music1",
            "Film/cinema/video studies",
            "English language and literature",
            "Creative writing",
            "Molecular biology",
            "International business/trade/commerce",
            "History",
            "Sociology",
            "Environmental science",
            "Spanish language and literature",
            "Athletic training/trainer",
            "Environmental studies",
            "International/global studies",
            "Criminal justice/safety studies",
            "International economics",
            "Drama and dramatics/theatre arts",
            "Organizational behavior studies",
            "African-american/black studies",
            "French language and literature",
            "Rhetoric and composition",
            "Biochemistry",
            "Philosophy",
            "Religion/religious studies",
            "German language and literature",
            "Physical sciences"});
            this.majorListbox.Location = new System.Drawing.Point(6, 75);
            this.majorListbox.Name = "majorListbox";
            this.majorListbox.Size = new System.Drawing.Size(206, 76);
            this.majorListbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Semesters of Experience";
            // 
            // lnameTextbox
            // 
            this.lnameTextbox.Location = new System.Drawing.Point(218, 22);
            this.lnameTextbox.Name = "lnameTextbox";
            this.lnameTextbox.Size = new System.Drawing.Size(178, 23);
            this.lnameTextbox.TabIndex = 12;
            // 
            // expSemPicker
            // 
            this.expSemPicker.Location = new System.Drawing.Point(364, 75);
            this.expSemPicker.Name = "expSemPicker";
            this.expSemPicker.Size = new System.Drawing.Size(32, 23);
            this.expSemPicker.TabIndex = 13;
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Location = new System.Drawing.Point(6, 22);
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(206, 23);
            this.fnameTextbox.TabIndex = 11;
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
            this.groupBox2.Controls.Add(this.availabilityBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 174);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Select Availability";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // ConsultantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveInfoButton);
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