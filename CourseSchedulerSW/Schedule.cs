using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Schedule
    {
        public Section section { get; set; }
        public Classroom classroom { get; set; }
        public int startHour { get; set; }
        public int endHour { get; set; }
        public int whichDay { get; set; }

        private bool mutateHour()
        {
            int newHour;
            try
            {
                Random rnd = new Random();
                newHour = rnd.Next(9, 18);
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        private bool mutateClassroom()
        {
            return false;
        }
    }
}
