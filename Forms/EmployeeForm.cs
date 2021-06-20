using projektPO.Models;
using projektPO.Services;
using System;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class EmployeeForm : Form
    {
        private Employee _employee = new Employee();
        private Employees _parentForm;
        public EmployeeForm(Employee employee, Employees parentForm)
        {
            InitializeComponent();
            _employee = employee;
            PrepareForm();
            _parentForm = new Employees();
            _parentForm = parentForm;
        }
        private void PrepareForm()
        {
            if (_employee == null)
                return;

            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbPartyCode.Text = _employee.PartyCode;
            tbPersonalEmail.Text = _employee.PersonalEmail;
            tbPersonalPhone.Text = _employee.PersonalPhone;
            tbWorkMail.Text = _employee.WorkEmail;
            tbWorkPhone.Text = _employee.Phone;
            nWorkTime.Value = Convert.ToDecimal(_employee.WorkingTime);
            cbPhdStudent.Checked = _employee.PhdStudent;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPartyCode.Text = string.Empty;
            tbPersonalEmail.Text = string.Empty;
            tbPersonalPhone.Text = string.Empty;
            tbWorkMail.Text = string.Empty;
            tbWorkPhone.Text = string.Empty;
            nWorkTime.Value = 0;
            cbPhdStudent.Checked = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_employee != null)
            {
                PrepareEmployee();
                DbService.EmployeeUpdate(_employee);
                _parentForm.RefreshEmployeesTable();
            }
            else
            {
                PrepareEmployee();
                DbService.EmployeeInsert(_employee);
                _parentForm.RefreshEmployeesTable();
                this.Close();
            }
        }
        private void PrepareEmployee() 
        {
            if (_employee == null)
            {
                _employee = new Employee();
            }
            _employee.FirstName = tbFirstName.Text;
            _employee.LastName = tbLastName.Text;
            _employee.PartyCode = tbPartyCode.Text;
            _employee.PersonalEmail = tbPersonalEmail.Text;
            _employee.PersonalPhone = tbPersonalPhone.Text;
            _employee.WorkEmail = tbWorkMail.Text;
            _employee.Phone = tbWorkPhone.Text;
            _employee.WorkingTime = Convert.ToDouble(nWorkTime.Value.ToString());
            _employee.PhdStudent = cbPhdStudent.Checked;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (_employee == null)
                return;
            DbService.EmployeeDelete(_employee.Id);
            _parentForm.RefreshEmployeesTable();
            this.Close();
        }
    }
}
