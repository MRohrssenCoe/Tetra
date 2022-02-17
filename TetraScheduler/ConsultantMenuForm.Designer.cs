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
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.majorListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnameTextbox = new System.Windows.Forms.TextBox();
            this.expNumPicker = new System.Windows.Forms.NumericUpDown();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.availSelectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expNumPicker)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Location = new System.Drawing.Point(317, 395);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(97, 40);
            this.viewScheduleButton.TabIndex = 0;
            this.viewScheduleButton.Text = "View Schedule";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            this.viewScheduleButton.Click += new System.EventHandler(this.button1_Click_1);
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
            this.groupBox3.Controls.Add(this.majorListbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lnameTextbox);
            this.groupBox3.Controls.Add(this.expNumPicker);
            this.groupBox3.Controls.Add(this.fnameTextbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 175);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Info";
            // 
            // majorListbox
            // 
            this.majorListbox.FormattingEnabled = true;
            this.majorListbox.Items.AddRange(new object[] {
            "Accounting",
            "Computer Science",
            "Physics",
            "Psychology"});
            this.majorListbox.Location = new System.Drawing.Point(6, 75);
            this.majorListbox.Name = "majorListbox";
            this.majorListbox.ScrollAlwaysVisible = true;
            this.majorListbox.Size = new System.Drawing.Size(206, 94);
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
            // expNumPicker
            // 
            this.expNumPicker.Location = new System.Drawing.Point(364, 75);
            this.expNumPicker.Name = "expNumPicker";
            this.expNumPicker.Size = new System.Drawing.Size(32, 23);
            this.expNumPicker.TabIndex = 13;
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
            this.groupBox2.Controls.Add(this.availSelectButton);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 125);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability";
            // 
            // availSelectButton
            // 
            this.availSelectButton.Location = new System.Drawing.Point(218, 44);
            this.availSelectButton.Name = "availSelectButton";
            this.availSelectButton.Size = new System.Drawing.Size(178, 37);
            this.availSelectButton.TabIndex = 21;
            this.availSelectButton.Text = "Select Availability";
            this.availSelectButton.UseVisualStyleBackColor = true;
            this.availSelectButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ConsultantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewScheduleButton);
            this.Controls.Add(this.saveInfoButton);
            this.Name = "ConsultantMenuForm";
            this.Text = "ConsultantMenuForm";
            this.Load += new System.EventHandler(this.ConsultantMenuForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expNumPicker)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button availSelectButton;
        private System.Windows.Forms.Button saveInfoButton;
    }
}