using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class UpdateUserForm : Form
    {
        private string[] token;
        private int[] admins;
        private int adminCount;
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            this.token = usernameString.Split(",");
            Array.Resize(ref admins, token.Length);
            int x = 0;
            int y = 0;
            while (x < token.Length)
            {
                if (token[x + 2].Equals("0"))
                {
                    checkedListBox1.Items.Add(token[x] + " Consultant");
                }
                else if (token[x + 2].Equals("1"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin");
                    admins[y] = x / 3;
                    y++;
                }
                else if (token[x + 2].Equals("3"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin and Consultant");
                    admins[y] = x / 3;
                    y++;
                }
                x += 3;
            }
            adminCount = y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to change these user(s) to Consultant. Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
                int a = 0;
                int b = 0;
                int c = 0;
                while(a < i.Count)
                {
                    while(b < adminCount)
                    {
                        if (i[a].Equals(admins[b]))
                        {
                            c++;
                        }
                        b++;
                    }
                    a++;
                }
                if (c == adminCount)
                {
                    MessageBox.Show("ERROR \nYou are attempting to delete all Admin accounts.\nProcess cannot be executed.");
                    this.Close();
                    return;
                }
                else if (c > 0)
                {
                    DialogResult dialogResult1 = MessageBox.Show("Warning.\nYou are attempting to delete Admin accounts. \nAre you truly sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.No)
                    {
                        this.Close();
                        return;
                    }
                }

                foreach (int x in i)
                {
                    token[(3 * x) + 2] = "0";
                    Debug.WriteLine("here");
                }
                String tokenStr = "";
                for (int y = 0; y < token.Length - 1; y++)
                {
                    tokenStr = tokenStr + token[y] + ",";
                }
                string tetraFolder = Constants.AppDataFolder;
                string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
                tokenStr = tokenStr + token[token.Length - 1];
                File.WriteAllText(pswdFile, tokenStr);
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to change these user(s) to both Admin and Consultant. Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
                foreach (int x in i)
                {
                    token[(3 * x) + 2] = "3";
                }
                String tokenStr = "";
                for (int y = 0; y < token.Length - 1; y++)
                {
                    tokenStr = tokenStr + token[y] + ",";
                }
                string tetraFolder = Constants.AppDataFolder;
                string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
                tokenStr = tokenStr + token[token.Length - 1];
                File.WriteAllText(pswdFile, tokenStr);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to change these user(s) to Admin. Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
                foreach (int x in i)
                {
                    String jsonName = token[x * 3] + ".json";
                    String Pathhalf = Constants.userPreferencesFolder;
                    String jsonPath = Path.Combine(Pathhalf, jsonName);
                    File.Delete(jsonPath);
                }
                foreach (int x in i)
                {
                    token[(3 * x) + 2] = "1";
                }
                String tokenStr = "";
                for (int y = 0; y < token.Length - 1; y++)
                {
                    tokenStr = tokenStr + token[y] + ",";
                }
                string tetraFolder = Constants.AppDataFolder;
                string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
                tokenStr = tokenStr + token[token.Length - 1];
                File.WriteAllText(pswdFile, tokenStr);
                this.Close();
            }
        }
    }
}
