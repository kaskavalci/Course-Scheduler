using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Department
    {
        private List<Curriculum> ListCurriculum;
        public int dayStartTime { get; }
        public int dayEndTime { get; }
        public Faculty faculty { get; }

        /* eger section saati güne sığmıyorsa bölmemiz lazım */
        private bool initCurriculum()
        {
            return false;
        }

        private bool processCurriculum()
        {
            return false;
        }

        /* one curriculum to rule them all */
        public Curriculum ChooseCurriculum()
        {
            return null;
        }

        /* during iterations, choose the population that will survive */
        private bool refinePopulation()
        {
            return false;
        }

        private Schedule chooseRandomSection(Section sec)
        {
            Random rndElement = new Random();
            int index;
            if (sec.hourList.Count > 1)
            {
                index = rndElement.Next(0, sec.hourList.Count - 1);
                return sec.hourList[index];
            }
            else return null;
        }

        private Schedule chooseRandomSection(Classroom clas)
        {
            Random rndElement = new Random();
            int index;
            if (clas.scheduleList.Count > 1)
            {
                index = rndElement.Next(0, clas.scheduleList.Count - 1);
                return clas.scheduleList[index];
            }
            else return null;
        }

        private bool CrossoverHour(Schedule first, Schedule second)
        {
            try
            {
                int tempFirst, tempSec;
                tempFirst = first.startHour;
                tempSec = first.endHour;
                first.startHour = second.startHour;
                first.endHour = second.endHour;
                second.startHour = tempFirst;
                second.endHour = tempSec;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private bool CrossoverClassroom(Schedule first, Schedule second)
        {
            try
            {
                Classroom temp;
                temp = first.classroom;
                first.classroom = second.classroom;
                second.classroom = temp;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
