using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ConsultantMenuForm : Form
    {
        Schedule consultantAvailability;
        ListBox.ObjectCollection availableShifts;
        Dictionary<string, string> userInfo;
        private string uInfoFile;
        public ConsultantMenuForm(string username)
        {
            InitializeComponent();
            availableShifts = new ListBox.ObjectCollection(availabilityBox);
            userInfo = new Dictionary<string, string>();
            this.uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".json");
            //importUserInfo(username);
        }


        private void importUserInfo(string username){
            // todo: check for missing info (ex: entire line deleted)
            // open file linked to username

            // creates file if not there
            if (!File.Exists(this.uInfoFile)){
                FileStream userInfo = File.Open(this.uInfoFile, FileMode.Create);
                userInfo.Write(Encoding.ASCII.GetBytes(String.Join("\n", Constants.userInfoLines)));
                userInfo.Close();
            }
            else // read in info and update UI
            {
                string[] settings = File.ReadAllLines(this.uInfoFile);
                foreach (string line in settings)
                {
                    int sep = line.IndexOf("=");
                    string settingName = line.Substring(0, sep);
                    string settingPrefs = line.Substring(sep+1).Trim();
                    // put into dictionary - maybe just learn how to use JSON instead?
                    userInfo[settingName] = settingPrefs;
                }

                // fill first name box
                fnameTextbox.Text = userInfo["fname"];
                // fill last name box
                lnameTextbox.Text = userInfo["lname"];
                // fill major checkboxes
                string[] majors = userInfo["majors"].Split(";");
                foreach (string major in majors)
                {
                    // checks applicable boxes
                    if (major.Length > 0)
                    {
                        int index = majorListbox.Items.IndexOf(major);
                        majorListbox.SetItemChecked(index, true);
                    }
                }

                // fill numboxes
                expSemPicker.Value = userInfo["expSem"].Length == 0 ? 0 : Int32.Parse(userInfo["expSem"]);
                coeYrPicker.Value = userInfo["coeYr"].Length == 0 ? 0 : Int32.Parse(userInfo["coeYr"]);
                weeklyHrsPicker.Value = userInfo["weeklyHrs"].Length == 0 ? 0 : Int32.Parse(userInfo["weeklyHrs"]);

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

            /*if (numMajors == 0)
            {
                return "";
            }*/

            string[] majors = new string[majorListbox.CheckedItems.Count];
            //StringBuilder majorString = new StringBuilder();

            // get list from checkboxes
            majorListbox.CheckedItems.CopyTo(majors, 0);
            return majors;

            /*//build string rep
            foreach (string major in majors)
            {
                majorString.Append(major + ";");
            }

            // strip trailing comma? maybe unnecessary
            if (majorString.Length > 0)
            {
                majorString.Remove(majorString.Length - 1, 1);
            }

            return majorString.ToString();*/
        }

        private string fillUserInfoFile(UserInfo uInfo)
        {
            /*StringBuilder s = new StringBuilder();
            foreach(KeyValuePair<string,string> pair in values) // order shouldn't matter?
            {
                s.AppendLine(pair.Key + "=" + pair.Value); 
            }

            return s.ToString();
            */
            return System.Text.Json.JsonSerializer.Serialize(uInfo);
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

            // add other info here

            // write object to json here
            try
            {
                Debug.WriteLine(fillUserInfoFile(uInfo));
                File.WriteAllText(this.uInfoFile, fillUserInfoFile(uInfo));
                MessageBox.Show("User info was saved!");
            }
            catch (IOException)
            {
                // some sort of error message here idk
            }
        }


        private void ConsultantMenuForm_Load(object sender, EventArgs e)
        {

        }


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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            availForm.ShowDialog();
            //show dialog pauses execution
            consultantAvailability = availForm.AvailableSchedule;
            ArrayList[] stringAvail = availForm.selectedScheduleStrings;
            //code here to display availability in consultant menu
            availForm.Dispose();
            Debug.WriteLine(consultantAvailability.ToString());

            displayArray(stringAvail);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
