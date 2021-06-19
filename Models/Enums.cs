using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class Enums
    {
        public enum EndType
        {
            ZK,
            Z
        }
        public enum Language
        {
            CZ,
            EN
        }
        public enum GuaranteeingInstitute
        {
            UIUI,
            Other
        }
        public enum Semester
        {
            LS,
            ZS
        }
        public enum StudyForm
        {
            P,
            K
        }
        public enum StudyType
        {
            Bc,
            Mgr
        }
        public enum ScheduleEventType
        { 
            Lecture,
            Exercise, 
            Seminar, 
            Credit, 
            GradedCredit,
            Exam
        }
    }
}
