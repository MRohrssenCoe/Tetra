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
        private string adminInfoFile;
        AdminOptions storedOptions;


        public AdminMenuForm(String name)
        {
            InitializeComponent();
            // fun little greeting :)
            // change to get their name from the accounts file later
            welcomeLabel.Text = "Welcome, " + name + "!";
            adminInfoFile = Path.Combine(Constants.adminPreferencesFolder, name + ".json");
            importAdminInfo();

        }

        //Same thing as consultant menu. Load info from Json, fill boxes.
        private void importAdminInfo()
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
                if (ao.BusyShifts != null)
                {
                    addBusyShiftsToView(ao.BusyShifts);
                }
                mixMajorCheck.Checked = ao.MixMajors;
                mixSemestersCheck.Checked = ao.MixExperience;
                mixYearsCheck.Checked = ao.MixYear;
                consecutiveShiftsUpDn.Value = ao.DesiredConsecutiveShifts;
                consultantsNeededUpDn.Value = ao.MaxConsultantsPerShift;
                busyConsultantsUpDn.Value = ao.MaxConsultantsPerBusyShift;
                shiftLengthUpDn.Value = ao.ShiftLengthMinutes;

                if (ao.daysOpen == null)
                {
                    ao.daysOpen = new bool[] { true, true, true, true, true, true, true };
                }
                

                sundayCheck.Checked = ao.daysOpen[0];
                mondayCheck.Checked = ao.daysOpen[1];
                tuesdayCheck.Checked = ao.daysOpen[2];
                wednesdayCheck.Checked = ao.daysOpen[3];
                thursdayCheck.Checked = ao.daysOpen[4];
                fridayCheck.Checked = ao.daysOpen[5];
                saturdayCheck.Checked = ao.daysOpen[6];

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
            List<UserInfo> users = ScheduleMaker.usersFromDir(Constants.userPreferencesFolder);

            // saves admin options
            this.saveOptions();

            // generate random users - remove later
            Testing testing = new Testing();
            //List<UserInfo> users = testing.generateConsultants(30);
            Debug.WriteLine(users);

            // initialize schedulemaker
            ScheduleMaker sm = new ScheduleMaker(users, storedOptions);

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
            //TODO phase this out and have availability form return a list of shifts directly.
            UserInfo tempUI = new UserInfo();
            tempUI.FirstName = "Consultant";
            tempUI.LastName = "Consultant";
            temp = availForm.AvailableSchedule.GetShiftsForUser(tempUI);
            //code here to display availability in consultant menu
            Debug.WriteLine(temp != null);
            if (temp != null)
            {
                addBusyShiftsToView(temp);
            }
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


        private void saveOptions()
        {
            //I know that this seems backwards, but this is what works. I'm very confused about it too.
            if (openTimePicker.Value.TimeOfDay > closeTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Close time must be after opening time!", "Open/Close Time Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminOptions ao = new AdminOptions
            {
                MixYear = mixYearsCheck.Checked,
                MixMajors = mixMajorCheck.Checked,
                MixExperience = mixSemestersCheck.Checked,
                BusyShifts = busyShiftsList,
                OpenTime = (openTimePicker.Value.Hour * 60) + (openTimePicker.Value.Minute),
                CloseTime = (closeTimePicker.Value.Hour * 60) + (closeTimePicker.Value.Minute),
                daysOpen = getDaysOpen(),
                DesiredConsecutiveShifts = (int)consecutiveShiftsUpDn.Value,
                MaxConsultantsPerShift = (int)consultantsNeededUpDn.Value,
                MaxConsultantsPerBusyShift = (int)busyConsultantsUpDn.Value,
                ShiftLengthMinutes = (int)shiftLengthUpDn.Value
            };
            //serialize data
            FileStream adminOptionsStream = File.Open(this.adminInfoFile, FileMode.Create);
            byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(ao));
            adminOptionsStream.Write(info, 0, info.Length);
            adminOptionsStream.Close();
            this.storedOptions = ao;
        }
        private void save_Click(object sender, EventArgs e)
        {
            saveOptions();
        }

        //This is quite possibly the most dogshit method I have ever written
        private bool[] getDaysOpen()
        {
            List<CheckBox> dayCheckboxList = new List<CheckBox>
            {
                sundayCheck,
                mondayCheck,
                tuesdayCheck,
                wednesdayCheck,
                thursdayCheck,
                fridayCheck,
                saturdayCheck
            };
            //clone constructor so taht we can remove things from this list
            List<CheckBox> removalCheckboxList = new List<CheckBox>(dayCheckboxList);
            int i = 0;

            bool[] days = new bool[7];
            foreach (CheckBox check in dayCheckboxList)
            {
                days[i] = check.Checked;
                i++;
            }
            
            return days;
        }


        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editScheduleButton_Click(object sender, EventArgs e)
        {
            new ScheduleEditorForm().ShowDialog();
        }
    }
}
