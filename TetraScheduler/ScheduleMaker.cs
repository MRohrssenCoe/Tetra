using System.Collections.Generic;
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

        public AdminOptions ao { get; set; }

        // variable for admin preferences here

        public ScheduleMaker(List<UserInfo> users, AdminOptions ao)
        {
            this.users = users; // change this later - for testing
            this.ao = ao;
            // generate s from ao
            //Schedule(int[] daysOpen, int shiftLength, int[] startTimes, int[] endTimes)
            bool[] daysOpen = ao.daysOpen;
            int shiftLength = ao.ShiftLengthMinutes;
            int[] startTimes = { ao.OpenTime, ao.OpenTime, ao.OpenTime, ao.OpenTime, ao.OpenTime, ao.OpenTime, ao.OpenTime };
            int[] endTimes = { ao.CloseTime, ao.CloseTime, ao.CloseTime, ao.CloseTime, ao.CloseTime, ao.CloseTime, ao.CloseTime };
            s = new Schedule(daysOpen, shiftLength, startTimes, endTimes);
            // add field for number of consultants in shift class? also flag for busy
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
                availabilities = sortAvailableShifts(c, availabilities);

                Debug.WriteLine("User: " + c.FirstName + " " + c.LastName + "\tAvails: " + availabilities.Count + "\tRequested: " + c.desiredWeeklyHours);
                Debug.WriteLine("Sorted shifts: ");
                Debug.WriteLine(JsonSerializer.Serialize(availabilities));
                Debug.WriteLine("Current Sched: " + s.ToString());

                int requestedHours = c.desiredWeeklyHours;
                int requestedMinutes = requestedHours * 60; // maybe useful for comparing to shift times?

                while (requestedMinutes >= ao.ShiftLengthMinutes && availabilities.Count > 0) // assuming doesn't exceed the sum of all of our shifts...
                {
                    // schedule at best fit shift
                    Shift firstShift = availabilities[0]; // TODO: add a catch here for edge cases (alert to say that user n couldn't get all their hours?)

                    if (firstShift.UserAssigned(c)) // this should only happen when scheduling adjacencies - maybe fixed but scared to remove lol
                    {
                        availabilities.Remove(firstShift);
                        continue;
                    }

                    firstShift.AddUser(c);
                    availabilities.Remove(firstShift);
                    // decrement their needed times
                    requestedMinutes -= (firstShift.endTime - firstShift.startTime);

                    /* adjacent shift portion of the code! */
                    List<Shift> adjacencyQueue = new List<Shift>(); // stores adj shifts - not really a queue but whatever
                    int maxConseqShifts = ao.DesiredConsecutiveShifts -1;

                    List<Shift> adjOpts = s.getAdjacentShifts(firstShift);
                    foreach (Shift opt in adjOpts) // only add adjacencies they're free for
                    {
                        if (availabilities.Contains(opt)){
                            adjacencyQueue.Add(opt);
                        }
                    }

                    while (maxConseqShifts > 0 && requestedMinutes >= ao.ShiftLengthMinutes && adjacencyQueue.Count > 0)
                    {
                        adjacencyQueue = sortAvailableShifts(c, adjacencyQueue);
                        Shift nextShift = adjacencyQueue[0];

                        if (nextShift.users.Count >= ao.MaxConsultantsPerShift) // don't overschedule if no good adjacencies
                        {
                            break;
                        }

                        if (nextShift.UserAssigned(c))  // skip extra added shifts
                        {
                            adjacencyQueue.Remove(nextShift);
                        }
                        else
                        {
                            nextShift.AddUser(c);
                            adjacencyQueue.Remove(nextShift);
                            requestedMinutes -= (nextShift.endTime - nextShift.startTime);
                            maxConseqShifts--;
                            List<Shift> opts = s.getAdjacentShifts(nextShift);
                            foreach (Shift opt in opts) // only add adjacencies they're free for
                            {
                                if (availabilities.Contains(opt))
                                {
                                    adjacencyQueue.Add(opt);
                                }
                            }
                        }
                    }

                    // remove remaining adjacencies from options
                    if (adjacencyQueue.Count > 0)
                    {
                        foreach (Shift shift in adjacencyQueue)
                        {
                            if (availabilities.Contains(shift))
                            {
                                availabilities.Remove(shift);
                            }
                        }
                    }
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
        private List<Shift> sortAvailableShifts(UserInfo c, List<Shift> availabilities)
        {
            // mix majors/etc in here later
            /*availabilities.Sort((Shift s1, Shift s2) =>
                s1.users.Count.CompareTo(s2.users.Count)
            );*/
            return availabilities.OrderBy(x => x.users.Count).ThenBy(x => sortWeight(x, this.ao, c)).ToList();
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

        public int sortWeight(Shift s, AdminOptions ao, UserInfo ui)
        {
            int value = 0; // lower value = better fit


            if (ao.MixMajors)
            {
                // get num matching majors - want to minimize matches
                string[] userMajors = ui.majors;
                int numMatching = 0;
                foreach (string major in userMajors)
                {
                    numMatching += s.getNumMajors(major);
                }
                value += numMatching;
            }

            if (ao.MixExperience)
            {
                // get max distance from current SOE
                int userExp = ui.expSemesters;
                int maxExpDif = s.maxDistanceSemOfExp(userExp);
                value += (-1 * maxExpDif); // add negative - higher dif = better fit
            }

            if (ao.MixYear)
            {
                // get max distance from school year
                int yearInSchool = ui.coeYear;
                int maxYearDif = s.maxDistanceCoeYear(yearInSchool);
                value += (-1 * maxYearDif); // add negative - higher dif = better fit
            }

            return value;
        }

        //write it to a csv
        public static int ScheduleToCSV(Schedule s)
        {
            List<List<string>> ourCSV = new List<List<string>>();


            // get min start time

            int minStart = 24 * 60;
            int maxClose = 0;
            foreach(List<Shift> shiftList in s.shifts)
            {
                if (shiftList.Count == 0)
                {

                }
                else
                {
                    if (shiftList[0].startTime < minStart)
                    {
                        minStart = shiftList[0].startTime;
                    }
                    if (shiftList[shiftList.Count-1].endTime > maxClose)
                    {
                        maxClose = shiftList[shiftList.Count - 1].endTime;
                    }
                }
            }

            /*int minStart = 540;
            int maxClose = 1020;*/
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

            string schedFile = Path.Combine(Constants.AppDataFolder, Constants.scheduleFileName);
            
            File.WriteAllLines(schedFile, ourCSV.Select(x => string.Join(",", x)));
            return 0;
        }
    }
}
