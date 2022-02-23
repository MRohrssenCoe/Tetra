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
                if (radioButton1.Checked)
                    Writer = username + "," + password + ",1,";
                else if (radioButton2.Checked)
                    Writer = username + "," + password + ",2,";
                else if (radioButton3.Checked)
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
                MessageBox.Show("Username is already being used. Please use another name or consult an admin.");
            else
                //Write it
                usernameString = usernameString + Writer; 
        }
    }
}
