using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class AdminMenuForm : Form
    {

        private ListBox.ObjectCollection busyShifts;
        public AdminMenuForm(String name)
        {
            InitializeComponent();

            // fun little greeting :)
            // change to get their name from the accounts file later
            welcomeLabel.Text = "Welcome, " + name + "!";

            // set dateTime format properly
            startBusy.Format = DateTimePickerFormat.Custom;
            startBusy.CustomFormat = "hh:mm tt";
            startBusy.ShowUpDown = true;
            startBusy.Value = DateTime.Parse("12:00 AM");
            endBusy.Format = DateTimePickerFormat.Custom;
            endBusy.CustomFormat = "hh:mm tt";
            endBusy.ShowUpDown = true;
            endBusy.Value = DateTime.Parse("12:00 AM");

            // adds collection object to listbox
            busyShifts = new ListBox.ObjectCollection(busyList);
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void viewSchedButton_Click(object sender, EventArgs e)
        {
            // loads schedule form
            ScheduleForm sf = new ScheduleForm();
            sf.Show();
        }

        private void addBusy_Click(object sender, EventArgs e)
        {
            // uses info from startBusy and endBusy timepickers to add a busy shift to list of busy shifts
        }

        private void removeAllBusy_Click(object sender, EventArgs e)
        {
            // removes all items from busy shift list
            // TODO: test this function

            object[] temp = new object[busyShifts.Count]; // temp copy to avoid deleting through iteration
            busyShifts.CopyTo(temp, 0);
            foreach (Object o in temp)
            {
                busyShifts.Remove(o); 
            }
        }

        private void removeSelectBusy_Click(object sender, EventArgs e)
        {
            // removes item(s?) that are selected in the listbox from busy shift list
        }

        private void genScheduleButton_Click(object sender, EventArgs e)
        {
            // runs schedule algorithm and updates our schedule file
            // uses info from busy schedule list and from checkboxes
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1();
            addForm.Show();
        }
    }
}

