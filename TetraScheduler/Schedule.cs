using System;
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
        int dayStartTime = 540;
        int dayEndTime = 1020;
        public Schedule(int nDO, int sLM, int dST, int dET)
        {
            numDaysOpen = nDO;
            shiftLengthMinutes = sLM;
            dayStartTime = dST;
            dayEndTime = dET;
            shifts = new List<Shift>[numDaysOpen];
            for (int j = 0; j <= numDaysOpen; j++)
            {
                for (int i = dayStartTime; i <= dayEndTime; i += shiftLengthMinutes)
                {
                    Shift shift = new Shift();
                    shifts[j].Add(shift);
                }
            }
        }
    }
}
