using System;
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
            string specificFolder = Path.Combine(folder, "TetraScheduler");
            Directory.CreateDirectory(specificFolder);
            string pswdFile = Path.Combine(specificFolder, "SchedulerPasswords.txt");
            if (!File.Exists(pswdFile))
            {
                FileStream fs = File.Open(pswdFile, FileMode.Create);
                //username, password, default admin flag
                String tempText = "admin,password,2";
                fs.Write(System.Text.Encoding.ASCII.GetBytes(tempText), 0, tempText.Length);
                fs.Close();
            }
            
            Application.Run(new Form1());
        }
    }
}
