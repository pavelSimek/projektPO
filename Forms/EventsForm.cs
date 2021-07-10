using projektPO.Models;
using projektPO.Services;
using System;
using System.Collections.Generic;
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
    }
}
