using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // login button functionality


            String username = textBox1.Text;
            String password = textBox2.Text;
            String FileWrite = "\n";

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username/Password cannot be empty!");
                // add more error visuals?
            }

            else
            {
                FileWrite = username + "," + password + ",";
            }
        }
    }
}
