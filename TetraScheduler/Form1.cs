using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username.Length == 0 || password.Length == 0){
                MessageBox.Show("Username/Password cannot be empty!");
            }

            else {
                // validate username/password from database here - show error if incorrect, otherwise load appropriate dashboard
                // todo: password validation function + file setup
            }

            // remove this later - debugging only
            Debug.WriteLine("Username: " + textBox1.Text + "\tPassword: " + textBox2.Text);

        }
    }
}
