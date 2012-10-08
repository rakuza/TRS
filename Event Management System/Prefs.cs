using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Management_System
{
    using Properties;
    using DataObjects;

    public partial class Prefs : Form
    {
        public Prefs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();

            sc.DataSource = tbxServer.Text;
            sc.InitialCatalog = tbxDataSource.Text;

            if (chkwinauth.Checked^ true)
            {
                sc.Password = tbxPassword.Text;
                sc.UserID = tbxUserName.Text;
                sc.IntegratedSecurity = false;
            }
            else
            {
                sc.IntegratedSecurity =true;
            }
            

            Settings.Default.ConnectionString = sc.ConnectionString;
            Settings.Default.Save();
            SQL.UpdateConnectionString();

            this.Close();

            
        }

        private void Prefs_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder(Settings.Default.ConnectionString);
            
            tbxUserName.Text = sc.UserID;
            tbxServer.Text = sc.DataSource;
            tbxPassword.Text = sc.Password;
            tbxDataSource.Text = sc.InitialCatalog;
        }

        private void chkwinauth_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            tbxUserName.Enabled = chk.Checked ^ true;
            tbxPassword.Enabled = chk.Checked ^ true;
        }
    }
}
