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



        public List<UserInfo> generateConsultants(int numConsultants)
        {
            List<UserInfo> consultants = new List<UserInfo>();

            for (int i = 0; i < numConsultants; i++)
            {
                UserInfo c = new UserInfo();
                c.FirstName = i.ToString();
                c.LastName = i.ToString();
            }

            return consultants;
        }


    }
}
