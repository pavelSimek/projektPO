using projektPO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class EmployeeExtendedModel
    {
        public string FullName
        {
            get => Employee.FirstName + " " + Employee.LastName;
        }
        public double WorkingPoints { 
            get => WorkingPointsCalculator.CalculateEvents(Employee.Id.Value, Enums.Language.CZ); 
        }
        public double WorkingPointsEN { 
            get => WorkingPointsCalculator.CalculateEvents(Employee.Id.Value, null); 
        }
        public EmployeeModel Employee { get; set; }

        public int WorkingHoursCalculated {
            get => WorkingPointsCalculator.WorkingHoursCalculation(Employee.Id.Value);
        }
        public string WorkingHoursComplete { 
            get => WorkingHoursCalculated.ToString() + "/" + ((Employee.WorkingTime * 10 * 4)).ToString(); 
        }
    }
}
