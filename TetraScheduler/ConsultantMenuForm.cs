using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ConsultantMenuForm : Form
    {
        Schedule consultantAvailability;
        Dictionary<string, string> userInfo;
        private string uInfoFile;
        public ConsultantMenuForm(string username)
        {
            InitializeComponent();
            userInfo = new Dictionary<string, string>();
            this.uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".txt");
            importUserInfo(username);
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

                // fill # of semesters of experience box
                expNumPicker.Value = userInfo["expSem"].Length == 0 ? 0 : Int32.Parse(userInfo["expSem"]);
                
                // todo: box for school year

                // todo: parse shifts after figuring out availability format
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScheduleForm f2 = new ScheduleForm();
            f2.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string majorsSelected()
        {   // returns string representation of which majors were selected in the listbox
            int numMajors = majorListbox.CheckedItems.Count;

            if (numMajors == 0)
            {
                return "";
            }

            string[] majors = new string[majorListbox.CheckedItems.Count];
            StringBuilder majorString = new StringBuilder();

            // get list from checkboxes
            majorListbox.CheckedItems.CopyTo(majors, 0);

            //build string rep
            foreach (string major in majors)
            {
                majorString.Append(major + ";");
            }

            // strip trailing comma? maybe unnecessary
            if (majorString.Length > 0)
            {
                majorString.Remove(majorString.Length - 1, 1);
            }

            return majorString.ToString();
        }

        private string fillUserInfoFile(Dictionary<string,string> values)
        {
            StringBuilder s = new StringBuilder();
            foreach(KeyValuePair<string,string> pair in values) // order shouldn't matter?
            {
                s.AppendLine(pair.Key + "=" + pair.Value); 
            }

            return s.ToString();
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            // save info button

            userInfo["fname"] = fnameTextbox.Text;
            userInfo["lname"] = lnameTextbox.Text;
            userInfo["majors"] = majorsSelected();
            userInfo["expSem"] = expNumPicker.Value.ToString();
            // add other info here

            // write dictionary to file here
            try
            {
                File.WriteAllText(this.uInfoFile, fillUserInfoFile(this.userInfo));
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SelectAvailabilityForm availForm = new SelectAvailabilityForm();
            availForm.ShowDialog();
            //show dialog pauses execution
            consultantAvailability = availForm.AvailableSchedule;
            //code here to display availability in consultant menu
            availForm.Dispose();
        }
    }
}
