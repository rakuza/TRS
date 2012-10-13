namespace Event_Management_System
{
    partial class PurchaseTicket
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
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxOwnedTickets = new System.Windows.Forms.ListBox();
            this.lbxTickets = new System.Windows.Forms.ListBox();
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblexpires = new System.Windows.Forms.Label();
            this.staticlblExpires = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
=======
            this.btnRemoveTicket = new System.Windows.Forms.Button();
>>>>>>> origin/master
            this.staticType2 = new System.Windows.Forms.Label();
            this.staticUnusedTickets = new System.Windows.Forms.Label();
            this.staticPrice2 = new System.Windows.Forms.Label();
            this.staticUsers = new System.Windows.Forms.Label();
            this.lblOwnedTicketPrice = new System.Windows.Forms.Label();
            this.staticLastName = new System.Windows.Forms.Label();
            this.lblOwnedTicketType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOwnedTicketTicketName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.staticTicketName2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.staticUsername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.staticType = new System.Windows.Forms.Label();
            this.staticPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTicketName = new System.Windows.Forms.Label();
            this.staticTicketName = new System.Windows.Forms.Label();
            this.gbxUserInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.Location = new System.Drawing.Point(7, 66);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(120, 238);
            this.lbxUsers.TabIndex = 0;
<<<<<<< HEAD
=======
            this.lbxUsers.SelectedIndexChanged += new System.EventHandler(this.lbxUsers_SelectedValueChanged);
>>>>>>> origin/master
            this.lbxUsers.SelectedValueChanged += new System.EventHandler(this.lbxUsers_SelectedValueChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(120, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lbxOwnedTickets
            // 
            this.lbxOwnedTickets.FormattingEnabled = true;
            this.lbxOwnedTickets.Location = new System.Drawing.Point(131, 66);
            this.lbxOwnedTickets.Name = "lbxOwnedTickets";
            this.lbxOwnedTickets.Size = new System.Drawing.Size(120, 238);
            this.lbxOwnedTickets.TabIndex = 2;
            this.lbxOwnedTickets.SelectedValueChanged += new System.EventHandler(this.lbxOwnedTickets_SelectedValueChanged);
            // 
            // lbxTickets
            // 
            this.lbxTickets.FormattingEnabled = true;
            this.lbxTickets.Location = new System.Drawing.Point(6, 66);
            this.lbxTickets.Name = "lbxTickets";
            this.lbxTickets.Size = new System.Drawing.Size(120, 238);
            this.lbxTickets.TabIndex = 3;
            this.lbxTickets.SelectedValueChanged += new System.EventHandler(this.lbxTickets_SelectedValueChanged);
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.lblexpires);
            this.gbxUserInfo.Controls.Add(this.staticlblExpires);
            this.gbxUserInfo.Controls.Add(this.btnRemoveTicket);
            this.gbxUserInfo.Controls.Add(this.staticType2);
            this.gbxUserInfo.Controls.Add(this.staticUnusedTickets);
            this.gbxUserInfo.Controls.Add(this.staticPrice2);
            this.gbxUserInfo.Controls.Add(this.staticUsers);
            this.gbxUserInfo.Controls.Add(this.lblOwnedTicketPrice);
            this.gbxUserInfo.Controls.Add(this.staticLastName);
            this.gbxUserInfo.Controls.Add(this.lblOwnedTicketType);
            this.gbxUserInfo.Controls.Add(this.label5);
            this.gbxUserInfo.Controls.Add(this.lblOwnedTicketTicketName);
            this.gbxUserInfo.Controls.Add(this.lblFirstName);
            this.gbxUserInfo.Controls.Add(this.staticTicketName2);
            this.gbxUserInfo.Controls.Add(this.lblLastName);
            this.gbxUserInfo.Controls.Add(this.lblUsername);
            this.gbxUserInfo.Controls.Add(this.staticUsername);
            this.gbxUserInfo.Controls.Add(this.lbxUsers);
            this.gbxUserInfo.Controls.Add(this.lbxOwnedTickets);
            this.gbxUserInfo.Controls.Add(this.tbxSearch);
            this.gbxUserInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(257, 482);
            this.gbxUserInfo.TabIndex = 4;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "User Infomation";
            // 
            // lblexpires
            // 
            this.lblexpires.AutoSize = true;
            this.lblexpires.Location = new System.Drawing.Point(144, 455);
            this.lblexpires.Name = "lblexpires";
            this.lblexpires.Size = new System.Drawing.Size(52, 13);
            this.lblexpires.TabIndex = 27;
            this.lblexpires.Text = "<expires>";
            // 
            // staticlblExpires
            // 
            this.staticlblExpires.AutoSize = true;
            this.staticlblExpires.Location = new System.Drawing.Point(144, 442);
            this.staticlblExpires.Name = "staticlblExpires";
            this.staticlblExpires.Size = new System.Drawing.Size(41, 13);
            this.staticlblExpires.TabIndex = 26;
            this.staticlblExpires.Text = "Expires";
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Remove);
=======
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Location = new System.Drawing.Point(147, 309);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTicket.TabIndex = 25;
            this.btnRemoveTicket.Text = "Remove";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
>>>>>>> origin/master
            // 
            // staticType2
            // 
            this.staticType2.AutoSize = true;
            this.staticType2.Location = new System.Drawing.Point(144, 407);
            this.staticType2.Name = "staticType2";
            this.staticType2.Size = new System.Drawing.Size(31, 13);
            this.staticType2.TabIndex = 24;
            this.staticType2.Text = "Type";
            // 
            // staticUnusedTickets
            // 
            this.staticUnusedTickets.AutoSize = true;
            this.staticUnusedTickets.Location = new System.Drawing.Point(128, 42);
            this.staticUnusedTickets.Name = "staticUnusedTickets";
            this.staticUnusedTickets.Size = new System.Drawing.Size(82, 13);
            this.staticUnusedTickets.TabIndex = 13;
            this.staticUnusedTickets.Text = "Unused Tickets";
            // 
            // staticPrice2
            // 
            this.staticPrice2.AutoSize = true;
            this.staticPrice2.Location = new System.Drawing.Point(144, 371);
            this.staticPrice2.Name = "staticPrice2";
            this.staticPrice2.Size = new System.Drawing.Size(28, 13);
            this.staticPrice2.TabIndex = 23;
            this.staticPrice2.Text = "Paid";
            // 
            // staticUsers
            // 
            this.staticUsers.AutoSize = true;
            this.staticUsers.Location = new System.Drawing.Point(6, 42);
            this.staticUsers.Name = "staticUsers";
            this.staticUsers.Size = new System.Drawing.Size(34, 13);
            this.staticUsers.TabIndex = 12;
            this.staticUsers.Text = "Users";
            // 
            // lblOwnedTicketPrice
            // 
            this.lblOwnedTicketPrice.AutoSize = true;
            this.lblOwnedTicketPrice.Location = new System.Drawing.Point(144, 384);
            this.lblOwnedTicketPrice.Name = "lblOwnedTicketPrice";
            this.lblOwnedTicketPrice.Size = new System.Drawing.Size(39, 13);
            this.lblOwnedTicketPrice.TabIndex = 22;
            this.lblOwnedTicketPrice.Text = "<paid>";
            this.lblOwnedTicketPrice.Visible = false;
            // 
            // staticLastName
            // 
            this.staticLastName.AutoSize = true;
            this.staticLastName.Location = new System.Drawing.Point(6, 407);
            this.staticLastName.Name = "staticLastName";
            this.staticLastName.Size = new System.Drawing.Size(58, 13);
            this.staticLastName.TabIndex = 11;
            this.staticLastName.Text = "Last Name";
            // 
            // lblOwnedTicketType
            // 
            this.lblOwnedTicketType.AutoSize = true;
            this.lblOwnedTicketType.Location = new System.Drawing.Point(144, 420);
            this.lblOwnedTicketType.Name = "lblOwnedTicketType";
            this.lblOwnedTicketType.Size = new System.Drawing.Size(39, 13);
            this.lblOwnedTicketType.TabIndex = 21;
            this.lblOwnedTicketType.Text = "<type>";
            this.lblOwnedTicketType.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name";
            // 
            // lblOwnedTicketTicketName
            // 
            this.lblOwnedTicketTicketName.AutoSize = true;
            this.lblOwnedTicketTicketName.Location = new System.Drawing.Point(144, 348);
            this.lblOwnedTicketTicketName.Name = "lblOwnedTicketTicketName";
            this.lblOwnedTicketTicketName.Size = new System.Drawing.Size(71, 13);
            this.lblOwnedTicketTicketName.TabIndex = 20;
            this.lblOwnedTicketTicketName.Text = "<ticketname>";
            this.lblOwnedTicketTicketName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 384);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "<firstname>";
            this.lblFirstName.Visible = false;
            // 
            // staticTicketName2
            // 
            this.staticTicketName2.AutoSize = true;
            this.staticTicketName2.Location = new System.Drawing.Point(144, 335);
            this.staticTicketName2.Name = "staticTicketName2";
            this.staticTicketName2.Size = new System.Drawing.Size(66, 13);
            this.staticTicketName2.TabIndex = 19;
            this.staticTicketName2.Text = "Ticket name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 420);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "<lastname>";
            this.lblLastName.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 348);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "<username>";
            this.lblUsername.Visible = false;
            // 
            // staticUsername
            // 
            this.staticUsername.AutoSize = true;
            this.staticUsername.Location = new System.Drawing.Point(6, 335);
            this.staticUsername.Name = "staticUsername";
            this.staticUsername.Size = new System.Drawing.Size(55, 13);
            this.staticUsername.TabIndex = 6;
            this.staticUsername.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPurchase);
            this.groupBox2.Controls.Add(this.staticType);
            this.groupBox2.Controls.Add(this.staticPrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblTicketName);
            this.groupBox2.Controls.Add(this.staticTicketName);
            this.groupBox2.Controls.Add(this.lbxTickets);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 419);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Tickets";
            this.groupBox2.Leave += new System.EventHandler(this.groupBox2_Leave);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(135, 281);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 18;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // staticType
            // 
            this.staticType.AutoSize = true;
            this.staticType.Location = new System.Drawing.Point(132, 138);
            this.staticType.Name = "staticType";
            this.staticType.Size = new System.Drawing.Size(31, 13);
            this.staticType.TabIndex = 17;
            this.staticType.Text = "Type";
            // 
            // staticPrice
            // 
            this.staticPrice.AutoSize = true;
            this.staticPrice.Location = new System.Drawing.Point(132, 102);
            this.staticPrice.Name = "staticPrice";
            this.staticPrice.Size = new System.Drawing.Size(31, 13);
            this.staticPrice.TabIndex = 16;
            this.staticPrice.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(132, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "<price>";
            this.lblPrice.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(132, 151);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 13);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "<type>";
            this.lblType.Visible = false;
            // 
            // lblTicketName
            // 
            this.lblTicketName.AutoSize = true;
            this.lblTicketName.Location = new System.Drawing.Point(132, 79);
            this.lblTicketName.Name = "lblTicketName";
            this.lblTicketName.Size = new System.Drawing.Size(71, 13);
            this.lblTicketName.TabIndex = 13;
            this.lblTicketName.Text = "<ticketname>";
            this.lblTicketName.Visible = false;
            // 
            // staticTicketName
            // 
            this.staticTicketName.AutoSize = true;
            this.staticTicketName.Location = new System.Drawing.Point(132, 66);
            this.staticTicketName.Name = "staticTicketName";
            this.staticTicketName.Size = new System.Drawing.Size(66, 13);
            this.staticTicketName.TabIndex = 12;
            this.staticTicketName.Text = "Ticket name";
            // 
            // PurchaseTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PurchaseTicket";
            this.Text = "Purchase Tickets";
            this.Load += new System.EventHandler(this.PurchaseTicket_Load);
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxOwnedTickets;
        private System.Windows.Forms.ListBox lbxTickets;
        private System.Windows.Forms.GroupBox gbxUserInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label staticLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label staticUsername;
        private System.Windows.Forms.Label staticUnusedTickets;
        private System.Windows.Forms.Label staticUsers;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label staticType;
        private System.Windows.Forms.Label staticPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTicketName;
        private System.Windows.Forms.Label staticTicketName;
        private System.Windows.Forms.Label staticType2;
        private System.Windows.Forms.Label staticPrice2;
        private System.Windows.Forms.Label lblOwnedTicketPrice;
        private System.Windows.Forms.Label lblOwnedTicketType;
        private System.Windows.Forms.Label lblOwnedTicketTicketName;
        private System.Windows.Forms.Label staticTicketName2;
        private System.Windows.Forms.Label lblexpires;
        private System.Windows.Forms.Label staticlblExpires;
        private System.Windows.Forms.Button btnRemoveTicket;
    }
}