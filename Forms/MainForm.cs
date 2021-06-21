using projektPO.Forms;
using System.Windows.Forms;

namespace projektPO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
