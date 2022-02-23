using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;


//TODO we will run into issues here when we modify UserInfo, or any classes that compose UserInfo. We either need
//to improve our Json serialization, or delete all user prefs every time we update UserInfo.
namespace TetraScheduler
{
    public partial class ConsultantMenuForm : Form
    {
        Schedule consultantAvailability;
        ListBox.ObjectCollection availableShifts;
        private string uInfoFile;
        public ConsultantMenuForm(string username)
        {
            InitializeComponent();
            availableShifts = new ListBox.ObjectCollection(availabilityBox);
            //userInfo = new Dictionary<string, string>();
            this.uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".json");
            importUserInfo(username);
        }


        private void importUserInfo(string username){
            // todo: check for missing info (ex: entire line deleted)
            // open file linked to username

            // creates file if not there
            if (!File.Exists(this.uInfoFile)){
                UserInfo uInfo = new UserInfo();
                FileStream userInfo = File.Open(this.uInfoFile, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(fillUserInfoFile(uInfo));
                userInfo.Write(info, 0, info.Length);
                userInfo.Close();
            }
            else // read in info and update UI
            {
                //Deserialize from Json file
                string uInfoJsonString = File.ReadAllText(this.uInfoFile);
                Debug.WriteLine(uInfoJsonString);
                UserInfo uInfo = JsonSerializer.Deserialize<UserInfo>(uInfoJsonString);
                //Fill info
                fnameTextbox.Text = uInfo.FirstName;
                lnameTextbox.Text = uInfo.LastName;
                expSemPicker.Value = uInfo.expSemesters;
                coeYrPicker.Value = uInfo.coeYear;
                weeklyHrsPicker.Value = uInfo.desiredWeeklyHours;
                //Reusing code to fill majors.
                foreach (string major in uInfo.majors)
                {
                    // checks applicable boxes
                    if (major.Length > 0)
                    {
                        int index = majorListbox.Items.IndexOf(major);
                        majorListbox.SetItemChecked(index, true);
                    }
                }



                // todo: GET AVAILABILITY SHIFTS HERE
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScheduleForm f2 = new ScheduleForm();
            f2.Show();
        }


        private string[] majorsSelected()
        {   // returns string representation of which majors were selected in the listbox
            int numMajors = majorListbox.CheckedItems.Count;

            string[] majors = new string[majorListbox.CheckedItems.Count];
            // get list from checkboxes
            majorListbox.CheckedItems.CopyTo(majors, 0);
            return majors;

        }

        private string fillUserInfoFile(UserInfo uInfo)
        {
            return JsonSerializer.Serialize(uInfo);
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            // save info button
            UserInfo uInfo = new UserInfo();
            uInfo.FirstName = fnameTextbox.Text;
            uInfo.LastName = lnameTextbox.Text;
            uInfo.majors = majorsSelected();
            uInfo.expSemesters = (int)expSemPicker.Value;
            uInfo.coeYear = (int)coeYrPicker.Value;
            uInfo.desiredWeeklyHours = (int)weeklyHrsPicker.Value;
            uInfo.availability = consultantAvailability.GetShiftsForUser("Consultant", "Consultant");

            // write object to json here
            try
            {
                Debug.WriteLine(fillUserInfoFile(uInfo));
                File.WriteAllText(this.uInfoFile, fillUserInfoFile(uInfo));
                MessageBox.Show("User info was saved!");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong with saving user info!");
            }
        }
        private void ConsultantMenuForm_Load(object sender, EventArgs e)
        {

        }

        // delete this when we get rid of the string display V
        private void displayArray(ArrayList[] avail)
        {
            availableShifts.Clear();

            if (avail != null) // stop giving me null errors :(
            {
                for (int i = 0; i < avail.Length; i++)
                {
                    // map i to days of the week here later
                    if (avail[i] != null)
                    {
                        foreach (string timeslot in avail[i])
                        {
                            availableShifts.Add(i.ToString() + ": " + timeslot);
                        }
                    }
                }
            }
        }

        private void displayChosenShifts(Schedule s)
        {
            ArrayList shifts = s.getFilledShifts();
            foreach (ArrayList dayList in shifts)
            {
                foreach(Shift shift in dayList)
                {
                    shift.RemoveUser("Consultant", "Consultant");
                    this.availableShifts.Add(shift);
                }
            }
        }

        private Shift[] getChosenShiftInfo()
        {
            Shift[] shifts = new Shift[this.availableShifts.Count];
            this.availableShifts.CopyTo(shifts,0);
            return shifts;
            // todo: make this work with JSON
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // availability selection button
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            //show dialog pauses execution
            availForm.ShowDialog();
            
            consultantAvailability = availForm.AvailableSchedule;
            ArrayList[] stringAvail = availForm.selectedScheduleStrings;
            //code here to display availability in consultant menu
            availForm.Dispose();
            Debug.WriteLine(consultantAvailability.ToString());

            // displays string array
            //displayArray(stringAvail);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
