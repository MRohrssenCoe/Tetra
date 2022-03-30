namespace TetraScheduler
{
    partial class ScheduleEditorForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sat_listbox = new System.Windows.Forms.ListBox();
            this.fri_listbox = new System.Windows.Forms.ListBox();
            this.wed_listbox = new System.Windows.Forms.ListBox();
            this.thurs_listbox = new System.Windows.Forms.ListBox();
            this.tues_listbox = new System.Windows.Forms.ListBox();
            this.mon_listbox = new System.Windows.Forms.ListBox();
            this.sun_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeConsultantButton = new System.Windows.Forms.Button();
            this.addConsultantButton = new System.Windows.Forms.Button();
            this.consultantsWorkingShift = new System.Windows.Forms.ListBox();
            this.returnToAdminFormButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1518, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(712, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(894, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1103, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1318, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sat_listbox
            // 
            this.sat_listbox.FormattingEnabled = true;
            this.sat_listbox.HorizontalScrollbar = true;
            this.sat_listbox.ItemHeight = 20;
            this.sat_listbox.Location = new System.Drawing.Point(1465, 41);
            this.sat_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sat_listbox.Name = "sat_listbox";
            this.sat_listbox.Size = new System.Drawing.Size(194, 764);
            this.sat_listbox.TabIndex = 58;
            this.sat_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // fri_listbox
            // 
            this.fri_listbox.FormattingEnabled = true;
            this.fri_listbox.HorizontalScrollbar = true;
            this.fri_listbox.ItemHeight = 20;
            this.fri_listbox.Location = new System.Drawing.Point(1263, 41);
            this.fri_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fri_listbox.Name = "fri_listbox";
            this.fri_listbox.Size = new System.Drawing.Size(194, 764);
            this.fri_listbox.TabIndex = 57;
            this.fri_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // wed_listbox
            // 
            this.wed_listbox.FormattingEnabled = true;
            this.wed_listbox.HorizontalScrollbar = true;
            this.wed_listbox.ItemHeight = 20;
            this.wed_listbox.Location = new System.Drawing.Point(859, 41);
            this.wed_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wed_listbox.Name = "wed_listbox";
            this.wed_listbox.Size = new System.Drawing.Size(194, 764);
            this.wed_listbox.TabIndex = 56;
            this.wed_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // thurs_listbox
            // 
            this.thurs_listbox.FormattingEnabled = true;
            this.thurs_listbox.HorizontalScrollbar = true;
            this.thurs_listbox.ItemHeight = 20;
            this.thurs_listbox.Location = new System.Drawing.Point(1062, 41);
            this.thurs_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thurs_listbox.Name = "thurs_listbox";
            this.thurs_listbox.Size = new System.Drawing.Size(194, 764);
            this.thurs_listbox.TabIndex = 55;
            this.thurs_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // tues_listbox
            // 
            this.tues_listbox.FormattingEnabled = true;
            this.tues_listbox.HorizontalScrollbar = true;
            this.tues_listbox.ItemHeight = 20;
            this.tues_listbox.Location = new System.Drawing.Point(656, 41);
            this.tues_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tues_listbox.Name = "tues_listbox";
            this.tues_listbox.Size = new System.Drawing.Size(194, 764);
            this.tues_listbox.TabIndex = 54;
            this.tues_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // mon_listbox
            // 
            this.mon_listbox.FormattingEnabled = true;
            this.mon_listbox.HorizontalScrollbar = true;
            this.mon_listbox.ItemHeight = 20;
            this.mon_listbox.Location = new System.Drawing.Point(456, 41);
            this.mon_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mon_listbox.Name = "mon_listbox";
            this.mon_listbox.Size = new System.Drawing.Size(194, 764);
            this.mon_listbox.TabIndex = 53;
            this.mon_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // sun_listbox
            // 
            this.sun_listbox.FormattingEnabled = true;
            this.sun_listbox.HorizontalScrollbar = true;
            this.sun_listbox.ItemHeight = 20;
            this.sun_listbox.Location = new System.Drawing.Point(253, 41);
            this.sun_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sun_listbox.Name = "sun_listbox";
            this.sun_listbox.Size = new System.Drawing.Size(194, 764);
            this.sun_listbox.TabIndex = 52;
            this.sun_listbox.Click += new System.EventHandler(this.listbox_ItemChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeConsultantButton);
            this.groupBox1.Controls.Add(this.addConsultantButton);
            this.groupBox1.Controls.Add(this.consultantsWorkingShift);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(237, 277);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Settings";
            // 
            // removeConsultantButton
            // 
            this.removeConsultantButton.Location = new System.Drawing.Point(7, 220);
            this.removeConsultantButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeConsultantButton.Name = "removeConsultantButton";
            this.removeConsultantButton.Size = new System.Drawing.Size(223, 47);
            this.removeConsultantButton.TabIndex = 2;
            this.removeConsultantButton.Text = "Remove Consultant";
            this.removeConsultantButton.UseVisualStyleBackColor = true;
            this.removeConsultantButton.Click += new System.EventHandler(this.removeUserFromSelected);
            // 
            // addConsultantButton
            // 
            this.addConsultantButton.Location = new System.Drawing.Point(7, 165);
            this.addConsultantButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addConsultantButton.Name = "addConsultantButton";
            this.addConsultantButton.Size = new System.Drawing.Size(223, 47);
            this.addConsultantButton.TabIndex = 1;
            this.addConsultantButton.Text = "Add consultant";
            this.addConsultantButton.UseVisualStyleBackColor = true;
            this.addConsultantButton.Click += new System.EventHandler(this.addUserToSelected);
            // 
            // consultantsWorkingShift
            // 
            this.consultantsWorkingShift.FormattingEnabled = true;
            this.consultantsWorkingShift.ItemHeight = 20;
            this.consultantsWorkingShift.Location = new System.Drawing.Point(10, 32);
            this.consultantsWorkingShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.consultantsWorkingShift.Name = "consultantsWorkingShift";
            this.consultantsWorkingShift.Size = new System.Drawing.Size(219, 124);
            this.consultantsWorkingShift.TabIndex = 0;
            // 
            // returnToAdminFormButton
            // 
            this.returnToAdminFormButton.Location = new System.Drawing.Point(16, 760);
            this.returnToAdminFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnToAdminFormButton.Name = "returnToAdminFormButton";
            this.returnToAdminFormButton.Size = new System.Drawing.Size(223, 47);
            this.returnToAdminFormButton.TabIndex = 3;
            this.returnToAdminFormButton.Text = "Return to Admin Menu";
            this.returnToAdminFormButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 47);
            this.button1.TabIndex = 60;
            this.button1.Text = "Save Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 823);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnToAdminFormButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sat_listbox);
            this.Controls.Add(this.fri_listbox);
            this.Controls.Add(this.wed_listbox);
            this.Controls.Add(this.thurs_listbox);
            this.Controls.Add(this.tues_listbox);
            this.Controls.Add(this.mon_listbox);
            this.Controls.Add(this.sun_listbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleEditorForm";
            this.Text = "ScheduleEditorForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox sat_listbox;
        private System.Windows.Forms.ListBox fri_listbox;
        private System.Windows.Forms.ListBox wed_listbox;
        private System.Windows.Forms.ListBox thurs_listbox;
        private System.Windows.Forms.ListBox tues_listbox;
        private System.Windows.Forms.ListBox mon_listbox;
        private System.Windows.Forms.ListBox sun_listbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeConsultantButton;
        private System.Windows.Forms.Button addConsultantButton;
        private System.Windows.Forms.ListBox consultantsWorkingShift;
        private System.Windows.Forms.Button returnToAdminFormButton;
        private System.Windows.Forms.Button button1;
    }
}