using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class Form2 : Form
    {
        private string name;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String name)
        {
            InitializeComponent();
            this.name = name;
            // fun little greeting :)
            // change to get their name from the accounts file later
            textBox2.Text = "Welcome, " + name + "!";
        }

            private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConsultantMenuForm(name).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMenuForm(name).Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ConsultantMenuForm(name).Show();
            new AdminMenuForm(name).Show();
            this.Close();
        }
    }
}
