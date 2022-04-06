using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.Json;

namespace TetraScheduler
{
    public partial class MassConsultAdd : Form
    {

        private string fileName {get; set; }
        private string[] years; //todo: add more

        public MassConsultAdd()
        {
            years = new string[]{ "First-Year", "Sophomore", "Junior", "Senior" };
            InitializeComponent();
        }

        private void selectCSV_Click(object sender, EventArgs e)
        {

            // dialog preferences
            OpenFileDialog sd = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "CSV (Comma delimited) |*.csv",
                FilterIndex = 0,
                RestoreDirectory = true
            };


            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                fileName = sd.FileName;

                //update text on screen
                fileSelectedLabel.Text = Path.GetFileName(fileName);

            }
        }

        private int timeStringToMins(string time12hr)
        {
            // this has so many edge cases that i didn't cover... but works for now...
            string s = time12hr.ToLower();
            int addToPM = 0;
            char amPm = s[s.Length - 2];
            if (amPm == 'a')
            {
                addToPM = 0;
            }
            else if (amPm == 'p')
            {
                addToPM = 12;
            }
            else
            {
                throw new Exception("Invalid time string provided");
            }

            int hrs = int.Parse(s.Substring(0, s.IndexOf(":")));
            if (hrs == 12) hrs = 0;
            int mins = int.Parse(s.Substring(s.IndexOf(":") + 1, 2));

            return (hrs + addToPM) * 60 + mins;
        }

        private List<Shift> availStringToShiftList(string s, int day)
        {
            List<Shift> avails = new List<Shift>();
            string[] hourSpans = s.Split(", ");
            foreach(string hr in hourSpans)
            {
                string start = hr.Substring(0, hr.IndexOf("->"));
                int startMins = timeStringToMins(start);
                // todo: check if i have to assign dummy account
                Shift availability = new Shift();
                availability.startTime = startMins;
                availability.endTime = startMins + 60;
                availability.day = day;
                avails.Add(availability);
            }
            return avails;
        }

        private void massAddButton_Click(object sender, EventArgs e)
        {
            if (fileName is null)
            {
                MessageBox.Show("Please Select a CSV file!");
                return;
            }

            // open csv
            using (TextFieldParser csvParser = new TextFieldParser(this.fileName))
            {
                // set up options
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // read column name row
                string columns = csvParser.ReadLine();

                // todo: check for proper csv headers here



                //iteration through remaining rows
                while (!csvParser.EndOfData)
                {

                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    // separate out relevant fields
                    //0:timestamp, 1:email, 2:fname, 3:lname, 4:yr, 5:majors, 6:workHrs(10s), 7:workHrs(1s),
                    //8:sunAvails, 9:monAvails, 10:tuesAvails, 11:wedAvails, 12:thursAvails, 13:friAvails, 14:satAvails
                    string email = fields[1];

                    // store username, password here to write to file later - todo: check for no overlapping usernames
                    string username = email.Substring(0,email.IndexOf("@"));
                    string password = username; // change this later
                    UserInfo uInfo = new UserInfo();

                    // put stuff in uinfo here 
                    uInfo.FirstName = fields[2];
                    uInfo.LastName = fields[3];
                    uInfo.schoolYear = Array.IndexOf(this.years, fields[4]) + 1;
                    uInfo.majors = fields[5].Split(", ");
                    uInfo.desiredWeeklyHours = int.Parse(fields[6]) * 10 + int.Parse(fields[7]);

                    // oh fuck we need uhhhh semesters of experience somewhere. come back to that.
                    uInfo.expSemesters = 0;

                    // generate availabilities
                    List<Shift> availabilities = new List<Shift>();
                    int sunAvails = 8;
                    int satAvails = 14;
                    for (int i = sunAvails; i < satAvails+1; i++)
                    {
                        int day = i - sunAvails;
                        availabilities.AddRange(availStringToShiftList(fields[i], day));
                    }
                    uInfo.availability = availabilities;

                    // add username and password to file - assuming no repeats bc we're using emails but checking jic
                    string passwordFile = Path.Combine(Constants.AppDataFolder,Constants.passwordFileName);
                    string[] loginInfo = File.ReadAllText(passwordFile).Split(",");
                    //check for no repeating usernames + add a number to it if there are repeats
                    int numAdd = 0;
                    for (int i = 0; i < loginInfo.Length; i += 3)
                    {
                        if (loginInfo[i].Equals(username + (numAdd > 0? numAdd.ToString() : "")))
                        {
                            numAdd += 1;
                        }
                    }
                    if (numAdd > 0)
                    {
                        username += numAdd.ToString();
                    }
                    File.WriteAllText(passwordFile, String.Join(",", loginInfo) + "," + username + "," + username + ",0");
                    // write to json
                    string toWrite = JsonSerializer.Serialize(uInfo);
                    string uInfoFile = Path.Combine(Constants.userPreferencesFolder, username + ".json");
                    File.WriteAllText(uInfoFile, toWrite);
                }
            }


            // write password file here

            // alert admin that it's done here, possibly email users their account information?
        }

        private void MassConsultAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
