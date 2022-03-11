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
                if (token[x + 2].Equals("0"))
                {
                    checkedListBox1.Items.Add(token[x] + " Consultant");
                }
                else if (token[x + 2].Equals("1"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin");
                }
                else if (token[x + 2].Equals("3"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin and Consultant");
                }
                x += 3;
            }
        }
    }
}
