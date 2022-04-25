using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class PasswordChangeBox : Form
    {
        public string UsernameReturn { get; set; }
        public string PasswordReturn { get; set; }
        private string[] acctInfo { get; set; }

        private string prevUsername { get; set; }

        public PasswordChangeBox(string acctType, string prevUsername)
        {
            this.prevUsername = prevUsername;
            InitializeComponent();
            label1.Text = "Enter updated username and password\n for the "+ acctType + " account:";
            readAcctInfo();
            AdminUsernameBox.Text = prevUsername;
            /*AdminUsernameBox.Text = "Username...";
            AdminPasswordBox.Text = "Password...";
            AdminPasswordBox.PasswordChar = '\0';*/
        }

        private void readAcctInfo()
        {
            string info = File.ReadAllText(Path.Combine(Constants.AppDataFolder, Constants.passwordFileName));
            this.acctInfo = info.Split(",");
        }

        private bool usernameExistsAndNotPrevUsername(string username)
        {
            if (username.Equals(prevUsername)) return false;
            for (int i = 0; i < acctInfo.Length; i += 3)
            {
                if (acctInfo[i].Equals(username))
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveLoginInfo();
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

        private void confirmPassBox_Enter(object sender, EventArgs e)
        {

        }

        private void hitEnterOnLastTab(object sender, KeyPressEventArgs e)
        {
            // checks for enter pressed in the password box to submit login
            if (e.KeyChar == (char)13)
            {
                saveLoginInfo();
            }
        }

        private void saveLoginInfo()
        {
            if (AdminPasswordBox.Text != confirmPassBox.Text)
            {
                MessageBox.Show("Your passwords must be the same!");
            }
            else if (usernameExistsAndNotPrevUsername(AdminUsernameBox.Text))
            {
                MessageBox.Show("Username already in use!");
            }
            else if (!validChars(AdminUsernameBox.Text) || !validChars(AdminPasswordBox.Text))
            {
                MessageBox.Show("Usernames and passwords must only contain letters and/or numbers");
            }
            else if (AdminPasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
            }
            else if (AdminPasswordBox.Text.Length == 0 || AdminUsernameBox.Text.Length == 0 || confirmPassBox.Text.Length == 0)
            {
                MessageBox.Show("Please do not leave input fields empty!");
            }
            else
            {
                this.UsernameReturn = AdminUsernameBox.Text;
                this.PasswordReturn = AdminPasswordBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AdminPasswordBox_Leave(object sender, EventArgs e)
        {

        }

        private void confirmPassBox_Leave(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordChangeBox_Load(object sender, EventArgs e)
        {

        }

        private bool validChars(string input)
        {
            foreach(char c in input)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
