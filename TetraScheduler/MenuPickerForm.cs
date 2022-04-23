using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class MenuPickerForm : Form
    {
        private string name;
        Form previous;
        public MenuPickerForm()
        {
            InitializeComponent();
        }

        public MenuPickerForm(String name, Form prev)
        {
            InitializeComponent();
            this.name = name;
            previous = prev;
            // fun little greeting :)
            // change to get their name from the accounts file later
            label1.Text = "Welcome, " + name + ". Which menus would you like to access as a consultant and admin?";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConsultantMenuForm(name, previous).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMenuForm(name, previous).Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ConsultantMenuForm(name, previous).Show();
            new AdminMenuForm(name, previous).Show();
            this.Close();
        }

    }
}
