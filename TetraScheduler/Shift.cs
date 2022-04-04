using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

//Basic class to store all info relevant to a shift. Contains User struct which may be updated in the future to use login info rather than first name + last name depending on scale.
//Each shift has a list of Users, a start time and end time in minutes, and a day of the week which the shift happens on. Technically, day is not necessarily needed as the main way
//of interacting with the Shift class is through the Schedule class, where the day is defined implicitly, but it is much faster to code a lot of different functions if the day
//is included here.

namespace TetraScheduler
{
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    public class Shift
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
    {

        public List<UserInfo> users { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
        public int day { get; set; }
        public int maxUsers { get; set; }

        public Shift()
        {
            users = new List<UserInfo>();
        }
        public bool UserAssigned(UserInfo ui)
        {
            foreach (UserInfo u in users)
            {
                if (u.FirstName == ui.FirstName && u.LastName == ui.LastName)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(UserInfo ui)
        {
            int index = -1;
            foreach (UserInfo u in users)
            {
                if (u.FirstName == ui.FirstName && u.LastName == ui.LastName)
                {
                    index = users.IndexOf(u);
                }
            }
            if (index == -1)
            {
                users.Add(ui);
            }
            else
            {
                Debug.WriteLine("User already exists in this shift: " + ui.FirstName + ", " + ui.LastName);
            }
        }
        public void RemoveUser(UserInfo ui)
        {
            int index = -1;
            foreach (UserInfo user in users)
            {
                if (user.FirstName == ui.FirstName && user.LastName == ui.LastName)
                {
                    index = users.IndexOf(user);
                }
            }
            if (index == -1)
            {
                if (ui is null)
                {
                    Debug.WriteLine("ui was null");
                }
                else
                {
                    Debug.WriteLine("No such user found: " + ui.FirstName + " " + ui.LastName);
                }
            }
            else
            {
                users.RemoveAt(index);
            }
        }
        public string UsersAsText()
        {
            string names = "";
            foreach (UserInfo u in users)
            {
                names += u.FirstName + " " + u.LastName + "; ";
            }
            return names;
        }

        public static string minutesToHr(int mins, bool twelveHrFormat)
        {

            if (twelveHrFormat)
            {
                String ampm = (mins%(24* 60)) < (12 * 60) ? " AM" : " PM";

                // if 1pm or later - subract 12 hrs
                if (mins >= (13 * 60))
                {
                    mins -= (12 * 60);
                }

                // if 12am-1am - convert from 0 -> 12
                if (mins < 60)
                {
                    mins += (12 * 60);
                }
                return TimeSpan.FromMinutes(mins).ToString(@"hh\:mm") + ampm;
            }
            return TimeSpan.FromMinutes(mins).ToString(@"hh\:mm");
        }
        //Overrides the ToString method for use with Object collections and list views - Thanks Katya.
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            String day = Constants.daysShort[this.day]; // day abbrevs
            String startTime = minutesToHr(this.startTime, true); // 12 hr format
            String endTime = minutesToHr(this.endTime, true); // 12 hr format
            return String.Format("{0}: {1} - {2}", day, startTime, endTime);
        }

        // same as above but no day and no override
        public string TimeString()
        {
            String startTime = minutesToHr(this.startTime, true); // 12 hr format
            String endTime = minutesToHr(this.endTime, true); // 12 hr format
            return String.Format("{0} - {1}", startTime, endTime);
        }

        //This overload only compares the time that the shifts start at, because that's the only thing that makes sense to compare
        public static bool operator <(Shift self, Shift other)
        {
            int minuteCountSelf = (self.day * 1440) + self.startTime;
            int minuteCountOther = (other.day * 1440) + other.startTime;

            return minuteCountSelf < minuteCountOther;
        }
        //This overload only compares the time that the shifts start at, because that's the only thing that makes sense to compare
        public static bool operator >(Shift self, Shift other)
        {
            int minuteCountSelf = (self.day * 1440) + self.startTime;
            int minuteCountOther = (other.day * 1440) + other.startTime;

            return minuteCountSelf > minuteCountOther;
        }
        public static bool operator ==(Shift self, Shift other)
        {
            if(self is null || other is null)
            {
                if(self is null && other is null) { return true; }
                return false;
            }
            return self.day == other.day && self.startTime == other.startTime && self.endTime == other.endTime;
        }
        public static bool operator !=(Shift self, Shift other)
        {
            return !(self == other);
        }


        public int getNumMajors(string major)
        {
            // returns number of users with a given major in this shift
            int numMajors = 0;
            foreach(UserInfo user in users)
            {
                string[] majors = user.majors;
                foreach(string m in majors)
                {
                    if (m.Equals(major))
                    {
                        numMajors++;
                    }
                }
            }

            return numMajors;
        }

        public int maxDistanceSemOfExp(int sem)
        {
            // find a better way to sort by semesters of experience?
            int max = 0;
            foreach(UserInfo user in users)
            {
                int dif = Math.Abs(user.expSemesters - sem);
                if (dif > max)
                {
                    max = dif;
                }
            }
            return max;
        }

        public int maxDistanceCoeYear(int yr)
        {
            // find a better way to sort by semesters of experience?
            int max = 0;
            foreach (UserInfo user in users)
            {
                int dif = Math.Abs(user.schoolYear - yr);
                if (dif > max)
                {
                    max = dif;
                }
            }
            return max;
        }

    }
}
