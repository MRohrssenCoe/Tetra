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
        string[] users;
        string[] pswds;
        public Form1()
        {
            String usersPasswords = File.ReadAllText(passwordFileString);
            Debug.WriteLine(usersPasswords);
            tokens = usersPasswords.Split(',');
            bool flipflop = true;
            foreach (String token in tokens)
            {
                Debug.WriteLine(token);
                //tryign to sort users and passwords into separate arrays
                if (flipflop)
                {
                    //users.Append(token);
                } else
                {
                    //pswds.Append(token);
                }
                flipflop = !flipflop; // can't you iterate by 2s in c#?
            }
            Debug.WriteLine(users);
            Debug.WriteLine(pswds);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username.Length == 0 || password.Length == 0){
                MessageBox.Show("Username/Password cannot be empty!");
            }

            else {
                // TODO: validate username/password from database here - show error if incorrect, otherwise load appropriate dashboard
                
                ScheduleForm f2 = new ScheduleForm();
                f2.Show();
                //Form3 f3 = new Form3();
                //f3.Show();
            }

            // remove this later - debugging only
            Debug.WriteLine("Username : " + textBox1.Text + "\tPassword : " + textBox2.Text);
        }

        private void validate_Credentials(String username, String password)
        {
            // read in file or access database
            // look for match in username/password pair
            // return information - True/False for validity? or information about being admin/consultant based on file info? like 0 - Invalid, 1 - Admin, 2 - Consultant, etc?
        }

        private string encrypt_Password(string password)
        {
            // password encryption - if we have time
            return password;
        }
    }
}
