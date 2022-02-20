using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TetraScheduler
{
    public class Schedule
    {
        //untested
        List<Shift>[] shifts;
        int numDaysOpen = 7;
        int shiftLengthMinutes = 60;
        //Times in minutes!!!
        int dayStartTime = 540;
        int dayEndTime = 1020;
        public Schedule(int nDO, int sLM, int dST, int dET)
        {
            numDaysOpen = nDO;
            shiftLengthMinutes = sLM;
            dayStartTime = dST;
            dayEndTime = dET;
            shifts = new List<Shift>[numDaysOpen];
            for (int j = 0; j < numDaysOpen; j++)
            {
                shifts[j] = new List<Shift>();

                for (int i = dayStartTime; i < dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
                    shift.startTime = i;
                    shift.endTime = i + shiftLengthMinutes;
                    shifts[j].Add(shift);
                }
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
    }
}
