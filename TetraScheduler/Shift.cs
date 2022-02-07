using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    internal class Shift
    {
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
    }
}
