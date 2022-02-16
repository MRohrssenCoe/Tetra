using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TetraScheduler
{

    //I know Terry said no global variables, but these are constants :^)
    //For when we need to change these files from locations other than Program.cs
    //Should minimize typo risk.
    public static class Constants
    {
        private static string SpecificFolder = "TetraScheduler";
        public static string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SpecificFolder);
        public static string passwordFileName = "SchedulerPasswords.txt";
        public static string scheduleFileName = "TetraSchedule.csv";
    }
}
