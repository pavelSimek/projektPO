using System;
using System.Xml.Serialization;

namespace projektPO.Models
{
    public class WorkPointsValueModel
    {
        public double LectureHour { get; set; }
        public double ExcerciseHour { get; set; }
        public double SeminarHour { get; set; }
        public double LectureHourEN { get; set; }
        public double ExcerciseHourEN { get; set; }
        public double SeminarHourEN { get; set; }
        public double CreditGrant { get; set; }
        public double GradedCreditGrant { get; set; }
        public double ExamGrant { get; set; }
        public double CreditGrantEN { get; set; }
        public double GradedCreditGrantEN { get; set; }
        public double ExamGrantEN { get; set; }
    }
}
