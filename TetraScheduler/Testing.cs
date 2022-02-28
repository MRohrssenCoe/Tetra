using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    class Testing
    {

        public Testing()
        {

        }


        //admin preferences

        //consultant preferences

        // generate 60 consultants
        // 

        public AdminOptions generateAdminOptions()
        {
            AdminOptions options = new AdminOptions();
            return options;
        }

        public List<UserInfo> generateConsultants(int numConsultants)
        {
            List<UserInfo> consultants = new List<UserInfo>();

            for (int i = 0; i < numConsultants; i++)
            {
                UserInfo c = new UserInfo();
                c.FirstName = i.ToString();
                c.LastName = i.ToString();
                // assign them a random set of shifts, majors, school year, etc.
            }

            

            return consultants;
        }

        public List<Shift> generateRandomAvailability(int numShiftsAvailable)
        {
            var rand = new Random();
            List<Shift> output = new List<Shift>();
            for (int i = 0;i < numShiftsAvailable; i++)
            {
                Shift s = new Shift();
                s.day = rand.Next(0, 6);
                s.startTime = rand.Next(9, 17) * 60;
                s.endTime = s.startTime + 60;
                output.Add(s);
            }
            return output;
        }

    }
}
