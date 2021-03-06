using projektPO.Models;
using projektPO.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class SubjectForm : Form
    {
        SubjectsForm _parentForm = new SubjectsForm();
        SubjectModel _subject;
        List<StudyGroupModel> _studyGroups = new List<StudyGroupModel>();

        public SubjectForm(SubjectModel subject, SubjectsForm patrentForm)
        {
            InitializeComponent();
            _subject = subject;
            PrepareForm();
            _parentForm = patrentForm;
        }
        private void PrepareForm()
        {
            cbLanguage.DataSource = Enum.GetValues(typeof(Enums.Language));
            cbEndType.DataSource = Enum.GetValues(typeof(Enums.EndType));
            cbGuaranteeingInstitute.DataSource = DbService.Institutes().Select(x => x.ShortName).ToList();
            if (_subject == null)
                return;

            tbName.Text = _subject.Name;
            tbShortName.Text = _subject.ShortName;
            nLectureHours.Value = _subject.LectureHours;
            nExcerciseHours.Value = _subject.ExerciseHours;
            nSeminarHours.Value = _subject.SeminarHours;
            tbGuarantorName.Text = _subject.GuarantorName;
            nClassSize.Value = _subject.ClassSize;
            nCredits.Value = _subject.Credits;
            cbGuaranteeingInstitute.Text = _subject.GuaranteeingInstitute;
            tbGuarantorName.Text = _subject.GuarantorName;
            nWeeks.Value = _subject.Weeks;
            cbEndType.SelectedIndex = (int)_subject.EndType;
            cbLanguage.SelectedIndex = (int)_subject.Language;
            bAdd.Text = "Uložit";

            _studyGroups = DbService.SubjectStudyGroups(_subject.Id.Value);
            dgStudyGroups.DataSource = _studyGroups;
            dgStudyGroups.Columns["Id"].Visible = false;
            dgStudyGroups.Columns["ShortName"].HeaderText = "Zkratka";
            dgStudyGroups.Columns["Name"].HeaderText = "Název";
            dgStudyGroups.Columns["Language"].HeaderText = "Jazyk";
            dgStudyGroups.Columns["StudyForm"].HeaderText = "Druh studia (k. / p.)";
            dgStudyGroups.Columns["StudyType"].HeaderText = "Druh studia(mrg. / bc.)";
            dgStudyGroups.Columns["NumberOfStudents"].HeaderText = "Počet studentů";
            dgStudyGroups.Columns["Semester"].HeaderText = "Semestr";
            dgStudyGroups.Columns["Year"].HeaderText = "Rok";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_subject != null)
            {
                PrepareSubject();
                var subject = DbService.Subject(_subject.Id.Value);
                DbService.SubjectUpdate(_subject);
                if (subject.ClassSize != _subject.ClassSize)
                    EventGenerator.GenerateEventAfterSubjectChanged(_subject.Id.Value);
            }
            else
            {
                PrepareSubject();
                DbService.SubjectInsert(_subject);
            }
            _parentForm.RefreshSubjectsTable();
            this.Close();
        }
        private void PrepareSubject()
        {
            if (_subject == null)
                _subject = new SubjectModel();

            _subject.Name = tbName.Text;
            _subject.ShortName = tbShortName.Text;
            _subject.LectureHours = (int)nLectureHours.Value;
            _subject.ExerciseHours = (int)nExcerciseHours.Value;
            _subject.SeminarHours = (int)nSeminarHours.Value;
            _subject.GuarantorName = tbGuarantorName.Text;
            _subject.EndType = (Enums.EndType)Enum.Parse(typeof(Enums.EndType), cbEndType.Text);
            _subject.Language = (Enums.Language)Enum.Parse(typeof(Enums.Language), cbLanguage.Text);
            _subject.ClassSize = (int)nClassSize.Value;
            _subject.Credits = (int)nCredits.Value;
            _subject.GuaranteeingInstitute = cbGuaranteeingInstitute.Text;
            _subject.GuarantorName = tbGuarantorName.Text;
            _subject.Weeks = (int)nWeeks.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbName.Text = string.Empty;
            tbShortName.Text = string.Empty;
            nLectureHours.Value = 0;
            nExcerciseHours.Value = 0;
            nSeminarHours.Value = 0;
            tbGuarantorName.Text = string.Empty;
            nClassSize.Value = 0;
            nCredits.Value = 0;
            cbGuaranteeingInstitute.Text = string.Empty;
            tbGuarantorName.Text = string.Empty;
            nWeeks.Value = 0;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (_subject == null)
                return;
            DbService.SubjectDelete(_subject.Id.Value);
            _parentForm.RefreshSubjectsTable();
            this.Close();
        }
    }
}
