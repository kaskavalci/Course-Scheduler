using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Section
    {
        private int ID;
        public Course whichCourse { get;}
        private int numHours;
        private Proffesor Instructor;
        private int prefferedHour;
        private Classroom prefferedClassroom;
        public List<Schedule> hourList { get; set; }

        protected int calcPenaltyPrefRoom() //2
        {
            return 0;
        }

        protected int calcPenaltyPrefClass() // 2
        {
            return 0;
        }

        protected int calcSectionPause() // 1
        {
            return 0;
        }

        protected int calcPenaltyClassroom() //constraint 3
        {
            return 0;
        }
    }
}
