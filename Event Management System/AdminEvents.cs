using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Event_Management_System.CustomControls;

namespace Event_Management_System
{
    using Event_Management_System.DataObjects;

    public partial class AdminEvents : Form
    {
        BindingList<events> events = new BindingList<events>();
        Boolean editingRow = false;
        Boolean newRow = false;

        public AdminEvents()
        {
            InitializeComponent();
        }

        public void UpdateTable(object sender, EventArgs e)
        {
            events = SQL.EventAdmin.GetAllEvents();
            dgvEvents.DataSource = events;
            lblRefresh.Text = DateTime.Now.ToString();

            dgvEvents.Refresh();
        }

        private void dgvEvents_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editingRow = true;
        }

        private void dgvEvents_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SQL.EventAdmin.DeleteEvent((events)e.Row.DataBoundItem);
        }

        private void dgvEvents_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvents.EndEdit();

            if (editingRow)
            {
                //save row
                if (newRow)
                {
                    //new row
                    events newEvent = (events)dgvEvents.Rows[e.RowIndex].DataBoundItem;
                    newEvent.deleted = 0;
                    SQL.EventAdmin.InsertEvent(newEvent);
                    newRow = false;
                }
                else
                {
                    //edit row
                    SQL.EventAdmin.UpdateEvent((events)dgvEvents.Rows[e.RowIndex].DataBoundItem);
                }
                editingRow = false;
            }
            else
            {
                //changing row
            }
        }

        private void dgvEvents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            newRow = true;
        }

        private void eventsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AdminEvents_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Me = false;
                }
            }
        }


    }
}
