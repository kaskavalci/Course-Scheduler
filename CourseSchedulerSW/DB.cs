using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSchedulerSW
{
    public class DB
    {
        CourseSchedulerEntities context;

        public DB()
        {
            context = new CourseSchedulerEntities(); 
        }

        public void hede()
        {
            FACULTY fac = new FACULTY();
            DEPARTMENT DP = fac.DEPARTMENT.FirstOrDefault<DEPARTMENT>();

            System.Windows.Forms.MessageBox.Show(context.FACULTY.FirstOrDefault<FACULTY>().FACU_NAME);
        }
    }
}
