using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }
        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // jank solution but nothing else is working for me.
            Icon ico = new Icon(SystemIcons.Warning, new Size(64, 64));

            e.Graphics.DrawIcon(ico, 0, 0);
        }
        public WarningForm(List<(UserInfo, int)> userTuple, List<(Shift, int)> shiftsTuple)
        {
            InitializeComponent();
            fillUsersList(userTuple);
            fillShiftsList(shiftsTuple);

        }

        private void fillShiftsList(List<(Shift, int)> shiftsTuples)
        {
            foreach ((Shift, int) tuple in shiftsTuples)
            {
                listBox1.Items.Add(shiftWarningString(tuple));
            }
        }

        private void fillUsersList(List<(UserInfo, int)> userTuple)
        {
            foreach((UserInfo, int) tuple in userTuple)
            {
                listBox2.Items.Add(userWarningString(tuple));
            }
        }

        private string shiftWarningString((Shift, int) shiftTuple)
        {
            string spaces = "    ";
            return shiftTuple.Item1.TimeString() + spaces + shiftTuple.Item2;
        }

        private string userWarningString((UserInfo, int) userTuple)
        {
            string spaces = "    ";
            string hourString = (userTuple.Item2 / 60).ToString();
            return userTuple.Item1.ToString() + spaces + hourString;
        }

        private void consultantWarningsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
