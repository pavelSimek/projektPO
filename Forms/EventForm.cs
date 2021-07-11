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
    public partial class EventForm : Form
    {
        EventsForm _parentForm;
        EventModel _eventModel;
        List<EmployeeModel> _employees;
        List<SubjectModel> _subjects;
        public EventForm(EventModel eventModel, EventsForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _eventModel = eventModel;
            PrepareForm();
        }
        public void PrepareForm()
        {
            cbLanguage.DataSource = Enum.GetValues(typeof(Enums.Language));
            cbEventType.DataSource = Enum.GetValues(typeof(Enums.ScheduleEventType));
            _employees = new List<EmployeeModel>();
            _employees.Add(new EmployeeModel() { FirstName = "Zaměstnanec", Id = null });
            _employees.AddRange(DbService.Employees());
            cbEmployee.DataSource = _employees.Select(x => x.FirstName + " " + x.LastName).ToList();
            _subjects = new List<SubjectModel>();
            _subjects.Add(new SubjectModel() { Name = "Předmět", Id = null });
            _subjects.AddRange(DbService.Subjects());
            cbSubject.DataSource = _subjects.Select(x => x.Name).ToList();
            lWorkingPoints.Text = "";
            if (_eventModel == null)
                return;
            cbEmployee.SelectedIndex = _employees.FindIndex(x => x.Id == _eventModel.EmployeeID);
            cbSubject.SelectedIndex = _subjects.FindIndex(x => x.Id == _eventModel.SubjectID);
            cbLanguage.SelectedIndex = (int)_eventModel.Language;
            cbEventType.SelectedIndex = (int)_eventModel.ScheduleEventType;
            tbName.Text = _eventModel.Name;
            nHours.Value = _eventModel.Hours;
            nWeeks.Value = _eventModel.Weeks;
            nClassSize.Value = _eventModel.NumberOfStudents;
            cActive.Checked = _eventModel.Active;
            bAdd.Text = "Uložit";
            lWorkingPoints.Text = "Počet bodů za pracovní štítek: " + WorkingPointsCalculator.CalculateEvent(_eventModel).ToString();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_eventModel != null)
            {
                PrepareEvent();
                var eventM = DbService.Event(_eventModel.Id);
                DbService.EventUpdate(_eventModel);
                if(eventM.EmployeeID == null && _eventModel.EmployeeID != null && _eventModel.StudyGroupId != null)
                    EventGenerator.GenerateEventsAfterEmployee(_eventModel);
            }
            else
            {
                PrepareEvent();
                DbService.EventInsert(_eventModel);
            }
            this.Close();
            _parentForm.RefreshEventsTable();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (_eventModel == null)
                return;
            DbService.EventDelete(_eventModel.Id);
            _parentForm.RefreshEventsTable();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbName.Text = string.Empty;
            cbEmployee.SelectedIndex = 0;
            nWeeks.Value = 0;
            nHours.Value = 0;
            nClassSize.Value = 0;
            cbEventType.SelectedIndex = 0;
            cbLanguage.SelectedIndex = 0;
            cbSubject.SelectedIndex = 0;
            cActive.Checked = false;
        }

        private void PrepareEvent()
        {
            if (_eventModel == null)
            {
                _eventModel = new EventModel();
            }
            _eventModel.Name = tbName.Text;
            _eventModel.Active = cActive.Checked;
            var employeeIndex = cbEmployee.SelectedIndex;
            _eventModel.EmployeeID = _employees[employeeIndex].Id;
            _eventModel.Weeks = (int)nWeeks.Value;
            _eventModel.Hours = (int)nHours.Value;
            _eventModel.NumberOfStudents = (int)nClassSize.Value;
            var subjectIndex = cbSubject.SelectedIndex;
            _eventModel.SubjectID = _subjects[subjectIndex].Id;
            _eventModel.Language = (Enums.Language)Enum.Parse(typeof(Enums.Language), cbLanguage.Text);
            _eventModel.ScheduleEventType = (Enums.ScheduleEventType)Enum.Parse(typeof(Enums.ScheduleEventType), cbEventType.Text);
        }

        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventType = (Enums.ScheduleEventType)Enum.Parse(typeof(Enums.ScheduleEventType), cbEventType.Text);
            if (eventType == Enums.ScheduleEventType.Exam || eventType == Enums.ScheduleEventType.Credit || eventType == Enums.ScheduleEventType.GradedCredit)
            {
                nWeeks.Value = 0;
                nHours.Value = 0;
            }
        }

        private void nHours_ValueChanged(object sender, EventArgs e)
        {
            var eventType = (Enums.ScheduleEventType)Enum.Parse(typeof(Enums.ScheduleEventType), cbEventType.Text);
            if (eventType == Enums.ScheduleEventType.Exam || eventType == Enums.ScheduleEventType.Credit || eventType == Enums.ScheduleEventType.GradedCredit)
            {
                nWeeks.Value = 0;
                nHours.Value = 0;
            }
        }

        private void nWeeks_ValueChanged(object sender, EventArgs e)
        {
            var eventType = (Enums.ScheduleEventType)Enum.Parse(typeof(Enums.ScheduleEventType), cbEventType.Text);
            if (eventType == Enums.ScheduleEventType.Exam || eventType == Enums.ScheduleEventType.Credit || eventType == Enums.ScheduleEventType.GradedCredit)
            {
                nWeeks.Value = 0;
                nHours.Value = 0;
            }
        }
    }
}
