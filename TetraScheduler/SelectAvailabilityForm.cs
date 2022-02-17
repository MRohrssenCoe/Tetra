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
        //TODO once we get around to adding settings that affect the schedule, make sure to check here and populate boxes in code
        //rather than in designer
        public Schedule AvailableSchedule { get; set; }
        public SelectAvailabilityForm()
        {
            AvailableSchedule = new Schedule();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get selected items from listboxes
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(sun_listbox);
            boxes.Add(mon_listbox);
            boxes.Add(tues_listbox);
            boxes.Add(wed_listbox);
            boxes.Add(thurs_listbox);
            boxes.Add(fri_listbox);
            boxes.Add(sat_listbox);

            int i = 0;
            //pack them into availableSchedule
            foreach (ListBox box in boxes)
            {
                var indices = box.SelectedIndices;
                foreach(int index in indices)
                {
                    AvailableSchedule.AssignUser("Consultant", "Consultant", i, index);
                }
                i++;
            }
            DialogResult = DialogResult.OK;
            //use SelectAvilabilityForm.availableSchedule in ConsultantMenu to display availability
        }
    }
}
