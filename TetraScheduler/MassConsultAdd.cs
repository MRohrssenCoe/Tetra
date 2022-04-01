using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace TetraScheduler
{
    public partial class MassConsultAdd : Form
    {

        private string fileName {get; set; }
        public MassConsultAdd()
        {
            InitializeComponent();
        }

        private void selectCSV_Click(object sender, EventArgs e)
        {

            // dialog preferences
            OpenFileDialog sd = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "CSV (Comma delimited) |*.csv",
                FilterIndex = 0,
                RestoreDirectory = true
            };


            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                fileName = sd.FileName;

                //update text on screen
                fileSelectedLabel.Text = Path.GetFileName(fileName);

            }
        }

        private void massAddButton_Click(object sender, EventArgs e)
        {
            if (fileName is null)
            {
                MessageBox.Show("Please Select a CSV file!");
                return;
            }

            // open csv

            // check for proper formatting

            // start reading in consultants

            while (true)
            {
                UserInfo ui = new UserInfo();
                

                break;
            }

            // for each consultant: create a new username, password, and consultant file for them

            // possibly email them their account information?
        }
    }
}
