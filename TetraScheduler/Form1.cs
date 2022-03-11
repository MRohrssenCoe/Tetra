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
    public partial class Form1 : Form
    {
        private string[] token;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            token = usernameString.Split(",");
            int x = 0;
            while (x < token.Length)
            {
                if (token[x + 2].Equals("0"))
                {
                    checkedListBox1.Items.Add(token[x] + " Consultant");
                }
                else if (token[x + 2].Equals("3"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin and Consultant");
                }
                x += 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
            foreach(int x in i)
            {
                new ConsultantMenuForm(token[x * 3]).Show();
            }
            this.Close();
        }
    }
}
