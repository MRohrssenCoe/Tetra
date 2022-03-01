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
        Schedule busyShiftsSchedule;
        private ListBox.ObjectCollection busyShifts;
        public AdminMenuForm(String name)
        {
            InitializeComponent();

            // fun little greeting :)
            // change to get their name from the accounts file later
            welcomeLabel.Text = "Welcome, " + name + "!";

           

            // adds collection object to listbox
            busyShifts = new ListBox.ObjectCollection(busyList);
            //TODO check this code when we allow admin to change hours, etc.
            busyShiftsSchedule = new Schedule();
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


        private void genScheduleButton_Click(object sender, EventArgs e)
        {
            // runs schedule algorithm and updates our schedule file
            // uses info from busy schedule list and from checkboxes

            AdminOptions AO = new AdminOptions(); // REPLACE WITH READ FROM FILE
            List<UserInfo> users = ScheduleMaker.usersFromDir(Constants.userPreferencesFolder);

            ScheduleMaker sm = new ScheduleMaker(users, AO);
            Schedule s = sm.generateSchedule();

        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1();
            addForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            availForm.ShowDialog();
            //show dialog pauses execution
            busyShiftsSchedule = availForm.AvailableSchedule;
            //code here to display availability in consultant menu
            availForm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

