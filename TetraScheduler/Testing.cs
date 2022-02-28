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

    }
}
