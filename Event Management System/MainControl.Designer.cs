namespace Event_Management_System.CustomControls
{
    partial class etbMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnEditEvents = new System.Windows.Forms.Button();
            this.btnEditTickets = new System.Windows.Forms.Button();
            this.btnRunEvent = new System.Windows.Forms.Button();
            this.btnQuickStats = new System.Windows.Forms.Button();
            this.btnEventReport = new System.Windows.Forms.Button();
            this.staticEventAdmin = new System.Windows.Forms.Label();
            this.staticReports = new System.Windows.Forms.Label();
            this.btnPurchaseTicket = new System.Windows.Forms.Button();
            this.staticlblPrefs = new System.Windows.Forms.Label();
            this.btnPrefs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Location = new System.Drawing.Point(3, 32);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(144, 23);
            this.btnEditUsers.TabIndex = 0;
            this.btnEditUsers.Text = "Manage Users";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnEditEvents
            // 
            this.btnEditEvents.Location = new System.Drawing.Point(3, 62);
            this.btnEditEvents.Name = "btnEditEvents";
            this.btnEditEvents.Size = new System.Drawing.Size(144, 23);
            this.btnEditEvents.TabIndex = 1;
            this.btnEditEvents.Text = "Manage Events";
            this.btnEditEvents.UseVisualStyleBackColor = true;
            this.btnEditEvents.Click += new System.EventHandler(this.btnEditEvents_Click);
            // 
            // btnEditTickets
            // 
            this.btnEditTickets.Location = new System.Drawing.Point(3, 92);
            this.btnEditTickets.Name = "btnEditTickets";
            this.btnEditTickets.Size = new System.Drawing.Size(144, 23);
            this.btnEditTickets.TabIndex = 2;
            this.btnEditTickets.Text = "Manage Tickets";
            this.btnEditTickets.UseVisualStyleBackColor = true;
            this.btnEditTickets.Click += new System.EventHandler(this.btnEditTickets_Click);
            // 
            // btnRunEvent
            // 
            this.btnRunEvent.Location = new System.Drawing.Point(3, 150);
            this.btnRunEvent.Name = "btnRunEvent";
            this.btnRunEvent.Size = new System.Drawing.Size(144, 23);
            this.btnRunEvent.TabIndex = 3;
            this.btnRunEvent.Text = "Run Event";
            this.btnRunEvent.UseVisualStyleBackColor = true;
            this.btnRunEvent.Click += new System.EventHandler(this.btnRunEvent_Click);
            // 
            // btnQuickStats
            // 
            this.btnQuickStats.Location = new System.Drawing.Point(3, 218);
            this.btnQuickStats.Name = "btnQuickStats";
            this.btnQuickStats.Size = new System.Drawing.Size(144, 23);
            this.btnQuickStats.TabIndex = 4;
            this.btnQuickStats.Text = "QuickStats";
            this.btnQuickStats.UseVisualStyleBackColor = true;
            this.btnQuickStats.Click += new System.EventHandler(this.btnQuickStats_Click);
            // 
            // btnEventReport
            // 
            this.btnEventReport.Location = new System.Drawing.Point(3, 247);
            this.btnEventReport.Name = "btnEventReport";
            this.btnEventReport.Size = new System.Drawing.Size(144, 23);
            this.btnEventReport.TabIndex = 5;
            this.btnEventReport.Text = "Event Report";
            this.btnEventReport.UseVisualStyleBackColor = true;
            this.btnEventReport.Click += new System.EventHandler(this.btnEventReport_Click);
            // 
            // staticEventAdmin
            // 
            this.staticEventAdmin.AutoSize = true;
            this.staticEventAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticEventAdmin.Location = new System.Drawing.Point(4, 12);
            this.staticEventAdmin.Name = "staticEventAdmin";
            this.staticEventAdmin.Size = new System.Drawing.Size(140, 17);
            this.staticEventAdmin.TabIndex = 6;
            this.staticEventAdmin.Text = "Event Administration";
            // 
            // staticReports
            // 
            this.staticReports.AutoSize = true;
            this.staticReports.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticReports.Location = new System.Drawing.Point(4, 198);
            this.staticReports.Name = "staticReports";
            this.staticReports.Size = new System.Drawing.Size(60, 17);
            this.staticReports.TabIndex = 7;
            this.staticReports.Text = "Reports";
            // 
            // btnPurchaseTicket
            // 
            this.btnPurchaseTicket.Location = new System.Drawing.Point(3, 121);
            this.btnPurchaseTicket.Name = "btnPurchaseTicket";
            this.btnPurchaseTicket.Size = new System.Drawing.Size(144, 23);
            this.btnPurchaseTicket.TabIndex = 8;
            this.btnPurchaseTicket.Text = "Purchase Manager";
            this.btnPurchaseTicket.UseVisualStyleBackColor = true;
            this.btnPurchaseTicket.Click += new System.EventHandler(this.btnPurchaseTicket_Click);
            // 
            // staticlblPrefs
            // 
            this.staticlblPrefs.AutoSize = true;
            this.staticlblPrefs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticlblPrefs.Location = new System.Drawing.Point(3, 273);
            this.staticlblPrefs.Name = "staticlblPrefs";
            this.staticlblPrefs.Size = new System.Drawing.Size(88, 17);
            this.staticlblPrefs.TabIndex = 10;
            this.staticlblPrefs.Text = "Preferences";
            // 
            // btnPrefs
            // 
            this.btnPrefs.Location = new System.Drawing.Point(2, 293);
            this.btnPrefs.Name = "btnPrefs";
            this.btnPrefs.Size = new System.Drawing.Size(144, 23);
            this.btnPrefs.TabIndex = 9;
            this.btnPrefs.Text = "Preferences";
            this.btnPrefs.UseVisualStyleBackColor = true;
            this.btnPrefs.Click += new System.EventHandler(this.btnPrefs_Click);
            // 
            // etbMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.staticlblPrefs);
            this.Controls.Add(this.btnPrefs);
            this.Controls.Add(this.btnPurchaseTicket);
            this.Controls.Add(this.staticReports);
            this.Controls.Add(this.staticEventAdmin);
            this.Controls.Add(this.btnEventReport);
            this.Controls.Add(this.btnQuickStats);
            this.Controls.Add(this.btnRunEvent);
            this.Controls.Add(this.btnEditTickets);
            this.Controls.Add(this.btnEditEvents);
            this.Controls.Add(this.btnEditUsers);
            this.Name = "etbMenu";
            this.Size = new System.Drawing.Size(150, 481);
            this.Load += new System.EventHandler(this.etbMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnEditEvents;
        private System.Windows.Forms.Button btnEditTickets;
        private System.Windows.Forms.Button btnRunEvent;
        private System.Windows.Forms.Button btnQuickStats;
        private System.Windows.Forms.Button btnEventReport;
        private System.Windows.Forms.Label staticEventAdmin;
        private System.Windows.Forms.Label staticReports;
        private System.Windows.Forms.Button btnPurchaseTicket;
        private System.Windows.Forms.Label staticlblPrefs;
        private System.Windows.Forms.Button btnPrefs;
    }
}
