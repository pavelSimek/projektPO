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
            dgSubjects.Columns["Id"].Visible = false;
            dgSubjects.Columns["ShortName"].HeaderText = "Zkratka";
            dgSubjects.Columns["LectureHours"].HeaderText = "Hodin přednášek";
            dgSubjects.Columns["ExerciseHours"].HeaderText = "Hodin cvičení";
            dgSubjects.Columns["SeminarHours"].HeaderText = "Hodin seminářů";
            dgSubjects.Columns["EndType"].HeaderText = "Způsob zakončení";
            dgSubjects.Columns["Language"].HeaderText = "Jazyk";
            dgSubjects.Columns["ClassSize"].HeaderText = "Velikost třídy";
            dgSubjects.Columns["Credits"].HeaderText = "Počet kreditů";
            dgSubjects.Columns["GuaranteeingInstitute"].HeaderText = "Garantující ústav";
            dgSubjects.Columns["GuarantorName"].HeaderText = "Jméno garanta";
            dgSubjects.Columns["Weeks"].HeaderText = "Počet týdnů";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SubjectForm(null, this);
            form.Show();
        }
        public void RefreshSubjectsTable()
        {
            _subjects = DbService.Subjects();
            dgSubjects.DataSource = _subjects;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var subject = (SubjectModel)dgSubjects.Rows[dgSubjects.CurrentCell.RowIndex].DataBoundItem;
            var form = new SubjectForm(subject, this);
            form.Show();
        }
    }
}
