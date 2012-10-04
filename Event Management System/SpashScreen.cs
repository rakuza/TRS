using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;


namespace Event_Management_System
{
    using DataObjects;

    public partial class SpashScreen : Form
    {
        public SpashScreen()
        {
            InitializeComponent();
        }

        private void SpashScreen_Load(object sender, EventArgs e)
        {
            lblBuildNo.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString() ;
            
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));
            this.Show();
            this.Refresh();
            Thread.Sleep(1000);
            SQL.CheckConnection();
            this.Close();
        }
    }
}
