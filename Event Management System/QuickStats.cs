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

    public partial class QuickStats : Form
    {
        public QuickStats()
        {
            InitializeComponent();
        }

        private void QuickStats_Load(object sender, EventArgs e)
        {
           int[] stats = SQL.QuickStats.GetStats();
           lblsold.Visible = true;
            lblSales.Visible = true;
            lblEvents.Visible = true;
            lblTickets.Visible = true;
            lblUsed.Visible = true;
            lblUsers.Visible = true;
            lblSales.Text = SQL.QuickStats.GetSales();
           lblEvents.Text = stats[2].ToString();
            lblUsers.Text = stats[0].ToString();
            lblTickets.Text = stats[1].ToString();
            lblUsed.Text = stats[4].ToString();
            lblsold.Text = stats[3].ToString();
                
        }

        private void QuickStats_Leave(object sender, EventArgs e)
        {
            foreach (Control c in this.MdiParent.Controls)
            {
                if (c.GetType() == new etbMenu().GetType())
                {
                    ((etbMenu)c).Qs = false;
                }
            }
        }
    }
}
