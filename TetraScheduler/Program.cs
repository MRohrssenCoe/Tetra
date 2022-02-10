using System;
using System.Diagnostics;
using System.IO;
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
                FileStream fs = File.Open(scheduleFile, FileMode.Create);
                String tempCSV = "Weekday,Start_Time,End_Time,Consultants";
                fs.Write(System.Text.Encoding.ASCII.GetBytes(tempCSV), 0, tempCSV.Length);
                fs.Close();
            }
            Application.Run(new LoginForm());
        }
    }
}
