using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projektPO.Models.Enums;

namespace projektPO.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public int LectureHours { get; set; }
        public int ExercisesHours { get; set; }
        public int SeminarHours { get; set; }
        public EndType EndType { get; set; }
        public Language Language { get; set; }
        public int ClassSize { get; set; }
        public int WorkingPointsEN { get; set; }
        public bool PhdStudent { get; set; }
        public int Credits { get; set; }
        public GuaranteeingInstitute GuaranteeingInstitute { get; set; }
        public string GuarantorName { get; set; }
        public List<StudyGroup> StudyGroups { get; set; }
    }
}
