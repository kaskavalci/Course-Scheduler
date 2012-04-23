using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class Proffesor
    {
        private string Name;
        private List<Section> ListSection;
        private int ID, fitness;
        public int Coefficient { get; set; }


        protected int calcPenalty()
        {
            return 0;
        }

        private int calcSameHourPenalty()
        {
            return 0;
        }

        

    }
}
