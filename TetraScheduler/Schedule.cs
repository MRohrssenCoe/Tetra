﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


//TODO update to add constructer that uses an array of start and end times
namespace TetraScheduler
{
    public class Schedule
    {
        public List<Shift>[] shifts { get; set; }
        public int numDaysOpen { get; set; } = 7;
        public int shiftLengthMinutes { get; set; } = 60;
        //Times in minutes!!!
        public int dayStartTime { get; set; } = 540;
        public int dayEndTime { get; set; } = 1020;
        public Schedule(int nDO, int sLM, int dST, int dET)
        {
            numDaysOpen = nDO;
            shiftLengthMinutes = sLM;
            dayStartTime = dST;
            dayEndTime = dET;
            shifts = new List<Shift>[numDaysOpen];
            //initializing schedule with proper number of shifts
            for (int j = 0; j < numDaysOpen; j++)
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
        public Schedule(int[] daysOpen, int shiftLength, int[] startTimes, int[] endTimes)
        {
            numDaysOpen = daysOpen.Length;
            shiftLengthMinutes = shiftLength;
            shifts = new List<Shift>[numDaysOpen];
            //create a list of shifts for each day.
            //count how far into the daysOpen array we are so that we can use the coreesponding starting and ending times
            int counter = 0;
            foreach(int dayNum in daysOpen)
            {
                //set the days start time according to the inputted array
                int curTimeCount = startTimes[counter];
                while (curTimeCount < endTimes[counter])
                {
                    Shift s = new Shift();
                    s.startTime = curTimeCount;
                    s.endTime = curTimeCount + shiftLengthMinutes;
                    s.day = daysOpen[counter];
                    shifts[counter].Add(s);
                    curTimeCount += shiftLengthMinutes;
                }
                counter++;
            }
        }
        public Schedule()
        {
            shifts = new List<Shift>[numDaysOpen];
            for (int j = 0; j < numDaysOpen; j++)
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

        public void AssignUser(string fn, string ln, int day, int shiftNumber) // todo: change fn/ln to user objects
        {
            shifts[day][shiftNumber].AddUser(fn, ln);
        }
        public void RemoveUser(string fn, string ln, int day, int shiftNumber)
        {
            shifts[day][shiftNumber].RemoveUser(fn, ln);
        }
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("DaysOpen={0}, DayStartTime={1}, DayEndTime={2}", this.numDaysOpen, this.dayStartTime, this.dayEndTime));
            for (int i=0; i < this.numDaysOpen; i++)
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
            for (int i = 0; i < this.numDaysOpen; i++)
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
        public List<Shift> GetShiftsForUser(string firstName, string lastName)
        {
            List<Shift> shiftsOut = new List<Shift>();

            for (int j = 0; j < numDaysOpen; j++)
            {
                List<Shift> day = shifts[j];
                foreach(Shift s in day)
                {
                    if (s.UserAssigned(firstName, lastName))
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
            // gets shifts from our list corresponding to shifts at same time in otherShifts list - ASSUMES IN ORDER, UNTESTED
            List<Shift> newArray = new List<Shift>();
            int theirIndex = 0;
            Shift currentTheirs;

            // fuck double for loops idc about efficiency
            List<Shift> ourArray = toLinearArray();
            int ourIndex = 0;
            Shift currentOurs;

            // compare each shift to each other - probably faster ways to do this
            while (theirIndex < otherShifts.Count && ourIndex < ourArray.Count)
            {
                currentTheirs = otherShifts[theirIndex];
                currentOurs = ourArray[ourIndex];

                // relevant comparisons
                if (currentOurs.day == currentTheirs.day && currentOurs.startTime == currentTheirs.startTime && currentOurs.endTime == currentTheirs.endTime)
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
    }
}
