using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TetraScheduler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            //testingAlgo();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // setting up a project directory
            string tetraFolder = Constants.AppDataFolder;
            Directory.CreateDirectory(tetraFolder);

            //directory to store user info
            Directory.CreateDirectory(Constants.userPreferencesFolder);

            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string scheduleFile = Path.Combine(tetraFolder, Constants.scheduleFileName);
            

            // on first run - creates data files
            //TODO if someone deletes the passwords file it will regenerate the default password file, which just lets anyone become the admin.
            if (!File.Exists(pswdFile))
            {
                FileStream fs = File.Open(pswdFile, FileMode.Create);
                //username, password, default admin flag
                String tempText = "admin,password,2";
                fs.Write(System.Text.Encoding.ASCII.GetBytes(tempText), 0, tempText.Length);
                fs.Close();

            }
            if (!File.Exists(scheduleFile))
            {
                StringBuilder sb = new StringBuilder();
                String tempCSV = "Weekday,Start_Time,End_Time,Consultants";
                sb.AppendLine(tempCSV);

                // remove dummy data later
                // maybe add default shifts for each hour and selectively read them based on open hours
                sb.AppendLine("Sunday, 2:00, 2:30, 'Bob, Alice, Jane, Katya, Will, Michael, Ashley'"); // todo: figure out how to write multiple
                sb.AppendLine("Monday, 1:00, 2:00, Bob");
                sb.AppendLine("Tuesday, 3:00, 3:30, Bob");
                sb.AppendLine("Tuesday, 3:30, 4:30, Bob");
                sb.AppendLine("Wednesday, 2:00, 2:30, Bob");
                sb.AppendLine("Thursday, 2:00, 3:00, Bob");
                sb.AppendLine("Saturday, 2:00, 2:30, Bob");

                
                File.WriteAllText(scheduleFile, sb.ToString());

            }

            int[] daysOpen = new int[3];
            daysOpen[0] = 1;
            daysOpen[1] = 2;
            daysOpen[2] = 3;
            int[] startTimes = new int[3];
            startTimes[0] = 540;
            startTimes[1] = 540;
            startTimes[2] = 540;
            int[] endTimes = new int[3];
            endTimes[0] = 1020;
            endTimes[1] = 1020;
            endTimes[2] = 1020;
            Schedule newConstructorTest = new Schedule(daysOpen, 60, startTimes, endTimes);

            // starts at login form
            Application.Run(new LoginForm());

            
        }


        static void testingAlgo()
        {
            // make some users
            List<UserInfo> users = ScheduleMaker.usersFromDir(Constants.userPreferencesFolder);
            ScheduleMaker sm = new ScheduleMaker(users);
            sm.generateSchedule();
            // uhhhhhh idk how to write tests...
        }
    }
}
