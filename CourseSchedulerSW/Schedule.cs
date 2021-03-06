﻿using System;
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

        public Schedule(Section sec, Classroom clas, int start, int end, int day)
        {
            section = sec;
            classroom = clas;
            startHour = start;
            endHour = end;
            whichDay = day;
        }

        public int calcDuration()
        {
            return endHour - startHour;
        }

        private bool mutateHour()
        {
            int newHour;
            try
            {
                Random rnd = new Random();
                int duration = endHour - startHour;
                newHour = rnd.Next(section.whichCourse.department.dayStartTime, section.whichCourse.department.dayEndTime - duration);
                startHour = newHour;
                endHour = newHour + duration;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool mutateClassroom()
        {
            try
            {
                Random rnd = new Random();
                int index = rnd.Next(0, classroom.faculty.ClassroomList.Count - 1);
                classroom = classroom.faculty.ClassroomList[index];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
