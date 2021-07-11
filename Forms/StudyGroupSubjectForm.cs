using projektPO.Models;
using projektPO.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class StudyGroupSubjectForm : Form
    {
        List<StudyGroupModel> _studyGroups;
        List<SubjectModel> _subjects;
        public StudyGroupSubjectForm()
        {
            InitializeComponent();
            _studyGroups = DbService.StudyGroups();
            cbStudyGroup.DataSource = _studyGroups.Select(x => x.ShortName + " - " + x.Name).ToList();
            _subjects = DbService.Subjects();
            cbSubject.DataSource = _subjects.Select(x => x.ShortName + " - " + x.Name).ToList();
            CheckSubjects();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var studyGroupIndex = cbStudyGroup.SelectedIndex;
            var subjectIndex = cbSubject.SelectedIndex;
            var studyGroupSubject = new StudyGroupSubjectModel()
            {
                SubjectID = _subjects[subjectIndex].Id.Value,
                StudyGroupID = _studyGroups[studyGroupIndex].Id
            };
            var subjectExist = DbService.StudyGroupSubject(studyGroupSubject.StudyGroupID, studyGroupSubject.SubjectID);
            if (subjectExist.Count == 0)
            {
                EventGenerator.GenerateEventsAfterPairing(studyGroupSubject);
                DbService.StudyGroupSubjectInsert(studyGroupSubject);
            }
            CheckSubjects();
            this.Close();
        }

        private void cbStudyGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSubjects();
        }

        private void CheckSubjects()
        {
            var studyGroupIndex = cbStudyGroup.SelectedIndex;
            var subjectStudyGroups = DbService.StudyGroupSubject(_studyGroups[studyGroupIndex].Id, null);
            _subjects = DbService.Subjects();
            _subjects = _subjects.Where(x => !subjectStudyGroups.Any(y => y.SubjectID == x.Id.Value)).ToList();
            cbSubject.DataSource = _subjects.Select(x => x.ShortName + " - " + x.Name).ToList();
        }
    }
}
