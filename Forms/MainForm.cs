using projektPO.Services;
using projektPO.Forms;
using System.Windows.Forms;

namespace projektPO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var Employee = new Employees();
            Employee.Show();
        }
    }
}
