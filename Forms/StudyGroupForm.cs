using projektPO.Models;
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
    public partial class StudyGroupForm : Form
    {
        StudyGroupsForm _parentForm;
        StudyGroupModel _studyGroup;
        public StudyGroupForm(StudyGroupModel studyGroup, StudyGroupsForm parentForm)
        {
            InitializeComponent();
            PrepareForm();
            _studyGroup = studyGroup;
            _parentForm = parentForm;
        }
        private void PrepareForm()
        { 
        
        }
    }
}
