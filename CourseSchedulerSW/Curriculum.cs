using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Curriculum
    {
        struct semester
        {
            List<Course> courseList;
            int TermNumber;
        }

        public int CalcFitness()
        {
            return 0;
        }

        public int SemesterConflict()
        {
            return 0;
        }

    }
}
