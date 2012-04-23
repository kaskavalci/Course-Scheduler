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
    }
}
