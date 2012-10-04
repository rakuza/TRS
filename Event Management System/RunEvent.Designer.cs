namespace Event_Management_System
{
    partial class RunEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcEventManage = new System.Windows.Forms.TabControl();
            this.tabAdmitUser = new System.Windows.Forms.TabPage();
            this.staticNew = new System.Windows.Forms.Label();
            this.staticExisting = new System.Windows.Forms.Label();
            this.cbxTickets = new System.Windows.Forms.ComboBox();
            this.StaticSelectTicket = new System.Windows.Forms.Label();
            this.lbxTickets = new System.Windows.Forms.ListBox();
            this.btnAttend = new System.Windows.Forms.Button();
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.staticLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.staticFirstName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.staticUsername = new System.Windows.Forms.Label();
            this.tbxSearchUsers = new System.Windows.Forms.TextBox();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.tabAdjustEvent = new System.Windows.Forms.TabPage();
            this.lblAlterTicket = new System.Windows.Forms.Label();
            this.staticTicketUsed = new System.Windows.Forms.Label();
            this.lblAlterLastname = new System.Windows.Forms.Label();
            this.staticLastName2 = new System.Windows.Forms.Label();
            this.lblAlterFirstName = new System.Windows.Forms.Label();
            this.StaticFirstName2 = new System.Windows.Forms.Label();
            this.lblAlterUsername = new System.Windows.Forms.Label();
            this.StaticUsername2 = new System.Windows.Forms.Label();
            this.btnUnattend = new System.Windows.Forms.Button();
            this.staticSelectUser = new System.Windows.Forms.Label();
            this.lbxAdmitedUsers = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxEvents = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.staticlblCaution = new System.Windows.Forms.Label();
            this.tbcEventManage.SuspendLayout();
            this.tabAdmitUser.SuspendLayout();
            this.gbxUsers.SuspendLayout();
            this.tabAdjustEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEventManage
            // 
            this.tbcEventManage.Controls.Add(this.tabAdmitUser);
            this.tbcEventManage.Controls.Add(this.tabAdjustEvent);
            this.tbcEventManage.Enabled = false;
            this.tbcEventManage.Location = new System.Drawing.Point(13, 44);
            this.tbcEventManage.Name = "tbcEventManage";
            this.tbcEventManage.SelectedIndex = 0;
            this.tbcEventManage.Size = new System.Drawing.Size(382, 341);
            this.tbcEventManage.TabIndex = 0;
            // 
            // tabAdmitUser
            // 
            this.tabAdmitUser.Controls.Add(this.staticNew);
            this.tabAdmitUser.Controls.Add(this.staticExisting);
            this.tabAdmitUser.Controls.Add(this.cbxTickets);
            this.tabAdmitUser.Controls.Add(this.StaticSelectTicket);
            this.tabAdmitUser.Controls.Add(this.lbxTickets);
            this.tabAdmitUser.Controls.Add(this.btnAttend);
            this.tabAdmitUser.Controls.Add(this.gbxUsers);
            this.tabAdmitUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabAdmitUser.Location = new System.Drawing.Point(4, 22);
            this.tabAdmitUser.Name = "tabAdmitUser";
            this.tabAdmitUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmitUser.Size = new System.Drawing.Size(374, 315);
            this.tabAdmitUser.TabIndex = 1;
            this.tabAdmitUser.Text = "Admit User";
            this.tabAdmitUser.UseVisualStyleBackColor = true;
            this.tabAdmitUser.Enter += new System.EventHandler(this.tabAdmitUser_Enter);
            // 
            // staticNew
            // 
            this.staticNew.AutoSize = true;
            this.staticNew.Location = new System.Drawing.Point(233, 25);
            this.staticNew.Name = "staticNew";
            this.staticNew.Size = new System.Drawing.Size(62, 13);
            this.staticNew.TabIndex = 9;
            this.staticNew.Text = "New Ticket";
            // 
            // staticExisting
            // 
            this.staticExisting.AutoSize = true;
            this.staticExisting.Location = new System.Drawing.Point(233, 75);
            this.staticExisting.Name = "staticExisting";
            this.staticExisting.Size = new System.Drawing.Size(76, 13);
            this.staticExisting.TabIndex = 8;
            this.staticExisting.Text = "Prepaid Ticket";
            // 
            // cbxTickets
            // 
            this.cbxTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTickets.FormattingEnabled = true;
            this.cbxTickets.Location = new System.Drawing.Point(233, 51);
            this.cbxTickets.Name = "cbxTickets";
            this.cbxTickets.Size = new System.Drawing.Size(121, 21);
            this.cbxTickets.TabIndex = 7;
            this.cbxTickets.SelectionChangeCommitted += new System.EventHandler(this.cbxTickets_SelectionChangeCommitted);
            // 
            // StaticSelectTicket
            // 
            this.StaticSelectTicket.AutoSize = true;
            this.StaticSelectTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticSelectTicket.Location = new System.Drawing.Point(233, 6);
            this.StaticSelectTicket.Name = "StaticSelectTicket";
            this.StaticSelectTicket.Size = new System.Drawing.Size(80, 13);
            this.StaticSelectTicket.TabIndex = 6;
            this.StaticSelectTicket.Text = "Select A Ticket";
            // 
            // lbxTickets
            // 
            this.lbxTickets.FormattingEnabled = true;
            this.lbxTickets.Location = new System.Drawing.Point(233, 90);
            this.lbxTickets.Name = "lbxTickets";
            this.lbxTickets.Size = new System.Drawing.Size(135, 186);
            this.lbxTickets.TabIndex = 5;
            this.lbxTickets.SelectedIndexChanged += new System.EventHandler(this.lbxTickets_SelectedIndexChanged);
            // 
            // btnAttend
            // 
            this.btnAttend.Location = new System.Drawing.Point(233, 282);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(120, 23);
            this.btnAttend.TabIndex = 4;
            this.btnAttend.Text = "Attend";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.lblLastName);
            this.gbxUsers.Controls.Add(this.staticLastName);
            this.gbxUsers.Controls.Add(this.lblFirstName);
            this.gbxUsers.Controls.Add(this.staticFirstName);
            this.gbxUsers.Controls.Add(this.lblUsername);
            this.gbxUsers.Controls.Add(this.staticUsername);
            this.gbxUsers.Controls.Add(this.tbxSearchUsers);
            this.gbxUsers.Controls.Add(this.lbxUsers);
            this.gbxUsers.Location = new System.Drawing.Point(3, 6);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(224, 299);
            this.gbxUsers.TabIndex = 2;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Select User";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(146, 159);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "<lastname>";
            this.lblLastName.Visible = false;
            // 
            // staticLastName
            // 
            this.staticLastName.AutoSize = true;
            this.staticLastName.Location = new System.Drawing.Point(146, 137);
            this.staticLastName.Name = "staticLastName";
            this.staticLastName.Size = new System.Drawing.Size(58, 13);
            this.staticLastName.TabIndex = 6;
            this.staticLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(146, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "<FirstName>";
            this.lblFirstName.Visible = false;
            // 
            // staticFirstName
            // 
            this.staticFirstName.AutoSize = true;
            this.staticFirstName.Location = new System.Drawing.Point(146, 92);
            this.staticFirstName.Name = "staticFirstName";
            this.staticFirstName.Size = new System.Drawing.Size(55, 13);
            this.staticFirstName.TabIndex = 4;
            this.staticFirstName.Text = "First name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(146, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "<username>";
            this.lblUsername.Visible = false;
            // 
            // staticUsername
            // 
            this.staticUsername.AutoSize = true;
            this.staticUsername.Location = new System.Drawing.Point(146, 45);
            this.staticUsername.Name = "staticUsername";
            this.staticUsername.Size = new System.Drawing.Size(55, 13);
            this.staticUsername.TabIndex = 2;
            this.staticUsername.Text = "Username";
            // 
            // tbxSearchUsers
            // 
            this.tbxSearchUsers.Location = new System.Drawing.Point(6, 19);
            this.tbxSearchUsers.Name = "tbxSearchUsers";
            this.tbxSearchUsers.Size = new System.Drawing.Size(120, 20);
            this.tbxSearchUsers.TabIndex = 0;
            this.tbxSearchUsers.TextChanged += new System.EventHandler(this.tbxSearchUsers_TextChanged);
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.Location = new System.Drawing.Point(6, 45);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(120, 238);
            this.lbxUsers.TabIndex = 1;
            this.lbxUsers.SelectedValueChanged += new System.EventHandler(this.lbxUsers_SelectedValueChanged);
            // 
            // tabAdjustEvent
            // 
            this.tabAdjustEvent.Controls.Add(this.staticlblCaution);
            this.tabAdjustEvent.Controls.Add(this.lblAlterTicket);
            this.tabAdjustEvent.Controls.Add(this.staticTicketUsed);
            this.tabAdjustEvent.Controls.Add(this.lblAlterLastname);
            this.tabAdjustEvent.Controls.Add(this.staticLastName2);
            this.tabAdjustEvent.Controls.Add(this.lblAlterFirstName);
            this.tabAdjustEvent.Controls.Add(this.StaticFirstName2);
            this.tabAdjustEvent.Controls.Add(this.lblAlterUsername);
            this.tabAdjustEvent.Controls.Add(this.StaticUsername2);
            this.tabAdjustEvent.Controls.Add(this.btnUnattend);
            this.tabAdjustEvent.Controls.Add(this.staticSelectUser);
            this.tabAdjustEvent.Controls.Add(this.lbxAdmitedUsers);
            this.tabAdjustEvent.Location = new System.Drawing.Point(4, 22);
            this.tabAdjustEvent.Name = "tabAdjustEvent";
            this.tabAdjustEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdjustEvent.Size = new System.Drawing.Size(374, 315);
            this.tabAdjustEvent.TabIndex = 2;
            this.tabAdjustEvent.Text = "Undo Admitance";
            this.tabAdjustEvent.UseVisualStyleBackColor = true;
            this.tabAdjustEvent.Enter += new System.EventHandler(this.tabAdjustEvent_Enter);
            // 
            // lblAlterTicket
            // 
            this.lblAlterTicket.AutoSize = true;
            this.lblAlterTicket.Location = new System.Drawing.Point(142, 146);
            this.lblAlterTicket.Name = "lblAlterTicket";
            this.lblAlterTicket.Size = new System.Drawing.Size(68, 13);
            this.lblAlterTicket.TabIndex = 11;
            this.lblAlterTicket.Text = "<ticketused>";
            this.lblAlterTicket.Visible = false;
            // 
            // staticTicketUsed
            // 
            this.staticTicketUsed.AutoSize = true;
            this.staticTicketUsed.Location = new System.Drawing.Point(142, 133);
            this.staticTicketUsed.Name = "staticTicketUsed";
            this.staticTicketUsed.Size = new System.Drawing.Size(65, 13);
            this.staticTicketUsed.TabIndex = 10;
            this.staticTicketUsed.Text = "Ticket Used";
            // 
            // lblAlterLastname
            // 
            this.lblAlterLastname.AutoSize = true;
            this.lblAlterLastname.Location = new System.Drawing.Point(142, 111);
            this.lblAlterLastname.Name = "lblAlterLastname";
            this.lblAlterLastname.Size = new System.Drawing.Size(61, 13);
            this.lblAlterLastname.TabIndex = 9;
            this.lblAlterLastname.Text = "<lastname>";
            this.lblAlterLastname.Visible = false;
            // 
            // staticLastName2
            // 
            this.staticLastName2.AutoSize = true;
            this.staticLastName2.Location = new System.Drawing.Point(142, 98);
            this.staticLastName2.Name = "staticLastName2";
            this.staticLastName2.Size = new System.Drawing.Size(58, 13);
            this.staticLastName2.TabIndex = 8;
            this.staticLastName2.Text = "Last Name";
            // 
            // lblAlterFirstName
            // 
            this.lblAlterFirstName.AutoSize = true;
            this.lblAlterFirstName.Location = new System.Drawing.Point(142, 77);
            this.lblAlterFirstName.Name = "lblAlterFirstName";
            this.lblAlterFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblAlterFirstName.TabIndex = 7;
            this.lblAlterFirstName.Text = "<firstname>";
            this.lblAlterFirstName.Visible = false;
            // 
            // StaticFirstName2
            // 
            this.StaticFirstName2.AutoSize = true;
            this.StaticFirstName2.Location = new System.Drawing.Point(142, 64);
            this.StaticFirstName2.Name = "StaticFirstName2";
            this.StaticFirstName2.Size = new System.Drawing.Size(54, 13);
            this.StaticFirstName2.TabIndex = 6;
            this.StaticFirstName2.Text = "FirstName";
            // 
            // lblAlterUsername
            // 
            this.lblAlterUsername.AutoSize = true;
            this.lblAlterUsername.Location = new System.Drawing.Point(142, 39);
            this.lblAlterUsername.Name = "lblAlterUsername";
            this.lblAlterUsername.Size = new System.Drawing.Size(65, 13);
            this.lblAlterUsername.TabIndex = 5;
            this.lblAlterUsername.Text = "<username>";
            this.lblAlterUsername.Visible = false;
            // 
            // StaticUsername2
            // 
            this.StaticUsername2.AutoSize = true;
            this.StaticUsername2.Location = new System.Drawing.Point(142, 26);
            this.StaticUsername2.Name = "StaticUsername2";
            this.StaticUsername2.Size = new System.Drawing.Size(55, 13);
            this.StaticUsername2.TabIndex = 4;
            this.StaticUsername2.Text = "Username";
            // 
            // btnUnattend
            // 
            this.btnUnattend.Location = new System.Drawing.Point(145, 242);
            this.btnUnattend.Name = "btnUnattend";
            this.btnUnattend.Size = new System.Drawing.Size(75, 23);
            this.btnUnattend.TabIndex = 3;
            this.btnUnattend.Text = "Unattend";
            this.btnUnattend.UseVisualStyleBackColor = true;
            this.btnUnattend.Click += new System.EventHandler(this.btnUnattend_Click);
            // 
            // staticSelectUser
            // 
            this.staticSelectUser.AutoSize = true;
            this.staticSelectUser.Location = new System.Drawing.Point(7, 7);
            this.staticSelectUser.Name = "staticSelectUser";
            this.staticSelectUser.Size = new System.Drawing.Size(62, 13);
            this.staticSelectUser.TabIndex = 2;
            this.staticSelectUser.Text = "Select User";
            // 
            // lbxAdmitedUsers
            // 
            this.lbxAdmitedUsers.FormattingEnabled = true;
            this.lbxAdmitedUsers.Location = new System.Drawing.Point(7, 26);
            this.lbxAdmitedUsers.Name = "lbxAdmitedUsers";
            this.lbxAdmitedUsers.Size = new System.Drawing.Size(119, 277);
            this.lbxAdmitedUsers.TabIndex = 0;
            this.lbxAdmitedUsers.SelectedIndexChanged += new System.EventHandler(this.lbxAdmitedUsers_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Q";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.UpdateEventSelection);
            // 
            // cbxEvents
            // 
            this.cbxEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvents.FormattingEnabled = true;
            this.cbxEvents.Location = new System.Drawing.Point(41, 13);
            this.cbxEvents.Name = "cbxEvents";
            this.cbxEvents.Size = new System.Drawing.Size(121, 21);
            this.cbxEvents.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(169, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Event";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // staticlblCaution
            // 
            this.staticlblCaution.AutoSize = true;
            this.staticlblCaution.ForeColor = System.Drawing.Color.DarkRed;
            this.staticlblCaution.Location = new System.Drawing.Point(142, 177);
            this.staticlblCaution.Name = "staticlblCaution";
            this.staticlblCaution.Size = new System.Drawing.Size(175, 52);
            this.staticlblCaution.TabIndex = 12;
            this.staticlblCaution.Text = "Caution unadmiting a user \r\ndoes not remove their ticket \r\nif you wish to remove " +
                "ticket please\r\nuse the purchase manager window.\r\n";
            // 
            // RunEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 392);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxEvents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbcEventManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RunEvent";
            this.Text = "RunEvent";
            this.Load += new System.EventHandler(this.UpdateEventSelection);
            this.Leave += new System.EventHandler(this.RunEvent_Leave);
            this.tbcEventManage.ResumeLayout(false);
            this.tabAdmitUser.ResumeLayout(false);
            this.tabAdmitUser.PerformLayout();
            this.gbxUsers.ResumeLayout(false);
            this.gbxUsers.PerformLayout();
            this.tabAdjustEvent.ResumeLayout(false);
            this.tabAdjustEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEventManage;
        private System.Windows.Forms.TabPage tabAdmitUser;
        private System.Windows.Forms.TabPage tabAdjustEvent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbxEvents;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.Label staticUsername;
        private System.Windows.Forms.TextBox tbxSearchUsers;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label staticFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label staticLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ListBox lbxTickets;
        private System.Windows.Forms.Label StaticSelectTicket;
        private System.Windows.Forms.ListBox lbxAdmitedUsers;
        private System.Windows.Forms.Label staticSelectUser;
        private System.Windows.Forms.Label staticExisting;
        private System.Windows.Forms.ComboBox cbxTickets;
        private System.Windows.Forms.Label staticNew;
        private System.Windows.Forms.Label lblAlterLastname;
        private System.Windows.Forms.Label staticLastName2;
        private System.Windows.Forms.Label lblAlterFirstName;
        private System.Windows.Forms.Label StaticFirstName2;
        private System.Windows.Forms.Label lblAlterUsername;
        private System.Windows.Forms.Label StaticUsername2;
        private System.Windows.Forms.Button btnUnattend;
        private System.Windows.Forms.Label lblAlterTicket;
        private System.Windows.Forms.Label staticTicketUsed;
        private System.Windows.Forms.Label staticlblCaution;
    }
}