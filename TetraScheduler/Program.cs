using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;

namespace TetraScheduler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            Testing t = new Testing();
            List<Shift> mine = t.generateRandomAvailability(10);
            //testingAlgo();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // setting up a project directory
            string tetraFolder = Constants.AppDataFolder;
            Directory.CreateDirectory(tetraFolder);

            //directory to store user info
            Directory.CreateDirectory(Constants.userPreferencesFolder);

            //Set up admin prefs directory
            Directory.CreateDirectory(Constants.adminPreferencesFolder);
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string scheduleFile = Path.Combine(tetraFolder, Constants.scheduleFileName);

            string path = Path.Combine(Constants.AppDataFolder, Constants.MajorsFile);


            // fill majors file with default majors
            if (!File.Exists(path))
            {
                using (var fs = File.Open(path, FileMode.OpenOrCreate))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        var majors = "Accounting,Aeronautics,Agricultural Science,Anthropology,Applied math, Applied mathematical sciences,Aquatic and fishery sciences," +
                            "Architectural design,Art,Art History,Astronomy,Astronautics,Atmospheric sciences,Biochemistry,Biology,Bioresource science and engineering," +
                            "Bioengineering,Botany,Business Administration,Chemistry,Chemical Engineering,Cinematography,Civil engineering,City planning,Comparative Literature," +
                            "Construction management,Criminal science and forensics,Creative writing,Computer engineering,Classics,Communication,Criminology,Computer science," +
                            "Drama,Digital arts,Dance,Design,Ecology,Earth and space science,Environmental engineering,Entomology,Environmental studies,Ethnic and gender studies," +
                            "Education,Earth and space sciences,English,Environmental studies and policy,Environmental science,Electrical engineering,Economics,Entrepreneurship," +
                            "Film studies,Finance,Foreign language and literature,Genetics,Geography,Geology,History,Health informatics,Industrial engineering,Informational systems," +
                            "International studies,Informatics,International business,Kinesiology,Library science,Linguistics,Music,Materials science and engineering,Mechanical engineering," +
                            "Mathematics,Medical technology,Marine biology,Management,Marketing,Neuroscience,Nursing,Oceanography,Physics,Philosophy,Physiology,Poltical Science," +
                            "Psychology,Resource management,Relgious studies,Rhetoric,Secondary Ed,Statistics,Social justice,Social welfare,Sociology,Technical Communication,";

                        sw.WriteLine(majors);
                    }
                }
            }

            // on first run - creates data files
            //TODO if someone deletes the passwords file it will regenerate the default password file, which just lets anyone become the admin.
            if (!File.Exists(pswdFile))
            {
                FileStream fs = File.Open(pswdFile, FileMode.Create);
                //username, password, default admin flag
                string orig = "password";
                string password = LoginForm.encrypt_Password(orig);
                String tempText = "admin," + password + ",2";
                fs.Write(System.Text.Encoding.ASCII.GetBytes(tempText), 0, tempText.Length);
                fs.Close();

            }
            if (!File.Exists(scheduleFile))
            {
                StringBuilder sb = new StringBuilder();
                String tempCSV = "Shift Time, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday";
                sb.AppendLine(tempCSV);

                // remove dummy data later
                // maybe add default shifts for each hour and selectively read them based on open hours
                /*sb.AppendLine("Sunday, 2:00, 2:30, 'Bob, Alice, Jane, Katya, Will, Michael, Ashley'"); // todo: figure out how to write multiple
                sb.AppendLine("Monday, 1:00, 2:00, Bob");
                sb.AppendLine("Tuesday, 3:00, 3:30, Bob");
                sb.AppendLine("Tuesday, 3:30, 4:30, Bob");
                sb.AppendLine("Wednesday, 2:00, 2:30, Bob");
                sb.AppendLine("Thursday, 2:00, 3:00, Bob");
                sb.AppendLine("Saturday, 2:00, 2:30, Bob");*/

                
                File.WriteAllText(scheduleFile, sb.ToString());
                File.SetAttributes(scheduleFile, FileAttributes.Normal);
            }
            /*
            bool[] daysOpen = new bool[7];
            daysOpen[0] = true;
            daysOpen[1] = true;
            daysOpen[2] = true;
            int[] startTimes = new int[3];
            startTimes[0] = 540;
            startTimes[1] = 540;
            startTimes[2] = 540;
            int[] endTimes = new int[3];
            endTimes[0] = 1020;
            endTimes[1] = 1020;
            endTimes[2] = 1020;
            Schedule newConstructorTest = new Schedule(daysOpen, 60, startTimes, endTimes);
            */
            // starts at login form
            Application.Run(new LoginForm());

            
        }

    }
}
