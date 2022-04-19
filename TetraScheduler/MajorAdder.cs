using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{

    public partial class MajorAdder : Form
    {
        private static string path = Path.Combine(Constants.AppDataFolder, Constants.MajorsFile);

        public MajorAdder()
        {
            InitializeComponent();
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            LoadMajors();
        }

        private void LoadMajors()
        {
            String MajorText = "";
            using (var fs = File.Open(path, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    MajorText = sr.ReadToEnd();
                }
            }
            String[] tokens = MajorText.Split(',');
            foreach(string tk in tokens)
            {
                var m = tk.Trim();
                if (tk != "")
                {
                    MajorList.Items.Add(m);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MajorTextBox.Text != "")
            {
                MajorList.Items.Add(MajorTextBox.Text);
            }
            MajorTextBox.Text = "";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(MajorList.SelectedIndex != -1)
            {
                MajorList.Items.RemoveAt(MajorList.SelectedIndex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach(String item in MajorList.Items)
            {
                data = data + item + ",";
            }
            // overwrite
            File.CreateText(path);
            File.WriteAllText(path, data);
        }
    }
}
