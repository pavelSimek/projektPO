using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class StudyGroupExtendedModel : StudyGroupModel
    {
        public List<SubjectExtendedModel> Subjects { get; set; }
    }
}
