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

    public partial class PurchaseTicket : Form
    {

        private user[] userlist;
        public PurchaseTicket()
        {
            InitializeComponent();
        }

        private void PurchaseTicket_Load(object sender, EventArgs e)
        {
            userlist = SQL.PurchaseTickets.GetUsersAsArray();
            lbxUsers.Items.AddRange(userlist);
            lbxTickets.Items.AddRange(SQL.PurchaseTickets.SelectAllTicketsAsList().ToArray());
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lbxUsers.Items.Clear();

            var search = from u in userlist
                         where u.username.Contains(tbxSearch.Text)
                         select u;

            foreach (user u in search)
                lbxUsers.Items.Add(u);
        }

        private void lbxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxUsers.SelectedItem != null)
            {
                lbxOwnedTickets.Items.Clear();
                lbxOwnedTickets.DisplayMember = "ticket";
                lbxOwnedTickets.Items.AddRange(SQL.PurchaseTickets.GetUsersUnusedTickets((user)lbxUsers.SelectedItem));
                user temp = (user)lbxUsers.SelectedItem;
                lblLastName.Text = temp.lastname;
                lblLastName.Visible = true;
                lblUsername.Text = temp.username;
                lblUsername.Visible = true;
                lblFirstName.Text = temp.firstname;
                lblFirstName.Visible = true;
                

            }
        }

        private void lbxTickets_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxUsers.SelectedItem != null)
            {
                ticket temp = (ticket)lbxTickets.SelectedItem;
                lblPrice.Text = temp.price.ToString("C");
                lblPrice.Visible = true;
                lblTicketName.Text = temp.ticketname;
                lblTicketName.Visible = true;
                lblType.Text = temp.condition;
                lblType.Visible = true;
                

                

            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (lbxUsers.SelectedItem != null && lbxTickets.SelectedItem != null)
            {
                purchased_ticket pt = SQL.PurchaseTickets.BuyTicket((user)lbxUsers.SelectedItem, (ticket)lbxTickets.SelectedItem);
                lbxOwnedTickets.Items.Add((purchased_ticket)pt);
            }
        }

        private void lbxOwnedTickets_SelectedValueChanged(object sender, EventArgs e)
        {
            lblOwnedTicketPrice.Text = ((purchased_ticket)lbxOwnedTickets.SelectedItem).paid.ToString("C");
            lblOwnedTicketTicketName.Text = ((purchased_ticket)lbxOwnedTickets.SelectedItem).ticket.ticketname;
            lblOwnedTicketType.Text = ((purchased_ticket)lbxOwnedTickets.SelectedItem).ticket.condition;
            lblOwnedTicketPrice.Visible = true;
            lblOwnedTicketTicketName.Visible = true;
            lblOwnedTicketType.Visible = true;

            if (((purchased_ticket)lbxOwnedTickets.SelectedItem).ticket.condition == "annual")
            {
                lblexpires.Visible = true;
                lblexpires.Text = "31/12/" + DateTime.Today.Year;
            }
            else
            {
                lblexpires.Visible = false;
                
            }

        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Pt = false;
                }
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            purchased_ticket ticketToRemove = lbxOwnedTickets.SelectedItem as purchased_ticket;
            SQL.PurchaseTickets.RemoveTicket(ticketToRemove);
            lbxOwnedTickets.Items.Clear();
            lbxOwnedTickets.DisplayMember = "ticket";
            lbxOwnedTickets.Items.AddRange(SQL.PurchaseTickets.GetUsersUnusedTickets((user)lbxUsers.SelectedItem));
            lblexpires.Visible = false;
            lblOwnedTicketPrice.Visible = false;
            lblOwnedTicketTicketName.Visible = false;
            lblOwnedTicketType.Visible = false;
        }





    }
}