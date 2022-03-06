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
        AdminOptions storedOptions;
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
            importAdminInfo(name);

        }
        //Same thing as consultant menu. Load info from Json, fill boxes.
        private void importAdminInfo(string name)
        {
            //Generate defualt file to avoid crashing lol
            //remembered to actually close the file this time so we don't crash randomly
            if (!File.Exists(this.adminInfoFile))
            {
                AdminOptions adminOptions = new AdminOptions();
                FileStream adminOptionsStream = File.Open(this.adminInfoFile, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(adminOptions));
                adminOptionsStream.Write(info, 0, info.Length);
                adminOptionsStream.Close();
                storedOptions = adminOptions;
            } else
            {
                string adminOptionsJsonString = File.ReadAllText(this.adminInfoFile);
                AdminOptions ao = JsonSerializer.Deserialize<AdminOptions>(adminOptionsJsonString);
                storedOptions = ao;
                addBusyShiftsToView(ao.BusyShifts);
                mixMajorCheck.Checked = ao.MixMajors;
                mixSemestersCheck.Checked = ao.MixExperience;
                mixYearsCheck.Checked = ao.MixYear;
                consecutiveShiftsUpDn.Value = ao.DesiredConsecutiveShifts;
                consultantsNeededUpDn.Value = ao.MaxConsultantsPerShift;
                busyConsultantsUpDn.Value = ao.MaxConsultantsPerBusyShift;
                shiftLengthUpDn.Value = ao.ShiftLengthMinutes;
                foreach(int d in ao.daysOpen)
                {
                    switch (d)
                    {
                        case 0:
                            sundayCheck.Checked = true;
                            break;
                        case 1:
                            mondayCheck.Checked = true;
                            break;
                        case 2:
                            tuesdayCheck.Checked = true;
                            break;
                        case 3:
                            wednesdayCheck.Checked = true;
                            break;
                        case 4:
                            thursdayCheck.Checked = true;
                            break;
                        case 5:
                            fridayCheck.Checked = true;
                            break;
                        case 6:
                            saturdayCheck.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
                //handle open time after changing to time pickers lol
                int openHour = (int)(ao.OpenTime - (ao.OpenTime % 60)) / 60;
                int openMinute = (int)(ao.OpenTime % 60);
                DateTime openDT = new DateTime(1969, 1, 1, openHour, openMinute, 0);
                openTimePicker.Value = openDT;
                int closeHour = (int)(ao.CloseTime - (ao.CloseTime % 60)) / 60;
                int closeMinute = (int)(ao.CloseTime % 60);
                DateTime closeDT = new DateTime(1969, 1, 1, closeHour, closeMinute, 0);
                closeTimePicker.Value = closeDT;
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
            sm.ao = this.storedOptions;
            Schedule s = sm.generateSchedule();
            ScheduleMaker.ScheduleToCSV(s);
            Debug.WriteLine(s);
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
            foreach (Shift s in shifts)
            {
                busyShiftsList.Add(s);
            }
            busyListBox.DataSource = busyShiftsList;
        }

        private void removeAccButton_Click(object sender, EventArgs e)
        {
            RemoveAccount remove = new RemoveAccount();
            remove.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //I know that this seems backwards, but this is what works. I'm very confused about it too.
            if(openTimePicker.Value.TimeOfDay > closeTimePicker.Value.TimeOfDay)
            {
                var Result = MessageBox.Show("Close time must be after opening time!", "Open/Close Time Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminOptions ao = new AdminOptions();
            ao.MixYear = mixYearsCheck.Checked;
            ao.MixMajors = mixMajorCheck.Checked;
            ao.MixExperience = mixSemestersCheck.Checked;
            ao.BusyShifts = busyShiftsList;
            ao.OpenTime = (openTimePicker.Value.Hour * 60) + (openTimePicker.Value.Minute);
            ao.CloseTime = (closeTimePicker.Value.Hour * 60) + (closeTimePicker.Value.Minute);
            ao.daysOpen = getDaysOpen();
            ao.DesiredConsecutiveShifts = (int)consecutiveShiftsUpDn.Value;
            ao.MaxConsultantsPerShift = (int)consultantsNeededUpDn.Value;
            ao.MaxConsultantsPerBusyShift = (int)busyConsultantsUpDn.Value;
            ao.ShiftLengthMinutes = (int)shiftLengthUpDn.Value;
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
            foreach (CheckBox check in dayCheckboxList)
            {
                if (check.Checked)
                {
                    i++;
                }
                else
                {
                    //remove unchecked items from this list so that we have the correct items and a proper amount of items for the array
                    removalCheckboxList.Remove(check);
                }
            }
            int[] days = new int[i];
            i = 0;
            foreach (CheckBox check in removalCheckboxList)
            {
                days[i] = dayFromBox(check);
                i++;
            }
            return days;
        }

        private int dayFromBox(CheckBox check)
        {
            if (check == sundayCheck)
            {
                return 0;
            }
            if (check == mondayCheck)
            {
                return 1;
            }
            if (check == tuesdayCheck)
            {
                return 2;
            }
            if (check == wednesdayCheck)
            {
                return 3;
            }
            if (check == thursdayCheck)
            {
                return 4;
            }
            if (check == fridayCheck)
            {
                return 5;
            }
            if (check == saturdayCheck)
            {
                return 6;
            }
            return -1;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
