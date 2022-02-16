﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ConsultantMenuForm : Form
    {
        Schedule consultantAvailability;
        public ConsultantMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScheduleForm f2 = new ScheduleForm();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // save info button

            int numMajors = checkedListBox1.CheckedItems.Count;

            if (numMajors == 0)
            {
                MessageBox.Show("Select at least one major!");
            }
            else
            {
                // testing grabbing majors from list - add more major options in the checkedListBox items property
                // add minors in this category? or separate
                string[] majors = new string[checkedListBox1.CheckedItems.Count];
                StringBuilder majorString = new StringBuilder();
                checkedListBox1.CheckedItems.CopyTo(majors, 0);
                Debug.WriteLine("Majors:");
                foreach (string major in majors)
                {
                    Debug.WriteLine(major);
                    majorString.Append(major + ",");
                }
                if (majorString.Length > 0)
                {
                    majorString.Remove(majorString.Length-1,1); // strip trailing comma? maybe unnecessary
                }

                Debug.WriteLine("String rep: " + majorString.ToString());
            }
        }

        private void ConsultantMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            availForm.ShowDialog();
            //show dialog pauses execution
            consultantAvailability = availForm.AvailableSchedule;
            //code here to display availability in consultant menu
            availForm.Dispose();
        }
    }
}
