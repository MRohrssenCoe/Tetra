namespace TetraScheduler
{
    partial class MajorAdder
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
            this.MajorList = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MajorList
            // 
            this.MajorList.FormattingEnabled = true;
            this.MajorList.ItemHeight = 15;
            this.MajorList.Location = new System.Drawing.Point(10, 9);
            this.MajorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MajorList.Name = "MajorList";
            this.MajorList.Size = new System.Drawing.Size(132, 274);
            this.MajorList.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(10, 307);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(131, 22);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.Location = new System.Drawing.Point(164, 262);
            this.MajorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(132, 23);
            this.MajorTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(164, 307);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 22);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(321, 307);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 22);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MajorAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 338);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MajorTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.MajorList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MajorAdder";
            this.Text = "MajorAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MajorList;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
    }
}