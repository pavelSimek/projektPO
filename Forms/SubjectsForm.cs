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
    public partial class SubjectsForm : Form
    {
        List<SubjectModel> _subjects;

        public SubjectsForm()
        {
            InitializeComponent();
            _subjects = DbService.Subjects();
            dgSubjects.DataSource = _subjects;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SubjectForm(null, this);
            form.Show();
        }
        public void RefreshEmployeesTable()
        {
            _subjects = DbService.Subjects();
            dgSubjects.DataSource = _subjects;
        }

        private void dgSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var subject = (SubjectModel)dgSubjects.Rows[dgSubjects.CurrentCell.RowIndex].DataBoundItem;
            var form = new SubjectForm(subject, this);
            form.Show();
        }
    }
}
