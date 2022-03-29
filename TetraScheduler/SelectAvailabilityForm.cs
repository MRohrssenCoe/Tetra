using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace TetraScheduler
{
    public partial class SelectAvailabilityForm : Form
    {
        //TODO once we get around to adding settings that affect the schedule, make sure to check here and populate boxes in code
        //rather than in designer
        public Schedule AvailableSchedule { get; set; }
        private List<Shift> prevAvails { get; set; }
        private List<ListBox.ObjectCollection> lists { get; set; }
        private List<ListBox> boxes { get; set; }

        private UserInfo tempUI;

        public SelectAvailabilityForm()
        {
            AvailableSchedule = new Schedule();
            InitializeComponent();
            initialize_schedule();
        }

        public SelectAvailabilityForm(List<Shift> prev)
        {
            prevAvails = prev;
            InitializeComponent();
            initialize_schedule();
        }
        private void initialize_schedule()
        {
            tempUI = new UserInfo();
            tempUI.FirstName = "Consultant";
            tempUI.LastName = "Consultant";

            lists = new List<ListBox.ObjectCollection>();
            lists.Add(new ListBox.ObjectCollection(this.sun_listbox));
            lists.Add(new ListBox.ObjectCollection(this.mon_listbox));
            lists.Add(new ListBox.ObjectCollection(this.tues_listbox));
            lists.Add(new ListBox.ObjectCollection(this.wed_listbox));
            lists.Add(new ListBox.ObjectCollection(this.thurs_listbox));
            lists.Add(new ListBox.ObjectCollection(this.fri_listbox));
            lists.Add(new ListBox.ObjectCollection(this.sat_listbox));

            boxes = new List<ListBox>();
            boxes.Add(sun_listbox);
            boxes.Add(mon_listbox);
            boxes.Add(tues_listbox);
            boxes.Add(wed_listbox);
            boxes.Add(thurs_listbox);
            boxes.Add(fri_listbox);
            boxes.Add(sat_listbox);

            // import preferences
            int defaultStart = 0;
            int[] startTimes = { defaultStart, defaultStart, defaultStart, defaultStart, defaultStart, defaultStart, defaultStart };
            int defaultEnd = 1440;
            int[] endTimes = { defaultEnd, defaultEnd, defaultEnd, defaultEnd, defaultEnd, defaultEnd, defaultEnd };
            int shiftLength = 60;
            bool[] daysOpen = { true, true, true, true, true, true, true };
            string aoFilePath = Path.Combine(Constants.adminPreferencesFolder, "admin.json");
            if (File.Exists(aoFilePath)){
                string text = File.ReadAllText(aoFilePath);
                AdminOptions ao = JsonSerializer.Deserialize<AdminOptions>(text);
                if (!(ao.OpenTimes is null)) startTimes = ao.OpenTimes;
                if (!(ao.CloseTimes is null)) endTimes = ao.CloseTimes;
                if (!(ao.ShiftLengthMinutes == 0)) shiftLength = ao.ShiftLengthMinutes;
                if (!(ao.daysOpen is null)) daysOpen = ao.daysOpen;
            }

            // generate schedule and add shifts to list
            AvailableSchedule = new Schedule(daysOpen, shiftLength, startTimes, endTimes);
            for (int i = 0; i < 7; i++)
            {
                foreach(Shift si in AvailableSchedule.shifts[i])
                {
                    Debug.WriteLine(si);
                    boxes[i].Items.Add(si);
                    
                }
            }

            // select previously picked indices
            if (!(prevAvails is null))
            {
                List<Shift> matches = AvailableSchedule.matchAvailabilities(prevAvails);
                foreach (Shift s in matches)
                {
                    s.AddUser(tempUI);
                    int day = s.day;
                    int shIndex = boxes[day].Items.IndexOf(s);
                    boxes[day].SetSelected(shIndex, true);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //loop through every box and all of the selected shifts
            foreach (ListBox box in boxes)
            {
                ListBox.SelectedObjectCollection selections = box.SelectedItems;
                foreach (Shift item in selections)
                {
                    //add dummy UI
                    //TODO phase this out and return list of available shifts that aren't marked.
                    if (!(item.UserAssigned(tempUI))){
                        item.AddUser(tempUI);
                    }
                    
                }
            }
            DialogResult = DialogResult.OK;
            //use SelectAvilabilityForm.availableSchedule in ConsultantMenu to display availability
        }


        private void SelectAvailabilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
