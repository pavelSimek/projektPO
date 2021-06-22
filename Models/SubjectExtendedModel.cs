using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Models
{
    public class SubjectExtendedModel : SubjectModel
    {
        public List<StudyGroupModel> StudyGroups { get; set; }
    }
}
