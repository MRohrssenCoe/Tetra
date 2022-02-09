
namespace TetraScheduler
{
    partial class ScheduleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sat_listbox = new System.Windows.Forms.ListBox();
            this.fri_listbox = new System.Windows.Forms.ListBox();
            this.wed_listbox = new System.Windows.Forms.ListBox();
            this.thurs_listbox = new System.Windows.Forms.ListBox();
            this.tues_listbox = new System.Windows.Forms.ListBox();
            this.mon_listbox = new System.Windows.Forms.ListBox();
            this.sun_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sun_hour_label = new System.Windows.Forms.Label();
            this.mon_hour_label = new System.Windows.Forms.Label();
            this.tues_hour_label = new System.Windows.Forms.Label();
            this.thurs_hour_label = new System.Windows.Forms.Label();
            this.fri_hour_label = new System.Windows.Forms.Label();
            this.sat_hour_label = new System.Windows.Forms.Label();
            this.wed_hour_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export as CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sat_listbox);
            this.panel1.Controls.Add(this.fri_listbox);
            this.panel1.Controls.Add(this.wed_listbox);
            this.panel1.Controls.Add(this.thurs_listbox);
            this.panel1.Controls.Add(this.tues_listbox);
            this.panel1.Controls.Add(this.mon_listbox);
            this.panel1.Controls.Add(this.sun_listbox);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 461);
            this.panel1.TabIndex = 1;
            // 
            // sat_listbox
            // 
            this.sat_listbox.FormattingEnabled = true;
            this.sat_listbox.ItemHeight = 15;
            this.sat_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.sat_listbox.Location = new System.Drawing.Point(1074, 3);
            this.sat_listbox.Name = "sat_listbox";
            this.sat_listbox.Size = new System.Drawing.Size(170, 454);
            this.sat_listbox.TabIndex = 6;
            // 
            // fri_listbox
            // 
            this.fri_listbox.FormattingEnabled = true;
            this.fri_listbox.ItemHeight = 15;
            this.fri_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.fri_listbox.Location = new System.Drawing.Point(897, 3);
            this.fri_listbox.Name = "fri_listbox";
            this.fri_listbox.Size = new System.Drawing.Size(170, 454);
            this.fri_listbox.TabIndex = 5;
            // 
            // wed_listbox
            // 
            this.wed_listbox.FormattingEnabled = true;
            this.wed_listbox.ItemHeight = 15;
            this.wed_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.wed_listbox.Location = new System.Drawing.Point(543, 3);
            this.wed_listbox.Name = "wed_listbox";
            this.wed_listbox.Size = new System.Drawing.Size(170, 454);
            this.wed_listbox.TabIndex = 4;
            // 
            // thurs_listbox
            // 
            this.thurs_listbox.FormattingEnabled = true;
            this.thurs_listbox.ItemHeight = 15;
            this.thurs_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.thurs_listbox.Location = new System.Drawing.Point(720, 3);
            this.thurs_listbox.Name = "thurs_listbox";
            this.thurs_listbox.Size = new System.Drawing.Size(170, 454);
            this.thurs_listbox.TabIndex = 3;
            // 
            // tues_listbox
            // 
            this.tues_listbox.FormattingEnabled = true;
            this.tues_listbox.ItemHeight = 15;
            this.tues_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.tues_listbox.Location = new System.Drawing.Point(366, 3);
            this.tues_listbox.Name = "tues_listbox";
            this.tues_listbox.Size = new System.Drawing.Size(170, 454);
            this.tues_listbox.TabIndex = 2;
            // 
            // mon_listbox
            // 
            this.mon_listbox.FormattingEnabled = true;
            this.mon_listbox.ItemHeight = 15;
            this.mon_listbox.Items.AddRange(new object[] {
            "No Shifts"});
            this.mon_listbox.Location = new System.Drawing.Point(189, 3);
            this.mon_listbox.Name = "mon_listbox";
            this.mon_listbox.Size = new System.Drawing.Size(170, 454);
            this.mon_listbox.TabIndex = 1;
            // 
            // sun_listbox
            // 
            this.sun_listbox.ColumnWidth = 10;
            this.sun_listbox.FormattingEnabled = true;
            this.sun_listbox.ItemHeight = 15;
            this.sun_listbox.Items.AddRange(new object[] {
            "No Shifts",
            "Test"});
            this.sun_listbox.Location = new System.Drawing.Point(12, 3);
            this.sun_listbox.MultiColumn = true;
            this.sun_listbox.Name = "sun_listbox";
            this.sun_listbox.Size = new System.Drawing.Size(170, 454);
            this.sun_listbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(427, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(585, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(768, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(954, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1119, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sun_hour_label
            // 
            this.sun_hour_label.AutoSize = true;
            this.sun_hour_label.Location = new System.Drawing.Point(60, 53);
            this.sun_hour_label.Name = "sun_hour_label";
            this.sun_hour_label.Size = new System.Drawing.Size(84, 15);
            this.sun_hour_label.TabIndex = 28;
            this.sun_hour_label.Text = "Put hours here";
            // 
            // mon_hour_label
            // 
            this.mon_hour_label.AutoSize = true;
            this.mon_hour_label.Location = new System.Drawing.Point(241, 53);
            this.mon_hour_label.Name = "mon_hour_label";
            this.mon_hour_label.Size = new System.Drawing.Size(84, 15);
            this.mon_hour_label.TabIndex = 29;
            this.mon_hour_label.Text = "Put hours here";
            // 
            // tues_hour_label
            // 
            this.tues_hour_label.AutoSize = true;
            this.tues_hour_label.Location = new System.Drawing.Point(421, 53);
            this.tues_hour_label.Name = "tues_hour_label";
            this.tues_hour_label.Size = new System.Drawing.Size(84, 15);
            this.tues_hour_label.TabIndex = 30;
            this.tues_hour_label.Text = "Put hours here";
            // 
            // thurs_hour_label
            // 
            this.thurs_hour_label.AutoSize = true;
            this.thurs_hour_label.Location = new System.Drawing.Point(766, 53);
            this.thurs_hour_label.Name = "thurs_hour_label";
            this.thurs_hour_label.Size = new System.Drawing.Size(84, 15);
            this.thurs_hour_label.TabIndex = 32;
            this.thurs_hour_label.Text = "Put hours here";
            // 
            // fri_hour_label
            // 
            this.fri_hour_label.AutoSize = true;
            this.fri_hour_label.Location = new System.Drawing.Point(940, 53);
            this.fri_hour_label.Name = "fri_hour_label";
            this.fri_hour_label.Size = new System.Drawing.Size(84, 15);
            this.fri_hour_label.TabIndex = 33;
            this.fri_hour_label.Text = "Put hours here";
            // 
            // sat_hour_label
            // 
            this.sat_hour_label.AutoSize = true;
            this.sat_hour_label.Location = new System.Drawing.Point(1116, 53);
            this.sat_hour_label.Name = "sat_hour_label";
            this.sat_hour_label.Size = new System.Drawing.Size(84, 15);
            this.sat_hour_label.TabIndex = 34;
            this.sat_hour_label.Text = "Put hours here";
            // 
            // wed_hour_label
            // 
            this.wed_hour_label.AutoSize = true;
            this.wed_hour_label.Location = new System.Drawing.Point(592, 53);
            this.wed_hour_label.Name = "wed_hour_label";
            this.wed_hour_label.Size = new System.Drawing.Size(84, 15);
            this.wed_hour_label.TabIndex = 31;
            this.wed_hour_label.Text = "Put hours here";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 651);
            this.Controls.Add(this.sat_hour_label);
            this.Controls.Add(this.fri_hour_label);
            this.Controls.Add(this.thurs_hour_label);
            this.Controls.Add(this.wed_hour_label);
            this.Controls.Add(this.tues_hour_label);
            this.Controls.Add(this.mon_hour_label);
            this.Controls.Add(this.sun_hour_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "ScheduleForm";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox sat_listbox;
        private System.Windows.Forms.ListBox fri_listbox;
        private System.Windows.Forms.ListBox wed_listbox;
        private System.Windows.Forms.ListBox thurs_listbox;
        private System.Windows.Forms.ListBox tues_listbox;
        private System.Windows.Forms.ListBox mon_listbox;
        private System.Windows.Forms.ListBox sun_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sun_hour_label;
        private System.Windows.Forms.Label mon_hour_label;
        private System.Windows.Forms.Label tues_hour_label;
        private System.Windows.Forms.Label thurs_hour_label;
        private System.Windows.Forms.Label fri_hour_label;
        private System.Windows.Forms.Label sat_hour_label;
        private System.Windows.Forms.Label wed_hour_label;
    }
}