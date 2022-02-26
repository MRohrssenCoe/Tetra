using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Use this method to check for forbidden commas in username and password input.
        private bool checkForForbiddenChar(string s, char c)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == c) { return true; }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // login button functionality


            String username = textBox1.Text;
            String password = textBox2.Text;
            String Writer = "\n";

            if (username.Length == 0)
            {
                MessageBox.Show("Username cannot be empty!");
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("Password cannot be empty!");
            }
            else
            {
                if (radioButton4.Checked)
                    Writer = username + "," + password + ",1,";
                else if (radioButton5.Checked)
                    Writer = username + "," + password + ",0,";
                else if (radioButton6.Checked)
                    Writer = username + "," + password + ",3,";
            }
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            string[] token;
            token = usernameString.Split(",");
            int x = 0;
            bool checker = false;
            while (x < token.Length)
            {
                if (token[x].Equals(username))
                    checker = true;
                if (checker)
                    break;
                x += 3;
            }
            if (checker)
                MessageBox.Show("Username is currently in use. Please use another or consult an administrator.");
            else
            {
                //Write it
                usernameString = usernameString + Writer;
                File.WriteAllText(pswdFile, usernameString);
                this.Close();
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username...";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password...")
            {
                textBox2.Text = "";
            }
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Password...";
            }
        }
    }
}
