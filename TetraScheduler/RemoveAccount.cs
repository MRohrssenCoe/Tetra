using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class RemoveAccount : Form
    {
        public RemoveAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete these account(s)?", "Confirmation", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                string[] deletedUsers = new string[checkedListBox1.CheckedItems.Count];
                checkedListBox1.CheckedItems.CopyTo(deletedUsers, 0);

                string tetraFolder = Constants.AppDataFolder;
                string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
                string usernameString = File.ReadAllText(pswdFile);
                string[] token;
                token = usernameString.Split(",");
                string newString = "";
                int x = 0;
                bool removal = false;
                string fileToDelete = Constants.userPreferencesFolder;
                int numAdminsNotDeleted = 0;
                while (x < token.Length)
                {
                    foreach (string username in deletedUsers) {
                        if (token[x].Equals(username))
                        {
                            removal = true;
                            if (token[x + 2].Equals("0") || token[x+2].Equals("3"))
                            {
                                fileToDelete = Path.Combine(Constants.userPreferencesFolder, username + ".json");
                                File.Delete(fileToDelete);//delete user file
                            }
                            break;
                        }
                    }
                    if (!removal)//remove log in info by not including it
                    {
                        if (token[x + 2].Equals("1"))
                        {
                            numAdminsNotDeleted++;
                        }
                        newString += token[x] + "," + token[x + 1] + "," + token[x + 2] + ",";
                    }
                        
                    removal = false; //reset for next entry
                    x += 3;
                }
                newString = newString.TrimEnd(',');
                if (numAdminsNotDeleted == 0)
                {
                    if (newString.Length != 0)
                    {
                        newString += ",";
                    }
                    newString += "admin," + LoginForm.encrypt_Password("password") + ",2";
                }
                File.WriteAllText(pswdFile, newString);
                this.Close();
            }
        }

        private void RemoveAccount_Load(object sender, EventArgs e)
        {
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            string[] token;
            token = usernameString.Split(",");
            int x = 0;
            while (x < token.Length)
            {
                checkedListBox1.Items.Add(token[x]);
                
                x += 3;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
