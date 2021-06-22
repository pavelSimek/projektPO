using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projektPO.Models.Enums;

namespace projektPO.Models
{
    public class StudyGroupModel
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public int Year { get; set; }
        public Semester Semester { get; set; }
        public int NumberOfStudents { get; set; }
        public StudyForm StudyForm { get; set; }
        public StudyType StudyType { get; set; }
        public Language Language{ get; set; }
    }
}
