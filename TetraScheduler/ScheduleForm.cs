using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.IO;

namespace TetraScheduler
{

    public partial class ScheduleForm : Form
    {
        private enum day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }; // enumerates days of week // change to 0-6 or remove
        private string schedPath;

        private ListBox.ObjectCollection sunShifts; //todo: better collection
        private ListBox.ObjectCollection monShifts;
        private ListBox.ObjectCollection tuesShifts;
        private ListBox.ObjectCollection wedShifts;
        private ListBox.ObjectCollection thursShifts;
        private ListBox.ObjectCollection friShifts;
        private ListBox.ObjectCollection satShifts;

        private ListBox.ObjectCollection[] shiftArray;



        public ScheduleForm()
        {
            InitializeComponent();
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(folder, "TetraScheduler");
            this.schedPath = Path.Combine(specificFolder, "TetraSchedule.csv");

            this.sunShifts = new ListBox.ObjectCollection(sun_listbox); //todo: better collection
            this.monShifts = new ListBox.ObjectCollection(mon_listbox);
            this.tuesShifts = new ListBox.ObjectCollection(tues_listbox);
            this.wedShifts = new ListBox.ObjectCollection(wed_listbox);
            this.thursShifts = new ListBox.ObjectCollection(thurs_listbox);
            this.friShifts = new ListBox.ObjectCollection(fri_listbox);
            this.satShifts = new ListBox.ObjectCollection(sat_listbox);

            shiftArray = new ListBox.ObjectCollection[] {this.sunShifts, this.monShifts, this.tuesShifts, this.wedShifts, this.thursShifts, this.friShifts, this.satShifts};

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // get schedule data from file - maybe just store as csv internally the whole time??? at least in an easy to parse format
            // import shifts and add to appropriate list boxes - make this look better
            // maybe use datagridview?

            // stored as csv?
            
            using (TextFieldParser csvParser = new TextFieldParser(this.schedPath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    string weekDay = fields[0];
                    Debug.WriteLine(weekDay);
                    string startTime = fields[1];
                    string endTime = fields[2];
                    string consultants = fields[3];


                    switch (weekDay) // todo: can optimize this with indexing array
                    {
                        case "Sunday":
                            Debug.WriteLine("Sunday");
                            addShiftString(sunShifts, startTime, endTime, consultants);
                            break;
                        case "Monday":
                            Debug.WriteLine("Monday");
                            addShiftString(monShifts, startTime, endTime, consultants);
                            break;
                        case "Tuesday":
                            Debug.WriteLine("Tuesday");
                            addShiftString(tuesShifts, startTime, endTime, consultants);
                            break;
                        case "Wednesday":
                            Debug.WriteLine("Wednesday");
                            addShiftString(wedShifts, startTime, endTime, consultants);
                            break;
                        case "Thursday":
                            Debug.WriteLine("Tuesday");
                            addShiftString(thursShifts, startTime, endTime, consultants);
                            break;
                        case "Friday":
                            Debug.WriteLine("Friday");
                            addShiftString(friShifts, startTime, endTime, consultants);
                            break;
                        case "Saturday":
                            Debug.WriteLine("Saturday");
                            addShiftString(satShifts, startTime, endTime, consultants);
                            break;
                        default:
                            Debug.WriteLine("Invalid date");
                            break;

                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (shiftArray[i].Count == 0)
                {
                    shiftArray[i].Add("No shifts");
                }
            }
        }

        private void readFromCSV()
        {
            // uses file path for csv files
            // creates schedule object and assigns info to shift objects in the schedule
            // returns schedule object
        }

        private void addShiftString(ListBox.ObjectCollection items, String startTime, String endTime, String consultants)
        {
            // appends info about a shift to a given listbox
            items.Add(String.Format("{0} - {1}: {2}", startTime, endTime, consultants));
        }
    }

}
