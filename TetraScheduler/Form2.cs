using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace TetraScheduler
{
    public partial class ScheduleForm : Form
    {
        private enum day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }; // enumerates days of week

        public ScheduleForm()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // get schedule data from file - maybe just store as csv internally the whole time??? at least in an easy to parse format
            // import shifts and add to appropriate list boxes - make this look better
            // maybe use datagridview?
        }
     }

}
