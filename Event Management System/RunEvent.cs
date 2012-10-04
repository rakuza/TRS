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

    public partial class RunEvent : Form
    {
        //event currently being altered
        private events activeEvent;
        //user currently being altered
        private user activeUser;
        //list of all tickets
        private List<ticket> ticketlist = new List<ticket>();
        //shows tickets that belong to a person
        private ticket[] personSpecificTickets;
        //holds a list of all people
        private user[] userlist;
        //holds an array of admited people
        private user[] admitedList;

        public RunEvent()
        {
            InitializeComponent();
            //grab all the tickets
            ticketlist = SQL.RunEvent.SelectAllTicketsAsList();
        }

        /// <summary>
        /// Refeashing the items in the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateEventSelection(object sender, EventArgs e)
        {
            //clears the list box
            cbxEvents.Items.Clear();
            //adds the events from the sql class
            cbxEvents.Items.AddRange(SQL.RunEvent.SelectUpComingEvents());
        }

        /// <summary>
        /// selecting the event to alter and filling in controls with info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbxEvents.SelectedIndex > -1)
            {
                //gets the active event from the combobox
                activeEvent = (events)cbxEvents.SelectedItem;
                //enables the form
                tbcEventManage.Enabled = true;
                //clears the list box
                lbxUsers.Items.Clear();
                //grabs a list of all the users not attending the event
                userlist = SQL.RunEvent.SelectUsersNotAttending(activeEvent);
                //adds a list of users
                lbxUsers.Items.AddRange(userlist);
            }
        }

        /// <summary>
        /// When a different user is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            //if there is something selected
            if (lbxUsers.SelectedIndex > -1)
            {
                //make the active user the selected user
                activeUser = (user)lbxUsers.SelectedItem;
                //fills in the user info and makes the following labels visible
                lblFirstName.Text = activeUser.firstname;
                lblFirstName.Visible = true;
                lblLastName.Text = activeUser.lastname;
                lblLastName.Visible = true;
                lblUsername.Text = activeUser.username;
                lblUsername.Visible = true;
                //clears the prepaid ticket list
                lbxTickets.Items.Clear();
                //clears all the tickets
                personSpecificTickets = null;
                //grabs all the tickets the person has already bought
                personSpecificTickets = SQL.RunEvent.SelectPurchasedTickets(activeUser);
                //adds the list to the listbox
                lbxTickets.Items.AddRange(personSpecificTickets);
               
                
                //clear all the tickets in the list
                cbxTickets.Items.Clear();

                //adds tickets to the ticket list
                foreach (ticket t in ticketlist)
                    cbxTickets.Items.Add(t.ticketname +" "+ t.price.ToString("C"));
                
            }
        }

        /// <summary>
        /// should be wiping the selected item from the listbox when something is selected in the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTickets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxTickets.SelectedIndex = -1;
        }

        /// <summary>
        /// should be wiping the selected item from the combobox when something is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTickets.SelectedIndex = -1;
        }

        /// <summary>
        /// searchs the list of users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxSearchUsers_TextChanged(object sender, EventArgs e)
        {
            //clear the listbox
            lbxUsers.Items.Clear();

            //linq query on the info
            var search = from u in userlist
                         where u.username.Contains(tbxSearchUsers.Text)
                         select u;

            //adds them back to the listbox
            foreach (user u in search)
                lbxUsers.Items.Add(u);

        }

        /// <summary>
        /// Attend a user back to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttend_Click(object sender, EventArgs e)
        {
            //if nothing seleted do nothing like a boss
            if (lbxUsers.SelectedItem == null)
            {
                return;
            }

            //if the prepaid tickets has been selected
            if (lbxTickets.SelectedItem != null)
            {
                //admits the user where a prepaid ticket has been selected
                SQL.RunEvent.UseTicket(activeUser, (ticket)lbxTickets.SelectedItem, activeEvent);
            }
                //if the quick tickets is selected
            else if (cbxTickets.SelectedItem != null)
            {
                //raw string
                string ticketPrice = cbxTickets.SelectedItem.ToString();
                //grab just the name
                ticketPrice = ticketPrice.Split('$')[0];
                //select the ticket from the list
                var selectTicket = (from t in ticketlist
                                    where t.ticketname == ticketPrice
                                    select t).Single();
                //buy a ticket and admit the user
                SQL.RunEvent.QuickTicketUser(activeUser, selectTicket, activeEvent);
            }
            //refresh the combobox
            btnStart_Click(sender, e);
            //clear all the listboxes
            lbxTickets.Items.Clear();
            cbxTickets.Items.Clear();
        }

        /// <summary>
        /// unadmits users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnattend_Click(object sender, EventArgs e)
        {
            //if some one is selected
            if (lbxAdmitedUsers.SelectedItem != null)
            {
                //remove them from the event using the query
                SQL.RunEvent.UndoTicket((user)lbxAdmitedUsers.SelectedItem, activeEvent);
                lblAlterFirstName.Visible = false;
                lblAlterLastname.Visible = false;
                lblAlterTicket.Visible = false;
                lblAlterUsername.Visible = false;
                //refresh form
                tabAdjustEvent_Enter(sender, e);

            }
        }

        /// <summary>
        /// then the admit user tab is entered into
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabAdmitUser_Enter(object sender, EventArgs e)
        {
            //checks to see if an event has been selected
            if (cbxEvents.SelectedIndex > -1)
            {
                //clears the user box
                lbxUsers.Items.Clear();
                //selects all the users not going to that event
                userlist = SQL.RunEvent.SelectUsersNotAttending(activeEvent);
                //adds them back to the list
                lbxUsers.Items.AddRange(userlist);
            }
        }

        /// <summary>
        /// adjust events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabAdjustEvent_Enter(object sender, EventArgs e)
        {
            //if no event has been selected do nothing
            if (cbxEvents.SelectedIndex > -1)
            {
                //make the active event  the combobo's event
                activeEvent = (events)cbxEvents.SelectedItem;
                //enable the tab
                tbcEventManage.Enabled = true;
                //clear the list box of admited users
                lbxAdmitedUsers.Items.Clear();
                //refil list from query
                admitedList = SQL.RunEvent.SelectAttendingUsers(activeEvent);
                //fill the list box
                lbxAdmitedUsers.Items.AddRange(admitedList);
            }
        }

        /// <summary>
        ///user is changed so it is  enabling all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxAdmitedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //grabs the user
            var users = (user)lbxAdmitedUsers.SelectedItem;

            //if empty show messagebox
            if (users == null)
            {
                MessageBox.Show("Please Select a User to unattend");
            }
            else
            {
                //activate following fields
                lblAlterFirstName.Text = users.firstname;
                lblAlterFirstName.Visible = true;
                lblAlterLastname.Visible = true;
                lblAlterUsername.Visible = true;
                lblAlterTicket.Visible = true;
                lblAlterLastname.Text = users.lastname;
                lblAlterUsername.Text = users.username;
                //grab the ticket relating to the user and the active event
                lblAlterTicket.Text = SQL.RunEvent.SelectSingleTicket(users, activeEvent);
            }
        }

        private void RunEvent_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Re = false;
                }
            }
        }


    }
}
