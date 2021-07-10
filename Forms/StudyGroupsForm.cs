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
    public partial class StudyGroupsForm : Form
    {
        List<StudyGroupModel> _studyGroups;
        public StudyGroupsForm()
        {
            InitializeComponent();
            _studyGroups = DbService.StudyGroups();
            dgStudyGroups.DataSource = _studyGroups;
            dgStudyGroups.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new StudyGroupForm(null, this);
            form.Show();
            this.Hide();
        }
        public void RefreshStudyGroupsTable()
        {
            _studyGroups = DbService.StudyGroups();
            dgStudyGroups.DataSource = _studyGroups;
            dgStudyGroups.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studyGroup = (StudyGroupModel)dgStudyGroups.Rows[dgStudyGroups.CurrentCell.RowIndex].DataBoundItem;
            var form = new StudyGroupForm(studyGroup, this);
            form.Show();
            this.Hide();
        }
    }
}
