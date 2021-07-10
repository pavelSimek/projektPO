using projektPO.Models;
using projektPO.Services;
using System;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeModel _employee = new EmployeeModel();
        private Employees _parentForm;
        public EmployeeForm(EmployeeModel employee, Employees parentForm)
        {
            InitializeComponent();
            _employee = employee;
            PrepareForm();
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
            bAdd.Text = "Uložit";
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
                if (!CheckDuplicity())
                      return;
                DbService.EmployeeUpdate(_employee);
            }
            else
            {
                PrepareEmployee();
                if (!CheckDuplicity())
                    return;
                DbService.EmployeeInsert(_employee);
                this.Close();
            }
        }
        private void PrepareEmployee() 
        {
            if (_employee == null)
            {
                _employee = new EmployeeModel();
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
        private bool CheckDuplicity()
        {
            var employeeDuplicity = DbService.EmployeeExists(_employee.PartyCode, _employee.Id);
            if (employeeDuplicity != null)
            {
                MessageBox.Show(string.Format("Zaměstnanec s tímto RČ v systému existuje. Jmenuje se: {0} {1}", employeeDuplicity.FirstName, employeeDuplicity.LastName));
                return false;
            }
            return true;
        }

        private void EmployeeForm_FormClosing(object sender, EventArgs e)
        {
            _parentForm.RefreshEmployeesTable();
            _parentForm.Show();
        }
    }
}
