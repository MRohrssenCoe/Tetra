using System;
using System.Collections.Generic;
using System.Text;

namespace TetraScheduler
{
    class Testing
    {

        public AdminOptions aOptions { get; set; }
        public List<UserInfo> consultants { get; set; }

        public Testing()
        {

        }

        public Testing(AdminOptions aOptions, List<UserInfo> consultants)
        {
            this.aOptions = aOptions;
            this.consultants = consultants;
        }

        public List<bool> runTestCases()
        {
            List<bool> results = new List<bool>();
            return results;
        }

        public Schedule generateSchedule()
        {
            Schedule s;
            if (this.aOptions != null && this.consultants != null){

                ScheduleMaker sm = new ScheduleMaker(this.consultants);
                s = sm.generateSchedule();
                return s;
            }
            return new Schedule();
        }

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
