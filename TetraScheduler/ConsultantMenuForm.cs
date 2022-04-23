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
        List<Shift> consultantAvailability;
        ListBox.ObjectCollection availableShifts;
        private string uInfoFile;
        private string username;
        Form previous;
        public ConsultantMenuForm(string username)
        {
            InitializeComponent();
            welcomeLabel.Text = welcomeLabel.Text.Replace("consultant", username);
            this.username = username;
            using (FileStream fs = File.Open(Path.Combine(Constants.AppDataFolder, Constants.MajorsFile), FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    var majorText = sr.ReadToEnd();
                    var tokens = majorText.Split(',');
                    foreach (var tk in tokens)
                    {
                        var m = tk.Trim();
                        if (m != "")
                        {
                            majorListbox.Items.Add(m);
                        }
                    }
                }
            }
            availableShifts = new ListBox.ObjectCollection(availabilityBox);
            this.uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".json");
            importUserInfo();
        }

        public ConsultantMenuForm(string username, Form prev)
        {
            InitializeComponent();
            previous = prev;
            this.username = username;
            using (FileStream fs = File.Open(Path.Combine(Constants.AppDataFolder, Constants.MajorsFile), FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    var majorText = sr.ReadToEnd();
                    var tokens = majorText.Split(',');
                    foreach (var tk in tokens)
                    {
                        var m = tk.Trim();
                        if (m != "")
                        {
                            majorListbox.Items.Add(m);
                        }
                    }
                }
            }
                availableShifts = new ListBox.ObjectCollection(availabilityBox);
            this.uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".json");
            importUserInfo();
        }


        private void importUserInfo(){
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
                //Fill UI info
                fnameTextbox.Text = uInfo.FirstName;
                lnameTextbox.Text = uInfo.LastName;
                semExpUpDn.Value = uInfo.expSemesters;
                coeYrUpDn.Value = uInfo.schoolYear;
                desiredWeeklyHrsUpDn.Value = uInfo.desiredWeeklyHours;
                consultantAvailability = uInfo.availability;
                if (!(consultantAvailability is null))
                    addAvailabilityToView(uInfo.availability);
                //Reusing code to fill majors.
                //null check
                if (uInfo.majors != null)
                {
                    foreach (string major in uInfo.majors)
                    {
                        //Checks applicable boxes
                        if (major.Length > 0)
                        {
                            int index = majorListbox.Items.IndexOf(major);
                            if (index != -1)
                            {
                                majorListbox.SetItemChecked(index, true);
                            }
                        }
                    }
                }
            }
        }

        private void ViewScheduleButtonClick(object sender, EventArgs e)
        {
            ScheduleForm f2 = new ScheduleForm();
            f2.Show();
        }

        private string[] majorsSelected()
        {   // returns string representation of which majors were selected in the listbox
            string[] majors = new string[majorListbox.CheckedItems.Count];
            // get list from checkboxes
            majorListbox.CheckedItems.CopyTo(majors, 0);
            return majors;

        }

        //extraneous method, consider removing.
        private string fillUserInfoFile(UserInfo uInfo)
        {
            return JsonSerializer.Serialize(uInfo);
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            //Store demographic info in UserInfo object
            UserInfo uInfo = new UserInfo();
            uInfo.FirstName = fnameTextbox.Text;
            uInfo.LastName = lnameTextbox.Text;
            uInfo.majors = majorsSelected();
            uInfo.expSemesters = (int)semExpUpDn.Value;
            uInfo.schoolYear = (int)coeYrUpDn.Value;
            uInfo.desiredWeeklyHours = (int)desiredWeeklyHrsUpDn.Value;
            uInfo.availability = consultantAvailability;

            //write UserInfo object to json here
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

        private void SelectAvailabilityButtonClick(object sender, EventArgs e)
        {
            // availability selection button
            SelectAvailabilityForm availForm = new SelectAvailabilityForm(consultantAvailability);
            //show dialog pauses execution
            availForm.ShowDialog();
            UserInfo uInfo = new UserInfo();
            uInfo.FirstName = "Consultant";
            uInfo.LastName = "Consultant";
            consultantAvailability = availForm.AvailableSchedule.GetShiftsForUser(uInfo);
            addAvailabilityToView(consultantAvailability);
            availabilityBox.Hide();
            availabilityBox.Show();
            //ArrayList[] stringAvail = availForm.selectedScheduleStrings;
            //code here to display availability in consultant menu
            availForm.Dispose();
        }

        //Add the shifts to the object collection that availabilityView is bound to
        //To do this we must first unbind the collection, then modify the collection, and then rebind.
        private void addAvailabilityToView(List<Shift> shifts)
        {
            //unbind
            availabilityBox.DataSource = null;
            availableShifts.Clear();
            foreach(Shift s in shifts)
            {
                availableShifts.Add(s);
            }
            //rebind
            availabilityBox.DataSource = availableShifts;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Path.Combine(Constants.AppDataFolder, "Hey.pdf");
            Process.Start("explorer", "\"" + filename + "\"");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void changeLoginInfo_Click(object sender, EventArgs e)
        {
            PasswordChangeBox pcb = new PasswordChangeBox("consultant", this.username);
            pcb.ShowDialog();
            string newUsername = pcb.UsernameReturn;
            string newPassword = pcb.PasswordReturn;
            if (pcb.DialogResult == DialogResult.OK)
            {
                string pFilePath = Path.Combine(Constants.AppDataFolder, Constants.passwordFileName);
                string info = File.ReadAllText(pFilePath);
                string[] sections = info.Split(",");
                for (int i = 0; i < sections.Length; i += 3)
                {
                    if (sections[i].Equals(this.username))
                    {
                        if (!newUsername.Equals(this.username))
                        {
                            // update username in sections
                            sections[i] = newUsername;
                            // rename uInfoFile
                            string oldJson = File.ReadAllText(Path.Combine(Constants.userPreferencesFolder, this.uInfoFile));
                            File.WriteAllText(Path.Combine(Constants.userPreferencesFolder, newUsername + ".json"), oldJson);
                            File.Delete(Path.Combine(Constants.userPreferencesFolder, this.uInfoFile));
                            this.uInfoFile = newUsername + ".json";
                            this.username = newUsername;
                        }
                        // update password in sections
                        sections[i + 1] = LoginForm.encrypt_Password(newPassword);

                        // write all to file
                        File.WriteAllText(pFilePath, String.Join(',', sections));
                    }
                }
            }
        }

        private void ConsultantMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!(previous is null))
            {
                previous.Show(); 
            }
        }
    }
}
