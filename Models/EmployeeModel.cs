using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class EmployeeModel
    {
        public int WorkingPoints { get; set; }
        public int WorkingPointsEN { get; set; }
        public EmployeeDTOModel Employee { get; set; }
    }
}
