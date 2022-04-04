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
        public WarningForm(List<(UserInfo, int)> userTuple, List<(Shift, int)> shiftsTuple)
        {
            InitializeComponent();
            fillUsersList(userTuple);
            fillShiftsList(shiftsTuple);

        }

        private void fillShiftsList(List<(Shift, int)> shiftsTuple)
        {
            throw new NotImplementedException();
        }

        private void fillUsersList(List<(UserInfo, int)> userTuple)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
