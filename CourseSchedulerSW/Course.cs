using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Course
    {
        public Department department { get;}
        private List<Section> ListSection;
        private String Name;
        private int fitness;
    }
}
