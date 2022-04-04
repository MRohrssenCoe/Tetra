
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
            this.button1.Location = new System.Drawing.Point(841, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export as CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.Location = new System.Drawing.Point(14, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 530);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sat_listbox
            // 
            this.sat_listbox.FormattingEnabled = true;
            this.sat_listbox.HorizontalScrollbar = true;
            this.sat_listbox.ItemHeight = 20;
            this.sat_listbox.Location = new System.Drawing.Point(1398, 4);
            this.sat_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sat_listbox.Name = "sat_listbox";
            this.sat_listbox.Size = new System.Drawing.Size(214, 504);
            this.sat_listbox.TabIndex = 6;
            // 
            // fri_listbox
            // 
            this.fri_listbox.FormattingEnabled = true;
            this.fri_listbox.HorizontalScrollbar = true;
            this.fri_listbox.ItemHeight = 20;
            this.fri_listbox.Location = new System.Drawing.Point(1167, 4);
            this.fri_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fri_listbox.Name = "fri_listbox";
            this.fri_listbox.Size = new System.Drawing.Size(214, 504);
            this.fri_listbox.TabIndex = 5;
            this.fri_listbox.SelectedIndexChanged += new System.EventHandler(this.fri_listbox_SelectedIndexChanged);
            // 
            // wed_listbox
            // 
            this.wed_listbox.FormattingEnabled = true;
            this.wed_listbox.HorizontalScrollbar = true;
            this.wed_listbox.ItemHeight = 20;
            this.wed_listbox.Location = new System.Drawing.Point(705, 4);
            this.wed_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wed_listbox.Name = "wed_listbox";
            this.wed_listbox.Size = new System.Drawing.Size(214, 504);
            this.wed_listbox.TabIndex = 4;
            this.wed_listbox.SelectedIndexChanged += new System.EventHandler(this.wed_listbox_SelectedIndexChanged);
            // 
            // thurs_listbox
            // 
            this.thurs_listbox.FormattingEnabled = true;
            this.thurs_listbox.HorizontalScrollbar = true;
            this.thurs_listbox.ItemHeight = 20;
            this.thurs_listbox.Location = new System.Drawing.Point(936, 4);
            this.thurs_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thurs_listbox.Name = "thurs_listbox";
            this.thurs_listbox.Size = new System.Drawing.Size(214, 504);
            this.thurs_listbox.TabIndex = 3;
            this.thurs_listbox.SelectedIndexChanged += new System.EventHandler(this.thurs_listbox_SelectedIndexChanged);
            // 
            // tues_listbox
            // 
            this.tues_listbox.FormattingEnabled = true;
            this.tues_listbox.HorizontalScrollbar = true;
            this.tues_listbox.ItemHeight = 20;
            this.tues_listbox.Location = new System.Drawing.Point(474, 4);
            this.tues_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tues_listbox.Name = "tues_listbox";
            this.tues_listbox.Size = new System.Drawing.Size(214, 504);
            this.tues_listbox.TabIndex = 2;
            this.tues_listbox.SelectedIndexChanged += new System.EventHandler(this.tues_listbox_SelectedIndexChanged);
            // 
            // mon_listbox
            // 
            this.mon_listbox.FormattingEnabled = true;
            this.mon_listbox.HorizontalScrollbar = true;
            this.mon_listbox.ItemHeight = 20;
            this.mon_listbox.Location = new System.Drawing.Point(243, 4);
            this.mon_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mon_listbox.Name = "mon_listbox";
            this.mon_listbox.Size = new System.Drawing.Size(214, 504);
            this.mon_listbox.TabIndex = 1;
            this.mon_listbox.SelectedIndexChanged += new System.EventHandler(this.mon_listbox_SelectedIndexChanged);
            // 
            // sun_listbox
            // 
            this.sun_listbox.ColumnWidth = 10;
            this.sun_listbox.FormattingEnabled = true;
            this.sun_listbox.HorizontalExtent = 20;
            this.sun_listbox.HorizontalScrollbar = true;
            this.sun_listbox.ItemHeight = 20;
            this.sun_listbox.Location = new System.Drawing.Point(13, 4);
            this.sun_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sun_listbox.MultiColumn = true;
            this.sun_listbox.Name = "sun_listbox";
            this.sun_listbox.Size = new System.Drawing.Size(214, 504);
            this.sun_listbox.TabIndex = 0;
            this.sun_listbox.SelectedIndexChanged += new System.EventHandler(this.sun_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(320, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(547, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(769, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1002, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1251, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1472, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sun_hour_label
            // 
            this.sun_hour_label.AutoSize = true;
            this.sun_hour_label.Location = new System.Drawing.Point(77, 71);
            this.sun_hour_label.Name = "sun_hour_label";
            this.sun_hour_label.Size = new System.Drawing.Size(103, 20);
            this.sun_hour_label.TabIndex = 28;
            this.sun_hour_label.Text = "Put hours here";
            // 
            // mon_hour_label
            // 
            this.mon_hour_label.AutoSize = true;
            this.mon_hour_label.Location = new System.Drawing.Point(313, 71);
            this.mon_hour_label.Name = "mon_hour_label";
            this.mon_hour_label.Size = new System.Drawing.Size(103, 20);
            this.mon_hour_label.TabIndex = 29;
            this.mon_hour_label.Text = "Put hours here";
            // 
            // tues_hour_label
            // 
            this.tues_hour_label.AutoSize = true;
            this.tues_hour_label.Location = new System.Drawing.Point(541, 71);
            this.tues_hour_label.Name = "tues_hour_label";
            this.tues_hour_label.Size = new System.Drawing.Size(103, 20);
            this.tues_hour_label.TabIndex = 30;
            this.tues_hour_label.Text = "Put hours here";
            // 
            // thurs_hour_label
            // 
            this.thurs_hour_label.AutoSize = true;
            this.thurs_hour_label.Location = new System.Drawing.Point(1000, 71);
            this.thurs_hour_label.Name = "thurs_hour_label";
            this.thurs_hour_label.Size = new System.Drawing.Size(103, 20);
            this.thurs_hour_label.TabIndex = 32;
            this.thurs_hour_label.Text = "Put hours here";
            // 
            // fri_hour_label
            // 
            this.fri_hour_label.AutoSize = true;
            this.fri_hour_label.Location = new System.Drawing.Point(1235, 71);
            this.fri_hour_label.Name = "fri_hour_label";
            this.fri_hour_label.Size = new System.Drawing.Size(103, 20);
            this.fri_hour_label.TabIndex = 33;
            this.fri_hour_label.Text = "Put hours here";
            // 
            // sat_hour_label
            // 
            this.sat_hour_label.AutoSize = true;
            this.sat_hour_label.Location = new System.Drawing.Point(1469, 71);
            this.sat_hour_label.Name = "sat_hour_label";
            this.sat_hour_label.Size = new System.Drawing.Size(103, 20);
            this.sat_hour_label.TabIndex = 34;
            this.sat_hour_label.Text = "Put hours here";
            // 
            // wed_hour_label
            // 
            this.wed_hour_label.AutoSize = true;
            this.wed_hour_label.Location = new System.Drawing.Point(777, 71);
            this.wed_hour_label.Name = "wed_hour_label";
            this.wed_hour_label.Size = new System.Drawing.Size(103, 20);
            this.wed_hour_label.TabIndex = 31;
            this.wed_hour_label.Text = "Put hours here";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 764);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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