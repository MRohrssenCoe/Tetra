using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class Form1 : Form
    {
        String passwordFileString = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "TetraScheduler/SchedulerPasswords.txt"
            );
        string[] tokens;
        struct UsernamePassword
        {
            public string username;
            public string password;
            //0 for consultant, 1 for admin, 2 for default admin
            public string accountType;
        }
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username/Password cannot be empty!");
            }

            else
            {
                int validatationCode = validate_Credentials(username, password);
                //TODO: make this split into different logins
                if (validatationCode == 0 || validatationCode == 1 || validatationCode == 2)
                {
                    ScheduleForm f2 = new ScheduleForm();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
        }

        private int validate_Credentials(String username, String password)
        {
            // read in file or access database
            // look for match in username/password pair
            // return information - True/False for validity? or information about being admin/consultant based on file info? like 0 - Invalid, 1 - Admin, 2 - Consultant, etc?
            //load usernames and passwords while looking for match.
            String usersPasswords = File.ReadAllText(passwordFileString);
            Debug.WriteLine(usersPasswords);
            tokens = usersPasswords.Split(',');
            for (int i = 0; i < tokens.Length; i += 3)
            {
                UsernamePassword usernamePassword = new UsernamePassword();
                usernamePassword.username = tokens[i];
                usernamePassword.password = tokens[i + 1];
                usernamePassword.accountType = tokens[i + 2];

                if(usernamePassword.username == username && usernamePassword.password == password)
                {
                    if(usernamePassword.accountType == "0")
                    {
                        return 0;
                    }
                    if(usernamePassword.accountType == "1")
                    {
                        return 1;
                    }
                    if(usernamePassword.accountType == "2")
                    {
                        return 2;
                    }
                }
            }
            return -1;
        }


        private string encrypt_Password(string password)
        {
            // password encryption - if we have time
            return password;
        }
    }
}
