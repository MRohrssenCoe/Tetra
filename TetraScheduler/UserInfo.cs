using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    //In order to use something with the built in Json serializer, all relevant
    //properties must be public, including the class itself.
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] majors { get; set; }
        public int expSemesters { get; set; }
        public int coeYear { get; set; }
        public int desiredWeeklyHours { get; set; }
        public List<Shift> availability { get; set; }

        public UserInfo(string firstName, string lastName, string[] majors,
            int expSemesters, int coeYear, int desiredWeeklyHours, List<Shift> availability)
        {
            FirstName = firstName;
            LastName = lastName;
            this.majors = majors;
            this.expSemesters = expSemesters;
            this.coeYear = coeYear;
            this.desiredWeeklyHours = desiredWeeklyHours;
            this.availability = availability;
        }
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            //TODO: fix null issue with empty majors array
            this.expSemesters = 0;
            this.coeYear = 0;
            desiredWeeklyHours = 0;
            availability = new List<Shift>();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName; // expand on this later
        }
    }
}
