using Microsoft.VisualBasic.FileIO;
using System;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class ScheduleEditorForm : Form
    {
        public ScheduleEditorForm()
        {
            InitializeComponent();
        }

        private void fillBoxesWithSchedule()
        {
            //convert csv to schedule
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
                    //Add shifts to listbox object collections?

                }
            }
        }
    }
}
