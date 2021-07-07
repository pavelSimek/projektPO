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
            PrepareForm();
            _parentForm = parentForm;
            _eventModel = eventModel;
        }
        public void PrepareForm()
        {
            cbLanguage.DataSource = Enum.GetValues(typeof(Enums.Language));
            cbEventType.DataSource = Enum.GetValues(typeof(Enums.ScheduleEventType));
            _employees = DbService.Employees();
            cbEmployee.DataSource = _employees.Select(x => x.FirstName + " " + x.LastName).ToList();
            _subjects = DbService.Subjects();
            cbSubject.DataSource = _subjects.Select(x => x.Name).ToList();

        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_eventModel != null)
            {
                PrepareEvent();
                DbService.EventUpdate(_eventModel);
            }
            else
            {
                PrepareEvent();
                DbService.EventInsert(_eventModel);
                this.Close();
            }
            this.Close();
            _parentForm.RefreshEventsTable();
        }

        private void bClear_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            _parentForm.RefreshEventsTable();
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
    }
}
