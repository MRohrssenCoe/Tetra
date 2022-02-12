﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    internal class Schedule
    {
        //untested
        List<Shift>[] shifts;
        int numDaysOpen = 5;
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

                for (int i = dayStartTime; i <= dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
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
                for (int i = dayStartTime; i <= dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
                    shifts[j].Add(shift);
                }
            }
        }
        public void AssignUser(string fn, string ln, int day, int shiftNumber)
        {
            shifts[day][shiftNumber].AddUser(fn, ln);
        }
        public void RemoveUser(string fn, string ln, int day, int shiftNumber)
        {
            shifts[day][shiftNumber].RemoveUser(fn, ln);
        }
    }
}
