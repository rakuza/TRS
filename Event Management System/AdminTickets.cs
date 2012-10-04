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
    public partial class AdminTickets : Form
    {

        BindingList<ticket> tickets = new BindingList<ticket>();
        Boolean editingRow = false;
        Boolean newRow = false;

        public AdminTickets()
        {
            InitializeComponent();
            dgvTickets.DataSource = tickets;
        }


        private void UpdateTable(object sender, EventArgs e)
        {
            tickets = SQL.TicketAdmin.GetAllTickets();
            dgvTickets.DataSource = tickets;
            lblRefresh.Text = DateTime.Now.ToString();
            dgvTickets.Refresh();

        }

        private void dgvTickets_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SQL.TicketAdmin.DeleteTicket((ticket)e.Row.DataBoundItem);
        }

        private void dgvTickets_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvTickets.EndEdit();

            if (editingRow)
            {
                //save row
                if (newRow)
                {
                    //new row
                    ticket newTicket = (ticket)dgvTickets.Rows[e.RowIndex].DataBoundItem;
                    newTicket.deleted = 0;
                    SQL.TicketAdmin.InsertTicket(newTicket);
                    newRow = false;
                }
                else
                {
                    //edit row
                    SQL.TicketAdmin.EditTicket((ticket)dgvTickets.Rows[e.RowIndex].DataBoundItem);
                }
                editingRow = false;
            }
            else
            {
                //changing row
            }
        }

        private void dgvTickets_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editingRow = true;
        }

        private void dgvTickets_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRow = true;
        }

        private void AdminTickets_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Mt = false;
                }
            }
        }


        
    }
}
