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
        public Shift()
        {
            users = new List<User>();
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
    }
}
