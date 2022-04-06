using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Globalization;


namespace TetraScheduler
{
    public partial class AdminMenuForm : Form
    {
        List<Shift> busyShiftsList = new List<Shift>();
        private string adminInfoFile;
        AdminOptions storedOptions;
        DateTime lastUpdate;
        string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        int[] openTimes;
        int[] closeTimes;
        int lastSelectedDay;


        public AdminMenuForm(String name)
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + name + "!";
            adminInfoFile = Path.Combine(Constants.adminPreferencesFolder, "admin" + ".json");
            importAdminInfo();
            
        }

        //Same thing as consultant menu. Load info from Json, fill boxes.
        private void importAdminInfo()
        {
            //Generate defualt file to avoid crashing lol
            //remembered to actually close the file this time so we don't crash randomly
            if (!File.Exists(this.adminInfoFile))
            { //TODO change to autogenerate with some better defaults.
                AdminOptions adminOptions = new AdminOptions();

                //default settings
                adminOptions.ShiftLengthMinutes = 60;
                adminOptions.MaxConsultantsPerShift = 2;
                adminOptions.MaxConsultantsPerBusyShift = 4;
                adminOptions.DesiredConsecutiveShifts = 3;
                adminOptions.daysOpen =  new bool[] { false, true, true, true, true, true, false };

                //write default settings
                FileStream adminOptionsStream = File.Open(this.adminInfoFile, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(adminOptions));
                adminOptionsStream.Write(info, 0, info.Length);
                adminOptionsStream.Close();
                storedOptions = adminOptions;
            }
                
            //this all used to be in an else block but it broke some initialization stuff like the daysbox so taking it out for now
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

            // last time it was generated
            this.lastUpdate = ao.lastUpdatedTime;
            lastGenLabel.Text = "Last generated:\n" + lastUpdate.ToString();


            // open/close for each day
            int defaultOpen = 8 * 60;
            openTimes = (ao.OpenTimes is null ? new int[] { defaultOpen, defaultOpen, defaultOpen, defaultOpen, defaultOpen, defaultOpen, defaultOpen } : ao.OpenTimes);
            int defaultClose = 17 * 60;
            closeTimes = (ao.CloseTimes is null? new int[] { defaultClose, defaultClose, defaultClose, defaultClose, defaultClose, defaultClose, defaultClose } : ao.CloseTimes);

            addDayTimesToView(openTimes, closeTimes);
            daysbox.SetSelected(0, true);
            lastSelectedDay = 0;
            // set time picker to sunday
            setTimePicker(openTimes[0], closeTimes[0]);


            // days open
            if (ao.daysOpen is null)
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

        }

        private void setTimePicker(int startTime, int endTime)
        {
            int openHour = (int)(startTime - (startTime % 60)) / 60;
            int openMinute = (int)(startTime % 60);
            DateTime openDT = new DateTime(1969, 1, 1, openHour, openMinute, 0);
            openTimePicker.Value = openDT;
            int closeHour = (int)(endTime - (endTime % 60)) / 60;
            int closeMinute = (int)(endTime % 60);
            DateTime closeDT = new DateTime(1969, 1, 1, closeHour%24, closeMinute, 0);
            closeTimePicker.Value = closeDT;
        }

        private void addDayTimesToView(int[] openTimes, int[] closeTimes)
        {
            ListBox.ObjectCollection schedDays = daysbox.Items;
            bool[] open = getDaysOpen();
            while(schedDays.Count > 0)
            {
                schedDays.RemoveAt(0);
            }
            for (int day = 0; day < 7; day++)
            {
                if (open[day])
                {
                    schedDays.Add(days[day] + ": " + Shift.minutesToHr(openTimes[day], true) + " - " + Shift.minutesToHr(closeTimes[day], true));
                }
                else
                {
                    schedDays.Add(days[day] + ": CLOSED");
                }
            }
        }

        private void updateDayTime(int index)
        {
            ListBox.ObjectCollection schedDays = daysbox.Items;
            bool[] open = getDaysOpen();
            if (open[index])
            {
                schedDays[index] = days[index] + ": " + Shift.minutesToHr(openTimes[index], true) + " - " + Shift.minutesToHr(closeTimes[index], true);
            }
            else
            {
                schedDays[index] = days[index] + ": CLOSED";
            }
            
            daysbox.Focus();
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

            this.lastUpdate = DateTime.Now;
            lastGenLabel.Text = "Last generated:\n" + lastUpdate.ToString();

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
            MessageBox.Show("New Schedule Generated!");
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAcountForm addForm = new AddAcountForm();
            addForm.Show();
        }

        private void selectBusyShiftsClick(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm(busyShiftsList);
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
            for(int i = 0; i < 7; i++)
            {
                if (openTimes[i] > closeTimes[i])
                {
                    MessageBox.Show("Close time must be after opening time!", "Open/Close Time Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            AdminOptions ao = new AdminOptions
            {
                MixYear = mixYearsCheck.Checked,
                MixMajors = mixMajorCheck.Checked,
                MixExperience = mixSemestersCheck.Checked,
                BusyShifts = busyShiftsList,
                OpenTimes = this.openTimes,
                CloseTimes = this.closeTimes,
                daysOpen = getDaysOpen(),
                DesiredConsecutiveShifts = (int)consecutiveShiftsUpDn.Value,
                MaxConsultantsPerShift = (int)consultantsNeededUpDn.Value,
                MaxConsultantsPerBusyShift = (int)busyConsultantsUpDn.Value,
                ShiftLengthMinutes = (int)shiftLengthUpDn.Value,
                lastUpdatedTime = this.lastUpdate
                // TODO: fix open/closetimes
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

        private void handle_DayClick(object sender, EventArgs e)
        {
            // get day clicked
            int indSelected = daysbox.SelectedIndex;
            if (indSelected > -1 && indSelected != lastSelectedDay)
            {
                // update timepicker
                lastSelectedDay = indSelected;
                setTimePicker(openTimes[indSelected], closeTimes[indSelected]);
            }
            
        }

        private void handle_TimePickUpdate(object sender, EventArgs e)
        {
            // on update val - update vals in listbox
            DateTimePicker s = (DateTimePicker)sender;
            if (s.Name == "openTimePicker")
            {
                Debug.WriteLine("Open");
                Debug.WriteLine(s.Value.Hour);
                openTimes[lastSelectedDay] = s.Value.Hour * 60 + s.Value.Minute;

            }
            else if (s.Name == "closeTimePicker"){
                Debug.WriteLine("Close");
                Debug.WriteLine(s.Value.Hour);
                closeTimes[lastSelectedDay] = (s.Value.Hour != 0 ? s.Value.Hour : 24) * 60 + s.Value.Minute; // functionality to be open all day
            }

            updateDayTime(lastSelectedDay);
            //daysbox.Focus();
        }

        private void toggleDaysOnOff(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                updateDayTime(i);
            }
            
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

        private void viewAdminButton_Click(object sender, EventArgs e)
        {
            new UpdateUserForm().ShowDialog();
        }

        private void viewConsultButton_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Path.Combine(Constants.AppDataFolder, "Hey.pdf");
            Process.Start("explorer", "\"" + filename + "\"");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MassConsultAdd().Show();
        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
