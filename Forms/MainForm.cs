using projektPO.Forms;
using projektPO.Models;
using projektPO.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projektPO
{
    public partial class MainForm : Form
    {
        List<EmployeeExtendedModel> _employees;
        public MainForm()
        {
            InitializeComponent();
            _employees = new List<EmployeeExtendedModel>();
            var employees = DbService.Employees();
            foreach (var employee in employees)
            {
                _employees.Add(new EmployeeExtendedModel()
                {
                    Employee = employee
                }) ;
            }
            dgEmployees.DataSource = _employees;
            dgEmployees.Columns["Employee"].Visible = false;
            dgEmployees.Columns["WorkingHoursCalculated"].Visible = false;
            dgEmployees.Columns["FullName"].HeaderText = "Jméno";
            dgEmployees.Columns["WorkingPoints"].HeaderText = "Pracovní body";
            dgEmployees.Columns["WorkingPointsEN"].HeaderText = "Pracovní body s EN";
            dgEmployees.Columns["WorkingHoursComplete"].HeaderText = "Naplnění úvazku";
        }

        private void bEmployee_Click(object sender, System.EventArgs e)
        {
            var form = new Employees();
            form.Show();
        }

        private void bSubject_Click(object sender, System.EventArgs e)
        {
            var form = new SubjectsForm();
            form.Show();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var form = new EventsForm();
            form.Show();
        }

        private void bGroup_Click(object sender, System.EventArgs e)
        {
            var form = new StudyGroupsForm();
            form.Show();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            var form = new StudyGroupSubjectForm();
            form.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _employees = new List<EmployeeExtendedModel>();
            var employees = DbService.Employees();
            foreach (var employee in employees)
            {
                _employees.Add(new EmployeeExtendedModel()
                {
                    Employee = employee
                });
            }
            dgEmployees.DataSource = _employees;
            dgEmployees.Refresh();
        }
    }
}
