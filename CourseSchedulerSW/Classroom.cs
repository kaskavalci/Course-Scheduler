using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Classroom
    {
        public Faculty faculty { get; }
        string RoomName;
        public List<Schedule> scheduleList { get; set; }
        public string GetRoom()
        {
            return null;
        }
        public void SetRoom()
        {
            
        }
        public int CalculateSectionConflict()
        {
            return 0;
        }
    }
}
