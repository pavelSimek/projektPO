using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class ScheduleEventExtendedModel : EventModel
    {
        public EmployeeModel Employee { get; set; }
        public SubjectModel Subject { get; set; }
    }
}
