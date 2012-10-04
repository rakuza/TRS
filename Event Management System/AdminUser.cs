using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Event_Management_System.CustomControls;

namespace Event_Management_System
{
    using Event_Management_System.DataObjects;

    public partial class AdminUser : Form
    {

        BindingList<user> userList = new BindingList<user>();
        Boolean editingRow = false;
        Boolean newRow = false;

        public AdminUser()
        {
            InitializeComponent();
            dgvUsers.DataSource = userList;
            
        }

        private void UpdateTable(object sender, EventArgs e)
        {
            
            userList = SQL.UserAdmin.SelectAllUsers();
            dgvUsers.DataSource = userList;
            lblRefresh.Text = DateTime.Now.ToString();

            dgvUsers.Refresh();

        }

        private void dgvUsers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editingRow = true;
        }

        private void dgvUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {


            SQL.UserAdmin.DeleteUser((user)e.Row.DataBoundItem);
        }

        private void dgvUsers_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRow = true;
        }

        private void dgvUsers_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsers.EndEdit();

            if (editingRow)
            {
                //save row
                

                if (newRow)
                {
                    //new row
                    user newUser = (user)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                    newUser.deleted = 0;
                    SQL.UserAdmin.InsertUser(newUser);
                    newRow = false;
                }
                else
                {
                    //edit row
                    SQL.UserAdmin.UpdateUser((user)dgvUsers.Rows[e.RowIndex].DataBoundItem);
                }
                editingRow = false;
            }
            else
            {
                //changing row
            }
        }

        private void AdminUser_Leave(object sender, EventArgs e)
        {
            
            foreach (Control c in this.MdiParent.Controls)
            {
                if(c.GetType() == new etbMenu().GetType() )
                {
                    ((etbMenu)c).Mu = false;
                }
            }
        }



    }
}
