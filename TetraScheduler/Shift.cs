using System;
using System.Collections.Generic;
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
            foreach(User user in users)
            {
                if(user.FirstName == fn && user.LastName == ln)
                {
                    users.Remove(user);
                }
            }
        }
    }
}
