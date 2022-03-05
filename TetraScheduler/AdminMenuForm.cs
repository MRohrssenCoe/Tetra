using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TetraScheduler
{
    
    public partial class AdminMenuForm : Form
    {
        List<Shift> busyShiftsList = new List<Shift>();
        private ListBox.ObjectCollection busyShiftsCollection;
        private string adminInfoFile;
        public AdminMenuForm(String name)
        {
            InitializeComponent();
            // fun little greeting :)
            // change to get their name from the accounts file later
            welcomeLabel.Text = "Welcome, " + name + "!";
            // adds collection object to listbox
            busyShiftsCollection = new ListBox.ObjectCollection(busyListBox);
            //TODO check this code when we allow admin to change hours, etc.
            adminInfoFile = Path.Combine(Constants.adminPreferencesFolder, name + ".json");
            if (!File.Exists(this.adminInfoFile))
            {
                AdminOptions adminOptions = new AdminOptions();
                FileStream adminOptionsStream = File.Open(this.adminInfoFile, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(adminOptions));
                adminOptionsStream.Write(info, 0, info.Length);
                adminOptionsStream.Close();
            }

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
            //List<UserInfo> users = ScheduleMaker.usersFromDir(Constants.userPreferencesFolder);

            Testing testing = new Testing();
            List<UserInfo> users = testing.generateConsultants(50);
            Debug.WriteLine(users);
            ScheduleMaker sm = new ScheduleMaker(users);

            Debug.WriteLine(sm.generateSchedule());
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAcountForm addForm = new AddAcountForm();
            addForm.Show();
        }

        private void selectBusyShiftsClick(object sender, EventArgs e)
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
            ao.daysOpen = getDaysOpen();
            ao.DesiredConsecutiveShifts = (int)ConsecutiveShiftsBox.Value;
            ao.MaxConsultantsPerShift = (int)consultantsPerShiftBox.Value;
            ao.MaxConsultantsPerBusyShift = (int)busyConsultantsPerShiftBox.Value;


            //serialize data
            FileStream adminOptionsStream = File.Open(this.adminInfoFile, FileMode.Create);
            byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(ao));
            adminOptionsStream.Write(info, 0, info.Length);
            adminOptionsStream.Close();
        }

        //This is quite possibly the most dogshit method I have ever written
        private int[] getDaysOpen()
        {
            List<CheckBox> dayCheckboxList = new List<CheckBox>();
            dayCheckboxList.Add(sundayCheck);
            dayCheckboxList.Add(mondayCheck);
            dayCheckboxList.Add(tuesdayCheck);
            dayCheckboxList.Add(wednesdayCheck);
            dayCheckboxList.Add(thursdayCheck);
            dayCheckboxList.Add(fridayCheck);
            dayCheckboxList.Add(saturdayCheck);
            //clone constructor so taht we can remove things from this list
            List<CheckBox> removalCheckboxList = new List<CheckBox>(dayCheckboxList);
            int i = 0;
            foreach(CheckBox check in dayCheckboxList)
            {
                if (check.Checked)
                {
                    i++;
                } else
                {
                    //remove unchecked items from this list so that we have the correct items and a proper amount of items for the array
                    removalCheckboxList.Remove(check);
                }
            }
            int[] days = new int[i];
            i = 0;
            foreach(CheckBox check in removalCheckboxList)
            {
                days[i] = dayFromBox(check);
                i++;
            }
            return days;
        }

        private int dayFromBox(CheckBox check)
        {
            if(check == sundayCheck)
            {
                return 0;
            }
            if(check == mondayCheck)
            {
                return 1;
            }
            if(check == tuesdayCheck)
            {
                return 2;
            } 
            if(check == wednesdayCheck)
            {
                return 3;
            }
            if(check == thursdayCheck)
            {
                return 4;
            }
            if(check == fridayCheck)
            {
                return 5;
            }
            if(check == saturdayCheck)
            {
                return 6;
            }
            return -1;
        }

        public class ComboItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewSchedButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
