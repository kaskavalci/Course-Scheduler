using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Section
    {
        private int ID;
        public Course whichCourse { get; }
        private int numHours;
        private Proffesor Instructor;
        private int prefferedHour;
        private Classroom prefferedClassroom;
        public List<Schedule> hourList { get; set; }

        public bool divideSchedules()
        {

            return false;
        }

        public bool mergeSchedules()
        {
            if (hourList.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, hourList.Count - 1);
                int next = rnd.Next(0, hourList.Count - 1);
                while (next == index)
                {
                    next = rnd.Next(0, hourList.Count - 1);
                }
                //if we merge them, pay attention that they will not exceed dayEndTime
                if (hourList[index].endHour + hourList[next].calcDuration() > whichCourse.department.dayEndTime)
                {
                    if (hourList[index].startHour - hourList[next].calcDuration() > whichCourse.department.dayStartTime)
                    {
                        hourList[index].startHour -= hourList[next].calcDuration();
                        hourList.RemoveAt(next);
                        return true;
                    }
                    else
                    {
                        //cannot add to the beginning, cannot add to the end. DAFUQ?
                        return false;
                    }
                }
                else
                {
                    hourList[index].endHour += hourList[next].calcDuration();
                    hourList.RemoveAt(next);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

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
