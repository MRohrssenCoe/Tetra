using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            AdminUsernameBox.Text = "Username...";
            AdminPasswordBox.Text = "Password...";
            AdminPasswordBox.PasswordChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UsernameReturn = AdminUsernameBox.Text;
            this.PasswordReturn = AdminPasswordBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void AdminUsernameBox_Leave(object sender, EventArgs e)
        {
            if (AdminUsernameBox.Text == "")
            {
                AdminUsernameBox.Text = "Username...";
            }
        }

        private void AdminUsernameBox_Enter(object sender, EventArgs e)
        {
            if (AdminUsernameBox.Text == "Username...")
            {
                AdminUsernameBox.Text = "";
            }
        }

        private void AdminPasswordBox_Enter(object sender, EventArgs e)
        {
            if (AdminPasswordBox.Text == "Password...")
            {
                AdminPasswordBox.Text = "";
            }
            AdminPasswordBox.PasswordChar = '*';

        }

        private void AdminPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // checks for enter pressed in the password box to submit login
            if (e.KeyChar == (char)13)
            {

                this.UsernameReturn = AdminUsernameBox.Text;
                this.PasswordReturn = AdminPasswordBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AdminPasswordBox_Leave(object sender, EventArgs e)
        {
            if (AdminPasswordBox.Text == "")
            {
                AdminPasswordBox.Text = "Password...";
                AdminPasswordBox.PasswordChar = '\0';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
