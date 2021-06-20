using projektPO.Models;
using projektPO.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class Employees : Form
    {
        private List<Employee> employees = new List<Employee>();
        public Employees()
        {
            InitializeComponent();
            employees = DbService.Employees();
            dgEmployees.DataSource = employees;
            dgEmployees.Columns["Id"].Visible = false;
            dgEmployees.Columns["PersonalEmail"].Visible = false;
            dgEmployees.Columns["PhdStudent"].Width = 50;
            //dgEmployees.Columns["WorkingPoints"].Width = 50;
            //dgEmployees.Columns["WorkingPointsEN"].Width = 50;
            dgEmployees.Columns["WorkingTime"].Width = 50;
            dgEmployees.Columns["PhdStudent"].HeaderText = "Doktorand";
            //dgEmployees.Columns["WorkingPoints"].HeaderText = "Pracovní body";
            //dgEmployees.Columns["WorkingPointsEN"].HeaderText = "Pracovní body + EN";
            dgEmployees.Columns["WorkingTime"].HeaderText = "Úvazek";
            dgEmployees.Columns["FirstName"].HeaderText = "Jméno";
            dgEmployees.Columns["LastName"].HeaderText = "Příjmení";
            dgEmployees.Columns["WorkEmail"].HeaderText = "Pracovní mail";
        }

        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var employee = (Models.Employee)dgEmployees.Rows[dgEmployees.CurrentCell.RowIndex].DataBoundItem;
            var form = new EmployeeForm(employee, this);
            form.Show();
            employees = DbService.Employees();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var form = new EmployeeForm(null, this);
            form.Show();
        }
        public void RefreshEmployeesTable()
        {
            employees = DbService.Employees();
            dgEmployees.DataSource = employees;
        }
    }
}
