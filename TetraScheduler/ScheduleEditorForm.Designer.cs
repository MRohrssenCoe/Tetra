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
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1770, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(554, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(759, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(965, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1146, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1355, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1570, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sat_listbox
            // 
            this.sat_listbox.FormattingEnabled = true;
            this.sat_listbox.HorizontalScrollbar = true;
            this.sat_listbox.ItemHeight = 20;
            this.sat_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.sat_listbox.Location = new System.Drawing.Point(1718, 40);
            this.sat_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sat_listbox.Name = "sat_listbox";
            this.sat_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sat_listbox.Size = new System.Drawing.Size(194, 544);
            this.sat_listbox.TabIndex = 58;
            // 
            // fri_listbox
            // 
            this.fri_listbox.FormattingEnabled = true;
            this.fri_listbox.HorizontalScrollbar = true;
            this.fri_listbox.ItemHeight = 20;
            this.fri_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.fri_listbox.Location = new System.Drawing.Point(1516, 40);
            this.fri_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fri_listbox.Name = "fri_listbox";
            this.fri_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fri_listbox.Size = new System.Drawing.Size(194, 544);
            this.fri_listbox.TabIndex = 57;
            // 
            // wed_listbox
            // 
            this.wed_listbox.FormattingEnabled = true;
            this.wed_listbox.HorizontalScrollbar = true;
            this.wed_listbox.ItemHeight = 20;
            this.wed_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.wed_listbox.Location = new System.Drawing.Point(1112, 40);
            this.wed_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wed_listbox.Name = "wed_listbox";
            this.wed_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.wed_listbox.Size = new System.Drawing.Size(194, 544);
            this.wed_listbox.TabIndex = 56;
            // 
            // thurs_listbox
            // 
            this.thurs_listbox.FormattingEnabled = true;
            this.thurs_listbox.HorizontalScrollbar = true;
            this.thurs_listbox.ItemHeight = 20;
            this.thurs_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.thurs_listbox.Location = new System.Drawing.Point(1314, 40);
            this.thurs_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thurs_listbox.Name = "thurs_listbox";
            this.thurs_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.thurs_listbox.Size = new System.Drawing.Size(194, 544);
            this.thurs_listbox.TabIndex = 55;
            // 
            // tues_listbox
            // 
            this.tues_listbox.FormattingEnabled = true;
            this.tues_listbox.HorizontalScrollbar = true;
            this.tues_listbox.ItemHeight = 20;
            this.tues_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.tues_listbox.Location = new System.Drawing.Point(909, 40);
            this.tues_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tues_listbox.Name = "tues_listbox";
            this.tues_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tues_listbox.Size = new System.Drawing.Size(194, 544);
            this.tues_listbox.TabIndex = 54;
            // 
            // mon_listbox
            // 
            this.mon_listbox.FormattingEnabled = true;
            this.mon_listbox.HorizontalScrollbar = true;
            this.mon_listbox.ItemHeight = 20;
            this.mon_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.mon_listbox.Location = new System.Drawing.Point(709, 40);
            this.mon_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mon_listbox.Name = "mon_listbox";
            this.mon_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.mon_listbox.Size = new System.Drawing.Size(194, 544);
            this.mon_listbox.TabIndex = 53;
            // 
            // sun_listbox
            // 
            this.sun_listbox.FormattingEnabled = true;
            this.sun_listbox.HorizontalScrollbar = true;
            this.sun_listbox.ItemHeight = 20;
            this.sun_listbox.Items.AddRange(new object[] {
            "9AM-10AM",
            "10AM-11AM",
            "11AM-12PM",
            "12PM-1PM",
            "1PM-2PM",
            "2PM-3PM",
            "3PM-4PM",
            "4PM-5PM"});
            this.sun_listbox.Location = new System.Drawing.Point(505, 40);
            this.sun_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sun_listbox.Name = "sun_listbox";
            this.sun_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sun_listbox.Size = new System.Drawing.Size(194, 544);
            this.sun_listbox.TabIndex = 52;
            // 
            // ScheduleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 647);
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
    }
}