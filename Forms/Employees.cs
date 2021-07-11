using projektPO.Models;
using projektPO.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class Employees : Form
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();
        public Employees()
        {
            InitializeComponent();
            employees = DbService.Employees();
            dgEmployees.DataSource = employees;
            dgEmployees.Columns["Id"].Visible = false;
            dgEmployees.Columns["PersonalEmail"].Visible = false;
            dgEmployees.Columns["PhdStudent"].HeaderText = "Doktorand";
            dgEmployees.Columns["WorkingTime"].HeaderText = "Úvazek";
            dgEmployees.Columns["FirstName"].HeaderText = "Jméno";
            dgEmployees.Columns["LastName"].HeaderText = "Příjmení";
            dgEmployees.Columns["WorkEmail"].HeaderText = "Pracovní mail";
            dgEmployees.Columns["Phone"].HeaderText = "Telefonní číslo";
            dgEmployees.Columns["PersonalPhone"].HeaderText = "Osobní telefonní číslo";
            dgEmployees.Columns["PartyCode"].HeaderText = "Rodné číslo";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var form = new EmployeeForm(null, this);
            form.Show();
            this.Hide();
        }
        public void RefreshEmployeesTable()
        {
            employees = DbService.Employees();
            dgEmployees.DataSource = employees;
            dgEmployees.Refresh();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var employee = (EmployeeModel)dgEmployees.Rows[dgEmployees.CurrentCell.RowIndex].DataBoundItem;
            var form = new EmployeeForm(employee, this);
            form.Show();
            this.Hide();
        }
    }
}
