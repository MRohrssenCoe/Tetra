using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class SelectAvailabilityForm : Form
    {
        //TODO once we get around to adding settings that affect the schedule, make sure to check here.
        public Schedule AvailableSchedule { get; set; }
        public SelectAvailabilityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get selected items from listboxes
            //pack them into availableSchedule
            //use SelectAvilabilityForm.availableSchedule in ConsultantMenu to display availability
        }
    }
}
