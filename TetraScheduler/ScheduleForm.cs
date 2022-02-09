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
        private enum day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }; // enumerates days of week // change to 0-6

        public ScheduleForm()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // get schedule data from file - maybe just store as csv internally the whole time??? at least in an easy to parse format
            // import shifts and add to appropriate list boxes - make this look better
            // maybe use datagridview?

            // stored as csv?
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(folder, "TetraScheduler");
            string path = Path.Combine(specificFolder, "TetraSchedule.csv");
            using (TextFieldParser csvParser = new TextFieldParser(path))
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
                    // does not work!!!
                   switch (weekDay)
                    {
                        case "Sunday":
                            Debug.WriteLine("Sunday");
                            ListBox.ObjectCollection items = sun_listbox.Items;
                            items.Add(String.Format("{0} - {1}: {2}", startTime, endTime, consultants));
                            sun_listbox.DataSource = items;
                            break;
                        case "Monday":
                            break;
                        case "Tuesday":
                            break;
                        case "Wednesday":
                            break;
                        case "Thursday":
                            break;
                        case "Friday":
                            break;
                        case "Saturday":
                            break;
                        default:

                            break;
                    }
                }
            }
        }
     }

}
