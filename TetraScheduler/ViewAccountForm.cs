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
    public partial class ViewAccountForm : Form
    {
        private string[] token;
        private List<string> consultantUsernames;
        public ViewAccountForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultantUsernames = new List<string>();
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
                    consultantUsernames.Add(token[x]);
                }
                else if (token[x + 2].Equals("3"))
                {
                    checkedListBox1.Items.Add(token[x] + " Admin and Consultant");
                    consultantUsernames.Add(token[x]);
                }
                x += 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection i = checkedListBox1.CheckedIndices;
            foreach(int x in i)
            {
                // OLD CODE: new ConsultantMenuForm(token[x * 3]).Show(); 
                // NOTE- this caused a bug where it would create new consultant data files for an admin, because token[] has admins in it - changed it to use a separate list
                // NEW CODE:
                new ConsultantMenuForm(consultantUsernames[x]).Show();
            }
            this.Close();
        }
    }
}
