using Microsoft.VisualBasic.FileIO;
using System;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ScheduleEditorForm : Form
    {

        ListBox.ObjectCollection sundayObjectCollection;


        public ScheduleEditorForm()
        {
            InitializeComponent();
            sundayObjectCollection = sun_listbox.Items;
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
                    sundayShift = parseCell(timeSlot, Sunday, 0);
                    sundayObjectCollection.Add(sundayShift);


                    //Add shifts to listbox object collections?

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
                        //add user using first name and lastname

                    }
                }
            }
            //parse time
            tokens = timeslot.Split('-');

            return s;
        }
    }
}
