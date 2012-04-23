using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Classroom
    {
        public Faculty faculty { get; }
        public string RoomName { get; }
        public List<Schedule> scheduleList { get; set; }

        public void SetRoom()
        {
            
        }
        public int CalculateSectionConflict()
        {
            return 0;
        }
    }
}
