using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class EmployeeDTOModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PartyCode { get; set; }
        public string WorkEmail { get; set; }
        public string PersonalEmail { get; set; }
        public string Phone { get; set; }
        public string PersonalPhone { get; set; }
        public double WorkingTime { get; set; }
        public bool PhdStudent { get; set; }
    }
}
