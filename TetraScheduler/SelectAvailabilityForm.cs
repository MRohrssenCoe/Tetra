using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

namespace TetraScheduler
{
    public partial class SelectAvailabilityForm : Form
    {
        //TODO once we get around to adding settings that affect the schedule, make sure to check here and populate boxes in code
        //rather than in designer
        public Schedule AvailableSchedule { get; set; }
        public ArrayList[] selectedScheduleStrings;
        public SelectAvailabilityForm()
        {
            AvailableSchedule = new Schedule();
            selectedScheduleStrings = new ArrayList[7];
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
            //loop through every box and all of the selected indices
            foreach (ListBox box in boxes)
            {
                var indices = box.SelectedIndices;
                ArrayList currentDayStrings = new ArrayList();
                foreach (int index in indices)
                {
                    currentDayStrings.Add(box.Items[index].ToString());
                    //add selected shifts to available schedule under a dummy username
                    UserInfo tempUI = new UserInfo();
                    //TODO phase this out and return list of available shifts that aren't marked.
                    tempUI.FirstName = "Consultant";
                    tempUI.LastName = "Consultant";
                    AvailableSchedule.AssignUser(tempUI, i, index);
                }
                selectedScheduleStrings[i] = currentDayStrings;
                i++;
            }
            DialogResult = DialogResult.OK;
            //use SelectAvilabilityForm.availableSchedule in ConsultantMenu to display availability
        }


        private void SelectAvailabilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
