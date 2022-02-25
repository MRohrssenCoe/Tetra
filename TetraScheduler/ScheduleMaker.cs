using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    class ScheduleMaker
    {
        public List<UserInfo> users { get; set; }

        // get admin preferences here

        public ScheduleMaker()
        {

        }


        public void generateSchedule()
        {
            Schedule s = new Schedule();
            // check that we have a list of consultants, admin preferences, etc. requirements
        }


        private void sortUsers()
        {
            // sorts users from fewest -> most availability times
            this.users.Sort((UserInfo u1, UserInfo u2) => u1.availability.Count.CompareTo(u2.availability.Count));
        }

        public static List<UserInfo> getUsers(String accountFolder)
        {
            List<UserInfo> userList = new List<UserInfo>();

            // parse every account file as a user object
            // return a list of those

            return userList;
        }
    }
}
