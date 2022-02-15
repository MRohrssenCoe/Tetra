using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// setting up a project directory

            string tetraFolder = Constants.AppDataFolder;
            Directory.CreateDirectory(tetraFolder);
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
                //FileStream fs = File.Open(scheduleFile, FileMode.Create);
                String tempCSV = "Weekday,Start_Time,End_Time,Consultants";
                sb.AppendLine(tempCSV);

                // remove dummy data later
                // maybe add default shifts for each hour and selectively read them based on open hours
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
                //fs.Close();
            }
            // starts at login form
            Application.Run(new LoginForm());
        }
    }
}
