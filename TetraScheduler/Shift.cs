using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TetraScheduler
{
    internal class Shift
    {
        //untested
        struct User
        {
            public string FirstName;
            public string LastName;
        }
        private List<User> users;
        public Shift()
        {
            users = new List<User>();
        }

        public void AddUser(string fn, string ln)
        {
            User user = new User();
            user.FirstName = fn;
            user.LastName = ln;
            users.Add(user);
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
