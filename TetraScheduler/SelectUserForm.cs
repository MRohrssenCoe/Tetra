using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class SelectUserForm : Form
    {
        List<UserInfo> UserList;
        public UserInfo selectedUserInfo { get; set; }
        public SelectUserForm()
        {
            InitializeComponent();
            UserList = new List<UserInfo>();
            populateList();
            
        }
        void populateList()
        {
            string[] paths = Directory.GetFiles(Constants.userPreferencesFolder);
            foreach(string path in paths)
            {
                string JSONinfo = File.ReadAllText(path);
                UserInfo temp = new UserInfo();
                temp = JsonSerializer.Deserialize<UserInfo>(JSONinfo);
                UserList.Add(temp);
            }
            listBox1.DataSource = UserList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedUserInfo = (UserInfo)listBox1.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
