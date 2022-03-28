using System;
using System.Collections.Generic;
using System.Text;

//Container class to serialize options that the administrators can select. Contains: Desired consecutive shifts,
//list of shifts which are busy, hours that the writing center is open, number of consultants in a normal shift vs. a busy shift,
//path to export file to, if majors should be mixed, if semesters of experience should be mixed, if year in school should be mixed


namespace TetraScheduler
{
    public class AdminOptions
    {
        public List<Shift> BusyShifts { get; set; }
        public int DesiredConsecutiveShifts { get; set; }
        public int MaxConsultantsPerShift { get; set; }
        public int MaxConsultantsPerBusyShift { get; set; }
        public int[] OpenTimes { get; set; }
        public int[] CloseTimes { get; set; }
        public int ShiftLengthMinutes { get; set; }
        public bool[] daysOpen { get; set; }
        public bool MixMajors { get; set; }
        public bool MixExperience { get; set; }
        public bool MixYear { get; set; }
        public DateTime lastUpdatedTime { get; set; }

    }
}
