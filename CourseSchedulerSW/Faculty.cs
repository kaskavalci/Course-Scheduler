using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Faculty
    {
        string Name;
        public List<Department> DepartmentList { get; }
        public List<Classroom> ClassroomList { get; }
    }
}
