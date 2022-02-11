using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TetraScheduler
{

    public partial class ScheduleForm : Form
    {
        private enum day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }; // enumerates days of week - change this

        private string schedPath; // location of schedule csv file

        // Lists of shifts to display
        private ListBox.ObjectCollection sunShifts; //todo: better collections?
        private ListBox.ObjectCollection monShifts;
        private ListBox.ObjectCollection tuesShifts;
        private ListBox.ObjectCollection wedShifts;
        private ListBox.ObjectCollection thursShifts;
        private ListBox.ObjectCollection friShifts;
        private ListBox.ObjectCollection satShifts;

        // List of list of shifts to display
        private ListBox.ObjectCollection[] shiftArray;

        // list of labels to display the hours
        private Label[] hourLabels;


        public ScheduleForm()
        {
            InitializeComponent();

            // get appdata file location
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(folder, "TetraScheduler");
            this.schedPath = Path.Combine(specificFolder, "TetraSchedule.csv");

            // initialize shift OCs
            this.sunShifts = new ListBox.ObjectCollection(sun_listbox);
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
            
            // read in from CSV
            using (TextFieldParser csvParser = new TextFieldParser(this.schedPath))
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
                    string weekDay = fields[0];
                    Debug.WriteLine(weekDay);
                    string startTime = fields[1];
                    string endTime = fields[2];
                    string consultants = fields[3];

                    // different box to display for each day
                    switch (weekDay) // todo: can optimize this with indexing shiftArray
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

            // displays 'no shifts' for days without shifts
            for (int i = 0; i < 7; i++)
            {
                if (shiftArray[i].Count == 0)
                {
                    shiftArray[i].Add("No shifts");
                }
            }

            // end of function
        }

        private void readFromCSV()
        {
            // uses file path for csv files
            // creates schedule object and assigns info to shift objects in the schedule
            // returns schedule object
        }

        private void addShiftString(ListBox.ObjectCollection items, String startTime, String endTime, String consultants)
        {
            // appends info about a shift to a given listbox - maybe unnecessary
            items.Add(String.Format("{0} - {1}: {2}", startTime, endTime, consultants));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lets user save CSV to anywhere they want

            // Think we have to use streams with SaveFileDialog?
            Stream myStream;

            // dialog preferences
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV (Comma delimited) |*.csv";
            sd.FilterIndex = 0;
            sd.AddExtension = true;
            sd.DefaultExt = "csv";
            sd.FileName = "Schedule.csv";

            
            // display and see if it saves properly
            DialogResult result = sd.ShowDialog();

            if (result == DialogResult.OK) // if user confirms saving the file
            {
                if ((myStream = sd.OpenFile()) != null) // if it lets us open the file properly
                {
                    byte[] ourFile = File.ReadAllBytes(schedPath);
                    // TODO: add error checking here for opening our file
                    myStream.Write(ourFile);
                    myStream.Close();
                }

                else
                {
                    MessageBox.Show("The program was unable to save your file");
                }
            }

        }
    }

}
