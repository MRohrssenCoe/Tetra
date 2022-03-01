﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace TetraScheduler
{
    class ScheduleMaker
    {
        public List<UserInfo> users { get; set; }
        public AdminOptions adminOptions { get; set; }

        public Schedule s { get; } // our schedule

        public int maxConseqShifts { get; set; }


        public ScheduleMaker(List<UserInfo> users, AdminOptions adminOptions)
        {
            this.users = users;
            this.adminOptions = adminOptions;
            this.maxConseqShifts = adminOptions.DesiredConsecutiveShifts;

            // set schedule boundaries from admin Options
        }


        public Schedule generateSchedule()
        {

            // check that we have a list of consultants, admin preferences, etc. requirements

            Schedule s = new Schedule(); // generate based on admin options

            // sort users according to our priorities - fewest availabilities first
            sortUsers();


            // iterate over each consultant
            foreach(UserInfo c in users)
            {
                // gets list of shifts from our schedule that we could possibly schedule c in
                List<Shift> availabilities = s.matchAvailabilities(sortShiftsConseq(c.availability)); // maybe remove conseq sort if we make matchAvailabilities better

                // sort availabilities based on best fit
                sortAvailableShifts(c, availabilities);


                // debugging
                Debug.WriteLine("User: " + c.FirstName + " " + c.LastName + "\tAvails: " + availabilities.Count);
                Debug.WriteLine("Sorted shifts: ");
                Debug.WriteLine(JsonSerializer.Serialize(availabilities));


                int requestedHours = c.desiredWeeklyHours;
                int requestedMinutes = requestedHours * 60; // maybe useful for comparing to shift times? or just set standard shift time

                while (requestedMinutes > 0) // assuming doesn't exceed the sum of all of our shifts...
                {
                    // schedule at best fit shift
                    Shift firstShift = availabilities[0];
                    firstShift.AddUser(c.FirstName, c.LastName);
                    availabilities.Remove(firstShift);
                    // decrement their needed times
                    requestedMinutes -= (firstShift.endTime - firstShift.startTime);


                    // here we would check for adjacent shifts in their availabilities after checking for that preference

                    /*      PSEUDOCODE      */

                    // count = 1                                                                                <- counts consecutive shifts
                    // shiftOptions = new List<Shift>();
                    // shiftOptions.append(getPrev(availabilities, firstShift))                                 <- checks for availability immediately before/after
                    // shiftOptions.append(getPost(availabilities, firstShift))
                    // 
                    // while count < maxConseqShifts and requestedMinutes > 0 and len(shiftOptions >0):         <- check to not exceed limits                
                    //  sortAvailableShifts(shiftOptions)                                                       <- sort our options - we can avoid this by writing less shitty code but idk
                    //  best = shiftOptions[0]
                    //  best.AddUser(c.FirstName, c.LastName)                                                   <- assign the user to the shift that is a better option for them
                    //  
                    //  count += 1
                    //  requestedMinutes -= (subtract number of minutes for this shift here)
                    //
                    //  shiftOptions.append(getPrev(), getPost())                                               <- update availabilities - need to add check to not recheck the same shifts again
                    //
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

        private List<Shift> sortShiftsConseq(List<Shift> shifts)
        {
            return shifts.OrderBy(x => x.day).ThenBy(x => x.startTime).ThenBy(x => x.endTime).ToList();
        }

        private void sortAvailableShifts(UserInfo c, List<Shift> availabilities)
        {
            // ignore admin preferences + user major/yr/etc for now - just sort by shifts without many users shift
            availabilities.Sort((Shift s1, Shift s2) => 
                s1.users.Count.CompareTo(s2.users.Count)
            );


            //availabilities.OrderBy(x => x.users.Count).ThenBy(x => x.numMajors(c.majors));
        }

        public static List<UserInfo> usersFromDir(string folderPath)
        {
            // convert user info files to user objects?
            List<UserInfo> u = new List<UserInfo>();
            string[] fnames = Directory.GetFiles(Constants.userPreferencesFolder);

            foreach(string fileName in fnames)
            {
                Debug.WriteLine(fileName);
                string uInfoJsonString = File.ReadAllText(fileName);
                UserInfo uInfo = JsonSerializer.Deserialize<UserInfo>(uInfoJsonString);
                u.Add(uInfo);
            }

            return u;
        }

        public static void scheduleToCSV(Schedule s, string path)
        {
            //todo = get min/max opening and closing times to determine how many rows to write
            //
        }
    }
}
