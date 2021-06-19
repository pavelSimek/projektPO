using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projektPO.Models.Enums;

namespace projektPO.Models
{
    public class ScheduleEvent
    {
        public string Name { get; set; }
        public EmployeeModel Employee  { get; set; }
        public SubjectModel Subject { get; set; }
        public int NumberOfStudents { get; set; }
        public ScheduleEventType ScheduleEventType { get; set; }
        public int Hours { get; set; }
        public int Weeks { get; set; }
        public Language Language { get; set; }
    }

    /*public double PointsPerEvent()
    {
        double x = 0;
        return x;
    }*/
}
