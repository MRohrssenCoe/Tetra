using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


//TODO update to add constructer that uses an array of start and end times
namespace TetraScheduler
{
    public class Schedule
    {
        public List<Shift>[] shifts { get; set; }
        public int shiftLengthMinutes { get; set; } = 60;
        //Times are in minutes, starting with 0 at 12 AM. 9 AM = 540, 10 AM = 600, etc.
        public int dayStartTime { get; set; } = 540;
        public int dayEndTime { get; set; } = 1020;
        public bool[] daysOpen = {true, true, true, true, true, true, true};
        public Schedule(int sLM, int dST, int dET)
        {
            shiftLengthMinutes = sLM;
            dayStartTime = dST;
            dayEndTime = dET;
            shifts = new List<Shift>[7];
            //initializing schedule with proper number of shifts
            for (int j = 0; j < 7; j++)
            {
                shifts[j] = new List<Shift>();

                for (int i = dayStartTime; i < dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
                    shift.startTime = i;
                    shift.endTime = i + shiftLengthMinutes;
                    shift.day = j;
                    shifts[j].Add(shift);
                }
            }
        }
        //Constructor that has more flexibility to allow for different starting and ending times, and specific days being open. 
        public Schedule(bool[] daysOpen, int shiftLength, int[] startTimes, int[] endTimes)
        {
            //make sure all arrays are the same length. If they aren't, we will have index OOB exceptions galore.
            if(daysOpen.Length != startTimes.Length || daysOpen.Length != endTimes.Length)
            {
                //throw error
                throw new ArgumentException("daysOpen[], startTimes[], and endTimes[] must all be equal in length!");
            }
            shiftLengthMinutes = shiftLength;
            shifts = new List<Shift>[7];
            //create a list of shifts for each day.
            //count how far into the daysOpen array we are so that we can use the coreesponding starting and ending times
            int counter = 0;
            foreach(bool day in daysOpen)
            {
                shifts[counter] = new List<Shift>();
                if (!day) {
                    counter++;
                    continue;
                }
                //set the days start time according to the inputted array
                int curTimeCount = startTimes[counter];
                while (curTimeCount < endTimes[counter])
                {
                    Shift s = new Shift();
                    s.startTime = curTimeCount;
                    s.endTime = curTimeCount + shiftLengthMinutes;
                    s.day = counter;
                    shifts[counter].Add(s);
                    curTimeCount += shiftLengthMinutes;
                }
                counter++;
            }
        }
        public Schedule()
        {
            shifts = new List<Shift>[7];
            for (int j = 0; j < 7; j++)
            {
                shifts[j] = new List<Shift>();
                for (int i = dayStartTime; i < dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
                    shift.startTime = i;
                    shift.endTime = i + shiftLengthMinutes;
                    shift.day = j;
                    shifts[j].Add(shift);
                }
            }
        }

