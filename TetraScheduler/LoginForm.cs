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
            textBox1.Text = "Username...";
            textBox2.Text = "Password...";
            textBox2.PasswordChar = '\0';
            // add our logo
            // button for 'show password'?
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void loginProcess()
        {
            // login button functionality - moved from onClick method so that Enter key can login too


            String username = textBox1.Text;
            String password = textBox2.Text;
            bool successfulLogin = false;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username/Password cannot be empty!");
                // add more error visuals?
            }

            else
            {
                int validationCode = validate_Credentials(username, password);
                //TODO: make this split into different logins
                if (validationCode == 0)
                {
                    new ConsultantMenuForm(username).Show();
                    successfulLogin = true;
                }
                if (validationCode == 1)
                {
                    new AdminMenuForm(username).Show();
                    successfulLogin = true;
                }
                if (validationCode == 2)
                {
                    bool passwordIsDefault = true;
                    while (passwordIsDefault)
                    {
                        PasswordChangeBox changePswdBox = new PasswordChangeBox();
                        changePswdBox.ShowDialog();
                        if (changePswdBox.DialogResult == DialogResult.OK)
                        {
                            //write new user and password to file
                            //overwrites entire file!!!
                            string pswdFile = Path.Combine(Constants.AppDataFolder, Constants.passwordFileName);
                            FileStream fs = File.Open(pswdFile, FileMode.Truncate);
                            string tempText = changePswdBox.UsernameReturn + "," + changePswdBox.PasswordReturn + "," + "1";
                            fs.Write(Encoding.ASCII.GetBytes(tempText), 0, tempText.Length);
                            fs.Close();
                            passwordIsDefault = false;
                        }
                        else
                        {

                            MessageBox.Show("Default password not changed!");
                        }
                    }
                }
                if (validationCode == 3)
                {
                    new MenuPickerForm(username).Show();
                    successfulLogin = true;
                }
                if (validationCode == -1)
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }

            if (successfulLogin)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loginProcess();
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
                    if (usernamePassword.accountType == "2")
                    {
                        return 2;
                    }
                    if (usernamePassword.accountType == "3")
                    {
                        return 3;
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Username...";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password...")
            {
                textBox2.Text = "";
            }
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Password...";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // checks for enter pressed in the password box to submit login
            if (e.KeyChar == (char)13)
            {
                loginProcess();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // checks for enter pressed in the username box - move to password box? or also submit
            if (e.KeyChar == (char)13)
            {
                textBox2.Focus();
            }
        }
    }
}
