using projektPO.Models;
using projektPO.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class SubjectForm : Form
    {
        SubjectsForm _parentForm = new SubjectsForm();
        SubjectModel _subject;

        public SubjectForm(SubjectModel subject, SubjectsForm patrentForm)
        {
            InitializeComponent();
            PrepareForm();
            _subject = subject;
            _parentForm = patrentForm;
        }
        private void PrepareForm()
        {
            cbLanguage.DataSource = Enum.GetValues(typeof(Enums.Language));
            cbEndType.DataSource = Enum.GetValues(typeof(Enums.EndType));
            cbGuaranteeingInstitute.DataSource = DbService.Institutes().Select(x=>x.ShortName).ToList();
            if (_subject == null)
                return;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_subject != null)
            {
                PrepareSubject();
                DbService.SubjectUpdate(_subject);
                _parentForm.RefreshEmployeesTable();
            }
            else
            {
                PrepareSubject();
                DbService.SubjectInsert(_subject);
                _parentForm.RefreshEmployeesTable();
                this.Close();
            }
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
    }
}
