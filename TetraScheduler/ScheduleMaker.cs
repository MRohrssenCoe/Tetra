﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TetraScheduler
{
    class ScheduleMaker
    {
        public List<UserInfo> users { get; set; }
        public int maxConseqShifts { get; set; }

        public Schedule s { get; set; } // final schedule - can be set before generateSchedule()

        // variable for admin preferences here

        public ScheduleMaker(List<UserInfo> users)
        {
            this.users = users; // change this later - for testing
            this.s = null;
        }
        public Schedule generateSchedule()
        {

            // check that we have a list of consultants, admin preferences, etc. requirements

            if (this.s == null)
            {
                this.s = new Schedule();
            }

            // sort users according to our priorities - fewest availabilities first
            sortUsers();


            // iterate over each consultant
            foreach (UserInfo c in users)
            {
                // gets list of shifts from our schedule that we could possibly schedule c in
                List<Shift> availabilities = s.matchAvailabilities(sortShiftsConseq(c.availability));

                // sort availabilities based on best fit
                sortAvailableShifts(c, availabilities);

                Debug.WriteLine("User: " + c.FirstName + " " + c.LastName + "\tAvails: " + availabilities.Count);
                Debug.WriteLine("Sorted shifts: ");
                Debug.WriteLine(JsonSerializer.Serialize(availabilities));

                int requestedHours = c.desiredWeeklyHours;
                int requestedMinutes = requestedHours * 60; // maybe useful for comparing to shift times?

                while (requestedMinutes > 0) // assuming doesn't exceed the sum of all of our shifts...
                {
                    // schedule at best fit shift
                    Shift firstShift = availabilities[0];
                    firstShift.AddUser(c.FirstName, c.LastName);
                    availabilities.Remove(firstShift);
                    // decrement their needed times
                    requestedMinutes -= (firstShift.endTime - firstShift.startTime);

                    // here we would check for adjacent shifts in their availabilities after checking for that preference
                    
                }
            }

            Debug.WriteLine("Final Schedule: ");
            Debug.WriteLine(JsonSerializer.Serialize(s));
            return s;
        }
        private void sortUsers()
        {
            // sorts users from fewest -> most availability times
            this.users.Sort((UserInfo u1, UserInfo u2) => u1.availability.Count.CompareTo(u2.availability.Count));
        }
        private List<Shift> sortShiftsConseq(List<Shift> s)
        {
            return s.OrderBy(x => x.day).ThenBy(x => x.startTime).ToList();
        }
        private void sortAvailableShifts(UserInfo c, List<Shift> availabilities)
        {
            // ignore admin preferences + user major/yr/etc for now - just sort by shifts without many users shift
            availabilities.Sort((Shift s1, Shift s2) =>
                s1.users.Count.CompareTo(s2.users.Count)
            );
        }
        public static List<UserInfo> usersFromDir(string folderPath)
        {
            // convert user info files to user objects?
            List<UserInfo> u = new List<UserInfo>();
            string[] fnames = Directory.GetFiles(Constants.userPreferencesFolder);

            foreach (string fileName in fnames)
            {
                Debug.WriteLine(fileName);
                string uInfoJsonString = File.ReadAllText(fileName);
                UserInfo uInfo = JsonSerializer.Deserialize<UserInfo>(uInfoJsonString);
                u.Add(uInfo);
            }

            return u;
        }
        //This method will return a list of shifts that are adjacent to startingShift from the passed in list of shifts.
        //Make sure to check if value returned is -1 before using. -1 means adjacent shift not found.
        public static int getNextAdjAvailabilityIndex(List<Shift> availIn, Shift startingShift)
        {
            int indexofNext = -1;
            foreach (Shift s in availIn)
            {
                if (s.startTime == startingShift.endTime)
                {
                    indexofNext = availIn.IndexOf(s);
                }
            }
            return indexofNext;
        }

        //write it to a csv
        public static int ScheduleToCSV(Schedule s)
        {
            List<List<string>> ourCSV = new List<List<string>>();
            // get min start time
            int minStart = 540;
            int maxClose = 1020;
            int shiftLength = s.shiftLengthMinutes;
            List<Shift>[] shifts = s.shifts;

            //print first row headers
            string[] headers = { "Time", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            ourCSV.Add(new List<string>(headers));
            // start iterating over 7 shift lists - PROBLEM, no indicating which days are full in the Schedule class
            
            for (int i = minStart; i < maxClose; i += shiftLength) // loops numShifts times
            {
                List<string> csvRow = new List<string>(); // current row
                string rowLabel = Shift.minutesToHr(i, true) + "-" + Shift.minutesToHr(i + 60, true);
                csvRow.Add(rowLabel);
                foreach (List<Shift> day in shifts)  // loops 7 times
                {
                    int j = 0;
                    bool found = false;
                    // can optimize this by storing index of last found shift but idk... 
                    while (j < day.Count && !found) // loops max numShifts times... we love O(n2) runtimes lol
                    {
                        if (day[j].startTime == i)
                        {
                            found = true;
                            csvRow.Add(day[j].UsersAsText());
                        }
                        else
                        {
                            j++;
                        }
                    }

                    if (!found)
                    {
                        csvRow.Add("");
                    }
                }
                ourCSV.Add(csvRow); // add row to full list
            }

            File.WriteAllLines(Path.Combine(Constants.AppDataFolder,"TestCSV.csv"), ourCSV.Select(x => string.Join(",", x)));
            return 0;
        }
    }
}
