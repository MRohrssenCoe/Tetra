using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class PasswordChangeBox : Form
    {
        public string UsernameReturn { get; set; }
        public string PasswordReturn { get; set; }
        public PasswordChangeBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UsernameReturn = AdminUsernameBox.Text;
            this.PasswordReturn = AdminPasswordBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void PasswordChangeBox_Load(object sender, EventArgs e)
        {

        }
    }
}
