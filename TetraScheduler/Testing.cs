using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

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

                ScheduleMaker sm = new ScheduleMaker(this.consultants, this.aOptions);
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
            var rand = new Random();

            for (int i = 0; i < numConsultants; i++)
            {
                UserInfo c = new UserInfo();
                c.FirstName = i.ToString();
                c.LastName = i.ToString();
                c.availability = generateRandomAvailability(rand.Next(10, 30));
                c.desiredWeeklyHours = rand.Next(3,7);
                // assign them a random set of shifts, majors, school year, etc.
                consultants.Add(c);
            }

            return consultants;
        }

        public List<Shift> generateRandomAvailability(int numShiftsAvailable)
        {
            var rand = new Random();
            List<Shift> output = new List<Shift>();
            //for(int i = 0; i < numShiftsAvailable; i++)
            while (output.Count < numShiftsAvailable)  // could potentially run forever if we're unlucky...
            {
                Shift s = new Shift();
                s.day = rand.Next(0, 7);
                s.startTime = rand.Next(9, 17) * 60;
                s.endTime = s.startTime + 60;

                bool dupe = false;
                foreach(Shift sh in output)
                {
                    if (sh == s)
                    {
                        dupe = true;
                        break;
                    }
                }
                if (!dupe)
                {
                    output.Add(s);
                }
            }
            return output;
        }

        public List<Shift> generateAvail2(int numShiftsAvailable)
        {
            var rand = new Random();
            Schedule s = new Schedule(); // dummy schedule to get shifts from, change to copy from another schedule?
            List<Shift> options = s.toLinearArray();
            List<Shift> output = new List<Shift>();
            
            while (output.Count < numShiftsAvailable && options.Count > 0) 
            {
                int index = rand.Next(0, options.Count);
                output.Add(options[index]);
                options.RemoveAt(index);
            }
            return output;
        }

    }
}
