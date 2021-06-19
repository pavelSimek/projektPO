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

namespace projektPO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var x = new DbService() { };
            x.EmployeeInsert(new Models.EmployeeModel()
            {
                FirstName = "test",
                PhdStudent = false
            }
            );

        }
    }
}
