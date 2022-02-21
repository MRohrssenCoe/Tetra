using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    //In order to use something with the built in Json serializer, all relevant
    //properties must be public, including the class itself.
    public class UserInfo
    {
        public string FirstName;
        public string LastName;
        public List<String> majors;
        public int expSemesters;
        public int coeYear;
        public int desiredWeeklyHours;
        public Schedule availability;

        public UserInfo(string firstName, string lastName, List<string> majors,
            int expSemesters, int coeYear, int desiredWeeklyHours, Schedule availability)
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
            this.majors = new List<String>();
            this.expSemesters = 0;
            this.coeYear = 0;
            desiredWeeklyHours = 0;
            availability = new Schedule();
        }
    }
}
