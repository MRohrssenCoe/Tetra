using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// setting up a project directory
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string tetraFolder = Path.Combine(folder, "TetraScheduler");
            Directory.CreateDirectory(tetraFolder);
            string pswdFile = Path.Combine(tetraFolder, "SchedulerPasswords.txt");
            string scheduleFile = Path.Combine(tetraFolder, "TetraSchedule.csv");
            if (!File.Exists(pswdFile))
            {
                FileStream fs = File.Open(pswdFile, FileMode.Create);
                //username, password, default admin flag
                String tempText = "admin,password,2";
                fs.Write(System.Text.Encoding.ASCII.GetBytes(tempText), 0, tempText.Length);
                fs.Close();
            }
            if(!File.Exists(scheduleFile))
            {
                StringBuilder sb = new StringBuilder();
                //FileStream fs = File.Open(scheduleFile, FileMode.Create);
                String tempCSV = "Weekday,Start_Time,End_Time,Consultants";
                sb.AppendLine(tempCSV);

                // remove dummy data later
                sb.AppendLine("Sunday, 2:00, 2:30, Bob");
                sb.AppendLine("Monday, 1:00, 2:00, Bob");
                sb.AppendLine("Tuesday, 3:00, 3:30, Bob");
                sb.AppendLine("Tuesday, 3:30, 4:30, Bob");
                sb.AppendLine("Wednesday, 2:00, 2:30, Bob");
                sb.AppendLine("Thursday, 2:00, 3:00, Bob");
                sb.AppendLine("Saturday, 2:00, 2:30, Bob");

                File.WriteAllText(scheduleFile, sb.ToString());
                //fs.Write(System.Text.Encoding.ASCII.GetBytes(tempCSV), 0, tempCSV.Length);
                //fs.Write(System.Text.Encoding.ASCII.GetBytes(tempCSV), 0, tempCSV.Length);




                // write some rows of shifts to practice with



                //fs.Close();
            }
            Application.Run(new LoginForm());
        }
    }
}
