using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projektPO.Models.Enums;

namespace projektPO.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EmployeeID { get; set; }
        public int? SubjectID { get; set; }
        public int NumberOfStudents { get; set; }
        public ScheduleEventType ScheduleEventType { get; set; }
        public int Hours { get; set; }
        public int Weeks { get; set; }
        public Language Language { get; set; }
        public bool Active { get; set; }
        public int? StudyGroupId { get; set; }
    }
}
