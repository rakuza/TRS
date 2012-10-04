using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Event_Management_System.CustomControls;

namespace Event_Management_System
{
    using Event_Management_System.DataObjects;

    public partial class ReportTool : Form
    {
        public ReportTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads all the events into the listbox of events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportTool_Load(object sender, EventArgs e)
        {
            //grabs an array of events
            lbxAllEvents.Items.AddRange(SQL.ReportTool.GetEventsAsArray());
        }

        /// <summary>
        /// moves an event to get proccessed into a report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMove_Click(object sender, EventArgs e)
        {
            //if nothing selected, nothing happens
            if (lbxAllEvents.SelectedItem != null)
            {
                //switch the item
                lbxSelectedEvents.Items.Add(lbxAllEvents.SelectedItem);
                lbxAllEvents.Items.RemoveAt(lbxAllEvents.SelectedIndex);
            }
        }

        /// <summary>
        /// moves an event to not be proccessed into a report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPutItBack_Click(object sender, EventArgs e)
        {
            //if nothing selected, nothing happens
            if (lbxSelectedEvents.SelectedItem != null)
            {
                //switch the item
                lbxAllEvents.Items.Add(lbxSelectedEvents.SelectedItem);
                lbxSelectedEvents.Items.RemoveAt(lbxSelectedEvents.SelectedIndex);
            }

        }


        /// <summary>
        /// Opens a save file dialogue then proccesses the report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRender_Click(object sender, EventArgs e)
        {
            //opens the dialogue
            if (SaveReport.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }


            //abort if no file name
            if (SaveReport.FileName != "")
            {
                //create a new list
                List<events> eventsList = new List<events>();

                //get the events from the listbox and add them to the events list
                foreach (object o in lbxSelectedEvents.Items)
                    eventsList.Add((events)o);

                //use the report writter to create and save a form
                ReportWriter2.CreateForm(SaveReport.InitialDirectory + SaveReport.FileName, chkGrandTotals.Checked,chkRunningTotals.Checked, eventsList);

                //if the chk for open on render it opens the rendered file
                if (chkOpen.Checked)
                {
                    Process.Start(SaveReport.InitialDirectory + SaveReport.FileName);
                }
            }
        }

        private void ReportTool_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Rt = false;
                }
            }
        }
    }
}
