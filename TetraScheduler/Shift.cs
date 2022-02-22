using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TetraScheduler
{
    public class Shift
    {
        //untested
        public struct User
        {
            public string FirstName;
            public string LastName;
        }
        public List<User> users { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
        public int day { get; set; }
        public Shift()
        {
            users = new List<User>();
        }
        public bool UserAssigned(string fn, string ln)
        {
            foreach(User u in users)
            {
                if(u.FirstName == fn && u.LastName == ln)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(string fn, string ln)
        {
            int index = -1;
            foreach (User u in users)
            {
                if (u.FirstName == fn && u.LastName == ln)
                {
                    index = users.IndexOf(u);
                }
            }
            if (index == -1)
            {
                User user = new User();
                user.FirstName = fn;
                user.LastName = ln;
                users.Add(user);
            } else {
                Debug.WriteLine("User already exists in this shift: " + fn + ", " + ln);
            }
        }
        public void RemoveUser(string fn, string ln)
        {
            int index = -1;
            foreach(User user in users)
            {
                if(user.FirstName == fn && user.LastName == ln)
                {
                    index = users.IndexOf(user);
                }
            }
            if(index == -1)
            {
                Debug.WriteLine("No such shift found: " + fn + " " + ln);
            } else
            {
                users.RemoveAt(index);
            }
        }
        public string UsersAsText()
        {
            string names = "";
            foreach(User u in users)
            {
                names += u.FirstName + "," + u.LastName + ",";
            }
            return names;
        }

        public string minutesToHr(int mins, bool twelveHrFormat)
        {
            TimeSpan t = TimeSpan.FromMinutes(mins);
            
            if (twelveHrFormat)
            {
                String ampm = mins < (12 * 60) ? "AM" : "PM";

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
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            String day = Constants.daysShort[this.day]; // day abbrevs
            String startTime = minutesToHr(this.startTime, true); // 12 hr format
            String endTime = minutesToHr(this.endTime, true); // 12 hr format
            return String.Format("{0}: {1} - {2}", day, startTime, endTime);
        }
    }
}