        //Assign a user to a shift. Day = which index in shifts the desired shift is in. shiftNumber = how many shifts have come before
        //that shift, starting at 0. 
        public void AssignUser(UserInfo ui, int day, int shiftNumber) // todo: change fn/ln to user objects
        {
            shifts[day][shiftNumber].AddUser(ui);
        }
        //Assign a user to a shift based on the day and starting time of the shift
        public void AssignUser(UserInfo ui, int day, int hour, int minute)
        {
            int tempStartTime = minute + (hour * 60);
            foreach(Shift s in shifts[day])
            {
                if(s.startTime == tempStartTime)
                {
                    s.AddUser(ui);
                }
            }

        }
        //Remove a user to a shift. Day = which index in shifts the desired shift is in. shiftNumber = how many shifts have come before
        //that shift, starting at 0. 
        public void RemoveUser(UserInfo ui, int day, int shiftNumber)
        {
            shifts[day][shiftNumber].RemoveUser(ui);
        }
        //Remove a user from a shift starting at a specific time on a specific day.
        public void RemoveUser(UserInfo ui, int day, int hour, int minute)
        {
            int tempStartTime = minute + (hour * 60);
            foreach (Shift s in shifts[day])
            {
                if (s.startTime == tempStartTime)
                {
                    s.RemoveUser(ui);
                }
            }

        }
        override public string ToString()
        {
            int numDaysOpen = 0;
            foreach (bool day in daysOpen) { 
                if(day)
                    numDaysOpen++;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("DaysOpen={0}, DayStartTime={1}, DayEndTime={2}", numDaysOpen, this.dayStartTime, this.dayEndTime));
            for (int i=0; i < numDaysOpen; i++)
            {
                foreach (Shift s in shifts[i])
                {
                    sb.Append(String.Format("Day={0} Start={1} End={2} Users={3}\n", i, s.startTime, s.endTime, s.UsersAsText())); // add consultant names
                }
            }
            return sb.ToString();
        }
        public ArrayList getFilledShifts()
        {
            // untested
            ArrayList fullShifts = new ArrayList();
            // returns only shifts that have at least one consultant scheduled
            for (int i = 0; i < 7; i++)
            {
                ArrayList day = new ArrayList();
                foreach (Shift s in shifts[i]) // can we just include a variable for the day in the shift class????
                {
                    if (s.UsersAsText() != "")
                    {
                        day.Add(s);
                    }
                }
                fullShifts.Add(day);
            }
            return fullShifts;
        }

        //Method to get all shifts from a schedule that a User is assigned to.
        public List<Shift> GetShiftsForUser(UserInfo ui)
        {
            List<Shift> shiftsOut = new List<Shift>();

            for (int j = 0; j < 7; j++)
            {
                List<Shift> day = shifts[j];
                foreach(Shift s in day)
                {
                    if (s.UserAssigned(ui))
                    {
                        shiftsOut.Add(s);
                    }
                }
            }
            return shiftsOut;
            
        }

        public List<Shift> toLinearArray()
        {
            // 1d array of our shifts - UNTESTED
            List<Shift> newArray = new List<Shift>();

            foreach(List<Shift> day in shifts)
            {
                foreach(Shift s in day)
                {
                    newArray.Add(s);
                }
            }

            return newArray;
        }

        public List<Shift> matchAvailabilities(List<Shift> otherShifts)
        {
            // gets shifts from our list corresponding to shifts at same time in otherShifts list - ASSUMES IN ORDER
            List<Shift> newArray = new List<Shift>();
            int theirIndex = 0;
            Shift currentTheirs;

            List<Shift> ourArray = toLinearArray();
            int ourIndex = 0;
            Shift currentOurs;

            // compare each shift to each other - probably faster ways to do this

            while (theirIndex < otherShifts.Count && ourIndex < ourArray.Count)
            {

                currentTheirs = otherShifts[theirIndex];

                currentOurs = ourArray[ourIndex];

                while (currentTheirs < currentOurs) // if they pick shifts outside of our time range this should skip those shifts
                {
                    theirIndex++;
                    if (theirIndex >= otherShifts.Count)
                    {
                        break;
                    }
                    currentTheirs = otherShifts[theirIndex];  
                }

                if (currentOurs == currentTheirs)
                {
                    newArray.Add(currentOurs);
                    // move to find their next shift
                    theirIndex++;
                }
                // check against our next shift
                ourIndex++;
            }
            
            return newArray;
        }
        public List<Shift> getAdjacentShifts(Shift s)
        {
            List<Shift> adjacents = new List<Shift> ();
            foreach(List<Shift> ls in shifts)
            {
                foreach(Shift z in ls)
                {
                    if (z.day == s.day && z.startTime == s.startTime && z.endTime == s.endTime)
                    {
                        int index = ls.IndexOf(z);
                        if(index - 1 >= 0)
                        {
                            adjacents.Add(ls[index-1]);
                        }
                        if(index + 1 < ls.Count)
                        {
                            adjacents.Add(ls[index+1]);
                        }
                    }
                }
            }   
            return adjacents;
        }
    }
}
