using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Management_System.CustomControls
{
    public partial class etbMenu : UserControl
    {
        bool mu = false;

        public bool Mu
        {
            get { return mu; }
            set { mu = value; }
        }
        bool mt = false;

        public bool Mt
        {
            get { return mt; }
            set { mt = value; }
        }
        bool me = false;

        public bool Me
        {
            get { return me; }
            set { me = value; }
        }
        bool qs = false;

        public bool Qs
        {
            get { return qs; }
            set { qs = value; }
        }
        bool rt = false;

        public bool Rt
        {
            get { return rt; }
            set { rt = value; }
        }
        bool pt = false;

        public bool Pt
        {
            get { return pt; }
            set { pt = value; }
        }
        bool re = false;

        public bool Re
        {
            get { return re; }
            set { re = value; }
        }

        public etbMenu()
        {
            InitializeComponent();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            
            foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new AdminUser().GetType())
                {
                    mu = true;
                }
            }

            if (!mu)
            {
                AdminUser editUser = new AdminUser();
                editUser.MdiParent = this.ParentForm;
                editUser.Show();
            }
        }

        private void btnEditEvents_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new AdminEvents().GetType())
                {
                    me = true;
                }
            }

                        if (!me)
                        {
                            AdminEvents editEvents = new AdminEvents();
                            editEvents.MdiParent = this.ParentForm;
                            editEvents.Show();
                        }
        }

        private void btnEditTickets_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new AdminTickets().GetType())
                {
                    mt = true;
                }
            }

            if (!mt)
            {
            AdminTickets editTickets = new AdminTickets();
            editTickets.MdiParent = this.ParentForm;
            editTickets.Show();
            }
        }

        private void btnRunEvent_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new RunEvent().GetType())
                {
                    re = true;
                }
            }

            if (!re)
            {
            RunEvent runEvent = new RunEvent();
            runEvent.MdiParent = this.ParentForm;
            runEvent.Show();
            }
        }

        private void btnQuickStats_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new QuickStats().GetType())
                {
                    qs = true;
                }
            }

            if (!qs)
            {
            QuickStats quickStats = new QuickStats();
            quickStats.MdiParent = this.ParentForm;
            quickStats.Show();
            }
        }

        private void btnEventReport_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new ReportTool().GetType())
                {
                    rt = true;
                }
            }

            if (!rt)
            {
            ReportTool eventReport = new ReportTool();
            eventReport.MdiParent = this.ParentForm;
            eventReport.Show();
            }
        }

        private void btnPurchaseTicket_Click(object sender, EventArgs e)
        {
                        foreach (Form c in this.ParentForm.MdiChildren)
            {
                if (c.GetType() == new PurchaseTicket().GetType())
                {
                    pt = true;
                }
            }

            if (!pt)
            {
            PurchaseTicket purchaseTicket = new PurchaseTicket();
            purchaseTicket.MdiParent = this.ParentForm;
            purchaseTicket.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BugForm bg = new BugForm();
            bg.Exception = new NullReferenceException();
            bg.MdiParent = this.ParentForm;
            bg.Show();
        }

        private void etbMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPrefs_Click(object sender, EventArgs e)
        {
            Prefs p = new Prefs();
            p.MdiParent = this.ParentForm;
            p.Show();

        }



    }
}
