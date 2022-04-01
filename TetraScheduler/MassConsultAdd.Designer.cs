
namespace TetraScheduler
{
    partial class MassConsultAdd
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
            this.selectCSV = new System.Windows.Forms.Button();
            this.massAddButton = new System.Windows.Forms.Button();
            this.fileSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectCSV
            // 
            this.selectCSV.Location = new System.Drawing.Point(82, 366);
            this.selectCSV.Name = "selectCSV";
            this.selectCSV.Size = new System.Drawing.Size(107, 53);
            this.selectCSV.TabIndex = 0;
            this.selectCSV.Text = "Select CSV";
            this.selectCSV.UseVisualStyleBackColor = true;
            this.selectCSV.Click += new System.EventHandler(this.selectCSV_Click);
            // 
            // massAddButton
            // 
            this.massAddButton.Location = new System.Drawing.Point(574, 366);
            this.massAddButton.Name = "massAddButton";
            this.massAddButton.Size = new System.Drawing.Size(128, 53);
            this.massAddButton.TabIndex = 1;
            this.massAddButton.Text = "Add Consultants";
            this.massAddButton.UseVisualStyleBackColor = true;
            this.massAddButton.Click += new System.EventHandler(this.massAddButton_Click);
            // 
            // fileSelectedLabel
            // 
            this.fileSelectedLabel.AutoSize = true;
            this.fileSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileSelectedLabel.Location = new System.Drawing.Point(195, 380);
            this.fileSelectedLabel.Name = "fileSelectedLabel";
            this.fileSelectedLabel.Size = new System.Drawing.Size(114, 21);
            this.fileSelectedLabel.TabIndex = 2;
            this.fileSelectedLabel.Text = "(No File Select)";
            // 
            // MassConsultAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileSelectedLabel);
            this.Controls.Add(this.massAddButton);
            this.Controls.Add(this.selectCSV);
            this.Name = "MassConsultAdd";
            this.Text = "Add Consultants From Google Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectCSV;
        private System.Windows.Forms.Button massAddButton;
        private System.Windows.Forms.Label fileSelectedLabel;
    }
}