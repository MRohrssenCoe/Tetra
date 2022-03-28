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
    public partial class UpdateUserForm : Form
    {
        private string[] token;
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

        private void button2_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
            foreach(int x in i)
            {
                token[(3 * x) + 2] = "0";
            }
            String tokenStr = "";
            for(int y = 0; y < token.Length - 1; y++)
            {
                tokenStr = tokenStr + token[y] + ",";
            }
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            tokenStr = tokenStr + token[token.Length - 1];
            File.WriteAllText(pswdFile, tokenStr);
        }

        private void button3_Click(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
            foreach (int x in i)
            {
                //jsonPath = token[x * 3] + ".json";
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
        }
    }
}
