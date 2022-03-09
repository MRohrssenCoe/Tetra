using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ScheduleEditorForm : Form
    {

        ListBox.ObjectCollection sundayObjectCollection;
        ListBox.ObjectCollection mondayObjectCollection;
        ListBox.ObjectCollection tuesdayObjectCollection;
        ListBox.ObjectCollection wednesdayObjectCollection;
        ListBox.ObjectCollection thursdayObjectCollection;
        ListBox.ObjectCollection fridayObjectCollection;
        ListBox.ObjectCollection saturdayObjectCollection;

        ListBox lastClickedBox = null;

        public ScheduleEditorForm()
        {
            InitializeComponent();
            sundayObjectCollection = sun_listbox.Items;
            mondayObjectCollection = mon_listbox.Items;
            tuesdayObjectCollection = tues_listbox.Items;
            wednesdayObjectCollection = wed_listbox.Items;
            thursdayObjectCollection = thurs_listbox.Items;
            fridayObjectCollection = fri_listbox.Items;
            saturdayObjectCollection = sat_listbox.Items;
            
            fillBoxesWithSchedule();
        }

        private void fillBoxesWithSchedule()
        {
            //convert csv to schedule
            csvToSchedule();
            //fill boxes using schedule.
        }

        private void csvToSchedule()
        {
            // read in from CSV
            using (TextFieldParser csvParser = new TextFieldParser(System.IO.Path.Combine(Constants.AppDataFolder, Constants.scheduleFileName)))
            {
                // set up options
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true; // todo: come back to this. not sure if we are writing to CSVs properly

                // read column name row
                csvParser.ReadLine();

                // TODO: interpret hours from csv (first and last shift on each day?)

                //iteration through remaining rows
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    // separate each column within the row
                    string timeSlot = fields[0];
                    string Sunday = fields[1];
                    string Monday = fields[2];
                    string Tuesday = fields[3];
                    string Wednesday = fields[4];
                    string Thursday = fields[5];
                    string Friday = fields[6];
                    string Saturday = fields[7];

                    //construct shifts from this info?
                    Shift sundayShift = new Shift();
                    Shift mondayShift = new Shift();
                    Shift tuesdayShift = new Shift();
                    Shift wednesdayShift = new Shift();
                    Shift thursdayShift = new Shift();
                    Shift fridayShift = new Shift();
                    Shift saturdayShift = new Shift();
                    sundayShift = parseCell(timeSlot, Sunday, 0);
                    mondayShift = parseCell(timeSlot, Monday, 1);
                    tuesdayShift = parseCell(timeSlot, Tuesday, 2);
                    wednesdayShift = parseCell(timeSlot, Wednesday, 3);
                    thursdayShift = parseCell(timeSlot, Thursday, 4);
                    fridayShift = parseCell(timeSlot, Friday, 5);
                    saturdayShift = parseCell(timeSlot, Saturday, 6);
                    
                    
                    //add shifts to collections
                    sundayObjectCollection.Add(sundayShift);
                    mondayObjectCollection.Add(mondayShift);
                    tuesdayObjectCollection.Add(tuesdayShift);
                    wednesdayObjectCollection.Add(wednesdayShift);
                    thursdayObjectCollection.Add(thursdayShift);
                    fridayObjectCollection.Add(fridayShift);
                    saturdayObjectCollection.Add(saturdayShift);
                }
            }
        }

        private Shift parseCell(string timeslot, string consultants, int day)
        {
            Shift s = new Shift();
            s.day = day;
            string[] tokens = consultants.Split(';');
            if(tokens != null)
            {
                foreach (string tok in tokens)
                {
                    string[] nameSplit = tok.Split(' ');
                    if (nameSplit != null)
                    {

                        //TODO add user using first name and lastname

                    }
                }
            }
            //parse time
            tokens = timeslot.Split('-');
            int starthour = int.Parse(tokens[0].Substring(0, 2));
            int startminute = int.Parse(tokens[0].Substring(3, 2));
            string startAMPM = tokens[0].Substring(5, 2);
            if(startAMPM == "PM" && starthour != 12)
            {
                starthour += 12;
            }

            int endhour = int.Parse(tokens[1].Substring(0, 2));
            int endminute = int.Parse(tokens[1].Substring (3, 2));
            string endAMPM = tokens[1].Substring (5, 2);

            if(endAMPM == "PM" && endhour != 12)
            {
                endhour += 12;
            }
            s.startTime = (starthour * 60) + startminute;
            s.endTime = (endhour * 60) + endminute;

            return s;
        }

        //This makes it so that you can only select one item across the 7 list boxes :)
        private void listbox_ItemChanged(object sender, EventArgs e)
        {

            if(lastClickedBox is null)
            {
                Debug.WriteLine("NULL!");
                lastClickedBox = (ListBox)sender;
            } else
            {
                if (lastClickedBox != (ListBox)sender)
                {
                    deselectOther(lastClickedBox);
                    lastClickedBox = (ListBox)sender;
                }
                
            }
        }

        void deselectOther(ListBox lb)
        {
            lb.SelectedIndex = -1;
        }


    }
}
