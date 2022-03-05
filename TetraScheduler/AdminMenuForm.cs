using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace TetraScheduler
{
    
    public partial class AdminMenuForm : Form
    {
        List<Shift> busyShiftsList = new List<Shift>();
        private ListBox.ObjectCollection busyShiftsCollection;
        public AdminMenuForm(String name)
        {
            InitializeComponent();

            // fun little greeting :)
            // change to get their name from the accounts file later
            welcomeLabel.Text = "Welcome, " + name + "!";

            // adds collection object to listbox
            busyShiftsCollection = new ListBox.ObjectCollection(busyListBox);
            //TODO check this code when we allow admin to change hours, etc.

            comboBox1.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 0, Name = "Sunday"},
                new ComboItem{ ID = 1, Name = "Monday"},
                new ComboItem{ ID = 2, Name = "Tuesday"},
                new ComboItem{ ID = 3, Name = "Wednesday"},
                new ComboItem{ ID = 4, Name = "Thursday"},
                new ComboItem{ ID = 5, Name = "Friday"},
                new ComboItem{ ID = 6, Name = "Saturday" }
            };
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 0, Name = "Sunday"},
                new ComboItem{ ID = 1, Name = "Monday"},
                new ComboItem{ ID = 2, Name = "Tuesday"},
                new ComboItem{ ID = 3, Name = "Wednesday"},
                new ComboItem{ ID = 4, Name = "Thursday"},
                new ComboItem{ ID = 5, Name = "Friday"},
                new ComboItem{ ID = 6, Name = "Saturday" }
            };
            comboBox2.DisplayMember = "ID";
            comboBox2.ValueMember = "ID";
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
            object[] temp = new object[busyShiftsCollection.Count]; // temp copy to avoid deleting through iteration
            busyShiftsCollection.CopyTo(temp, 0);
            foreach (Object o in temp)
            {
                busyShiftsCollection.Remove(o);
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
            //List<UserInfo> users = ScheduleMaker.usersFromDir(Constants.userPreferencesFolder);

            Testing testing = new Testing();
            List<UserInfo> users = testing.generateConsultants(50);
            Debug.WriteLine(users);
            ScheduleMaker sm = new ScheduleMaker(users);
            Schedule s = sm.generateSchedule();
            ScheduleMaker.ScheduleToCSV(s);
            Debug.WriteLine(s);
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAcountForm addForm = new AddAcountForm();
            addForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            availForm.ShowDialog();
            //show dialog pauses execution
            List<Shift> temp = new List<Shift>();
            temp = availForm.AvailableSchedule.GetShiftsForUser("Consultant", "Consultant");
            //code here to display availability in consultant menu
            addBusyShiftsToView(temp);
            availForm.Dispose();
        }
        private void addBusyShiftsToView(List<Shift> shifts)
        {
            busyListBox.DataSource = null;
            busyShiftsList.Clear();
            foreach(Shift s in shifts)
            {
                busyShiftsList.Add(s);
            }
            busyListBox.DataSource=busyShiftsList;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void removeAccButton_Click(object sender, EventArgs e)
        {
            RemoveAccount remove = new RemoveAccount();
            remove.Show();
        }

        private void mixMajorCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminOptions ao = new AdminOptions();

            ao.MixYear = mixYearsCheck.Checked;
            ao.MixMajors = mixMajorCheck.Checked;
            ao.MixExperience = mixSemestersCheck.Checked;
            ao.BusyShifts = busyShiftsList;
            ao.OpenTime = ((int)openHourUpDown.Value * 60) + (int)OpenMinuteUpDown.Value;
            ao.CloseTime = ((int)closeHourUpDown.Value * 60) + (int)CloseMinuteUpDown.Value;
            ao.daysOpen = getDaysOpen(comboBox1.SelectedItem, comboBox2.SelectedItem);


        }

        private int[] getDaysOpen(object selectedItem1, object selectedItem2)
        {
            int[] days = new int[1];
            ComboItem open = (ComboItem)selectedItem1;
            throw new NotImplementedException();
        }

        public class ComboItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
