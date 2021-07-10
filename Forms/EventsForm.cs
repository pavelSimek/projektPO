using projektPO.Models;
using projektPO.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projektPO.Forms
{
    public partial class EventsForm : Form
    {
        private List<EventModel> _events = new List<EventModel>();
        public EventsForm()
        {
            InitializeComponent();
            _events = DbService.Events();
            dgEvents.DataSource = _events;
            dgEvents.Columns["Id"].Visible = false;
            dgEvents.Columns["StudyGroupId"].Visible = false;
            dgEvents.Columns["SubjectID"].Visible = false;
            dgEvents.Columns["EmployeeID"].Visible = false;
            cbShow.Visible = cbWithoutEmployee.Visible = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var form = new EventForm(null, this);
            form.Show();
            this.Hide();
        }
        public void RefreshEventsTable()
        {
            _events = DbService.Events();
            dgEvents.DataSource = _events;
            dgEvents.Refresh();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            var eventModel = (EventModel)dgEvents.Rows[dgEvents.CurrentCell.RowIndex].DataBoundItem;
            var form = new EventForm(eventModel, this);
            form.Show();
            this.Hide();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            SetEventTable();
        }

        private void cbWithoutEmployee_CheckedChanged(object sender, EventArgs e)
        {
            SetEventTable();
        }
        private void SetEventTable()
        {
            _events = DbService.Events();
            if (cbShow.Checked)
                _events = _events.Where(x => x.SubjectID == null).ToList();
            if (cbWithoutEmployee.Checked)
                _events = _events.Where(x => x.EmployeeID == null).ToList();
            dgEvents.DataSource = _events;
            dgEvents.Refresh();
            if (checkBox1.Checked) {
                foreach (DataGridViewRow row in dgEvents.Rows)
                {
                    var item = (EventModel)row.DataBoundItem;

                    if (item.SubjectID == null)
                        row.DefaultCellStyle.BackColor = Color.MediumPurple;
                    if (item.EmployeeID == null)
                        row.DefaultCellStyle.BackColor = Color.Red;
                }
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbShow.Visible = cbWithoutEmployee.Visible = true;
            }
            else
            {
                cbShow.Checked = cbWithoutEmployee.Checked = false;
                cbShow.Visible = cbWithoutEmployee.Visible = false;
            }
            SetEventTable();
        }
    }
}
