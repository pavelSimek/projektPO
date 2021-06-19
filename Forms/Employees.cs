using projektPO.Services;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            var employees = DbService.Employees();
            dgEmployees.DataSource = employees;
            dgEmployees.Columns["Id"].Visible = false;
            dgEmployees.Columns["PersonalEmail"].Visible = false;
            dgEmployees.Columns["PhdStudent"].Width = 50;
            dgEmployees.Columns["WorkingPoints"].Width = 50;
            dgEmployees.Columns["WorkingPointsEN"].Width = 50;
            dgEmployees.Columns["WorkingTime"].Width = 50;
            dgEmployees.Columns["PhdStudent"].HeaderText = "Doktorand";
            dgEmployees.Columns["WorkingPoints"].HeaderText = "Pracovní body";
            dgEmployees.Columns["WorkingPointsEN"].HeaderText = "Pracovní body + EN";
            dgEmployees.Columns["WorkingTime"].HeaderText = "Úvazek";
            dgEmployees.Columns["FirstName"].HeaderText = "Jméno";
            dgEmployees.Columns["LastName"].HeaderText = "Příjmení";
            dgEmployees.Columns["WorkEmail"].HeaderText = "Pracovní mail";
        }

        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dgEmployees.CurrentCell.RowIndex;
            var xy = (Models.Employee)dgEmployees.Rows[x].DataBoundItem;
            var form = new Employee(xy);
            form.Show();
        }
    }
}
