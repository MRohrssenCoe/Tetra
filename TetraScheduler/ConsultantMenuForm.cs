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
        public ConsultantMenuForm(string username)
        {
            InitializeComponent();
            userInfo = new Dictionary<string, string>();
            importUserInfo(username);
        }


        private void importUserInfo(string username){
            // open file linked to username
            string path = Path.Combine(Constants.userPreferencesFolder, username + ".txt");
            if (!File.Exists(path)){
                FileStream userInfo = File.Open(path, FileMode.Create);
                userInfo.Write(Encoding.ASCII.GetBytes(String.Join("\n", Constants.userInfoLines)));
                userInfo.Close();
            }
            else // read in info and update UI
            {
                string[] settings = File.ReadAllLines(path);
                foreach (string line in settings)
                {
                    int sep = line.IndexOf("=");
                    string settingName = line.Substring(0, sep);
                    string settingPrefs = line.Substring(sep+1).Trim();
                    userInfo[settingName] = settingPrefs;
                }
                // can probably optimize this...

                fnameTextbox.Text = userInfo["fname"];
                lnameTextbox.Text = userInfo["lname"];
                string[] majors = userInfo["majors"].Split(";");
                foreach (string major in majors)
                {
                    // todo: map index in listbox to each major
                }

                expNumPicker.Value = userInfo["expNum"].Length == 0 ? 0 : Int32.Parse(userInfo["expNum"]);
                
                // todo: parse shifts

            }
            // fill in spaces with appropriate info

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
        {
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

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            // save info button

            userInfo["fname"] = fnameTextbox.Text;
            userInfo["lname"] = lnameTextbox.Text;
            userInfo["majors"] = majorsSelected();
            userInfo["expSem"] = expNumPicker.Value.ToString();
            // add other info here

            // write dictionary to file here
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
