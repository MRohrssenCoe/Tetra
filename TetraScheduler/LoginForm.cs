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
    public partial class LoginForm : Form
    {
        // password file path in %appdata% folder
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
        public LoginForm()
        {
            
            InitializeComponent();
            // add our logo
            // button for 'show password'?
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // login button functionality


            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username/Password cannot be empty!");
                // add more error visuals?
            }

            else
            {
                int validatationCode = validate_Credentials(username, password);
                if(validatationCode == 0)
                {
                    new ConsultantMenuForm().Show();
                }
                if (validatationCode == 1 || validatationCode == 2)
                {
                    new AdminMenuForm(username).Show();
                }
                if(validatationCode == -1)
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
        }

        //Returns a validation code for credentials. 0 is a consultant account, 1 is an admin account, and 2 is the default admin account
        private int validate_Credentials(String username, String password)
        {
            String usersPasswords = File.ReadAllText(passwordFileString);
            Debug.WriteLine(usersPasswords);
            tokens = usersPasswords.Split(',');
            for (int i = 0; i < tokens.Length; i += 3)
            {
                UsernamePassword usernamePassword = new UsernamePassword(); // do we need a struct for this?
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
