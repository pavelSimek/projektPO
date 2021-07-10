using projektPO.Models;
using projektPO.Services;
using System;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class StudyGroupForm : Form
    {
        StudyGroupsForm _parentForm;
        StudyGroupModel _studyGroup;
        public StudyGroupForm(StudyGroupModel studyGroup, StudyGroupsForm parentForm)
        {
            InitializeComponent();
            _studyGroup = studyGroup;
            _parentForm = parentForm;
            PrepareForm();
        }
        private void PrepareForm()
        {
            cbLanguage.DataSource = Enum.GetValues(typeof(Enums.Language));
            cbSemester.DataSource = Enum.GetValues(typeof(Enums.Semester));
            cbStudyForm.DataSource = Enum.GetValues(typeof(Enums.StudyForm));
            cbStudyType.DataSource = Enum.GetValues(typeof(Enums.StudyType));
            if (_studyGroup != null)
            {
                bAdd.Text = "Uložit";
                cbSemester.SelectedIndex = (int)_studyGroup.Semester;
                cbLanguage.SelectedIndex = (int)_studyGroup.Language;
                cbStudyForm.SelectedIndex = (int)_studyGroup.StudyForm;
                cbStudyType.SelectedIndex = (int)_studyGroup.StudyType;
                nClassSize.Value = _studyGroup.NumberOfStudents;
                nYear.Value = _studyGroup.Year;
                tbShortName.Text = _studyGroup.ShortName;
                tbName.Text = _studyGroup.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbLanguage.SelectedIndex = 0;
            cbSemester.SelectedIndex = 0;
            cbStudyForm.SelectedIndex = 0;
            cbStudyType.SelectedIndex = 0;
            nClassSize.Value = 0;
            nYear.Value = 0;
            tbShortName.Text = string.Empty;
            tbName.Text = string.Empty;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_studyGroup != null)
            {
                PrepareStudyGroup();
                DbService.StudyGroupUpdate(_studyGroup);
            }
            else
            {
                PrepareStudyGroup();
                DbService.StudyGroupInsert(_studyGroup);
            }
            _parentForm.RefreshStudyGroupsTable();
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (_studyGroup == null)
                return;
            DbService.StudyGroupDelete(_studyGroup.Id);
            this.Close();
            _parentForm.RefreshStudyGroupsTable();
        }
        private void PrepareStudyGroup()
        {
            if (_studyGroup == null)
            {
                _studyGroup = new StudyGroupModel();
            }
            _studyGroup.ShortName = tbShortName.Text;
            _studyGroup.Semester = (Enums.Semester)Enum.Parse(typeof(Enums.Semester), cbSemester.Text);
            _studyGroup.Language = (Enums.Language)Enum.Parse(typeof(Enums.Language), cbLanguage.Text);
            _studyGroup.StudyForm = (Enums.StudyForm)Enum.Parse(typeof(Enums.StudyForm), cbStudyForm.Text);
            _studyGroup.StudyType = (Enums.StudyType)Enum.Parse(typeof(Enums.StudyType), cbStudyType.Text);
            _studyGroup.Year = (int)nYear.Value;
            _studyGroup.NumberOfStudents = (int)nClassSize.Value;
            _studyGroup.Name = tbName.Text;
        }
    }
}
