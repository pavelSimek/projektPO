using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class WorkingPointEventModel
    {
        public Enums.ScheduleEventType ScheduleEventType { get; set; }
        public int Hours { get; set; }
        public int NumberOfStudents { get; set; }
        public Enums.Language Language { get; set; }
        public bool Active { get; set; }
    }
}
