namespace Event_Management_System
{
    partial class ReportTool
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
            this.staticHeader = new System.Windows.Forms.Label();
            this.lbxAllEvents = new System.Windows.Forms.ListBox();
            this.lbxSelectedEvents = new System.Windows.Forms.ListBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.chkRunningTotals = new System.Windows.Forms.CheckBox();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.chkGrandTotals = new System.Windows.Forms.CheckBox();
            this.gbxEvents = new System.Windows.Forms.GroupBox();
            this.staticEventsToReport = new System.Windows.Forms.Label();
            this.btnPutItBack = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.SaveReport = new System.Windows.Forms.SaveFileDialog();
            this.gbxSettings.SuspendLayout();
            this.gbxEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // staticHeader
            // 
            this.staticHeader.AutoSize = true;
            this.staticHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticHeader.Location = new System.Drawing.Point(48, 9);
            this.staticHeader.Name = "staticHeader";
            this.staticHeader.Size = new System.Drawing.Size(282, 25);
            this.staticHeader.TabIndex = 0;
            this.staticHeader.Text = "Event Break Down Report";
            // 
            // lbxAllEvents
            // 
            this.lbxAllEvents.FormattingEnabled = true;
            this.lbxAllEvents.Location = new System.Drawing.Point(6, 37);
            this.lbxAllEvents.Name = "lbxAllEvents";
            this.lbxAllEvents.Size = new System.Drawing.Size(120, 212);
            this.lbxAllEvents.TabIndex = 1;
            // 
            // lbxSelectedEvents
            // 
            this.lbxSelectedEvents.FormattingEnabled = true;
            this.lbxSelectedEvents.Location = new System.Drawing.Point(165, 37);
            this.lbxSelectedEvents.Name = "lbxSelectedEvents";
            this.lbxSelectedEvents.Size = new System.Drawing.Size(120, 212);
            this.lbxSelectedEvents.TabIndex = 2;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.chkRunningTotals);
            this.gbxSettings.Controls.Add(this.chkOpen);
            this.gbxSettings.Controls.Add(this.chkGrandTotals);
            this.gbxSettings.Location = new System.Drawing.Point(12, 49);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(126, 88);
            this.gbxSettings.TabIndex = 3;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // chkRunningTotals
            // 
            this.chkRunningTotals.AutoSize = true;
            this.chkRunningTotals.Location = new System.Drawing.Point(6, 60);
            this.chkRunningTotals.Name = "chkRunningTotals";
            this.chkRunningTotals.Size = new System.Drawing.Size(98, 17);
            this.chkRunningTotals.TabIndex = 3;
            this.chkRunningTotals.Text = "Running Totals";
            this.chkRunningTotals.UseVisualStyleBackColor = true;
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Location = new System.Drawing.Point(6, 37);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(107, 17);
            this.chkOpen.TabIndex = 2;
            this.chkOpen.Text = "Open On Render";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // chkGrandTotals
            // 
            this.chkGrandTotals.AutoSize = true;
            this.chkGrandTotals.Location = new System.Drawing.Point(6, 13);
            this.chkGrandTotals.Name = "chkGrandTotals";
            this.chkGrandTotals.Size = new System.Drawing.Size(82, 17);
            this.chkGrandTotals.TabIndex = 1;
            this.chkGrandTotals.Text = "Grand Total";
            this.chkGrandTotals.UseVisualStyleBackColor = true;
            // 
            // gbxEvents
            // 
            this.gbxEvents.Controls.Add(this.staticEventsToReport);
            this.gbxEvents.Controls.Add(this.btnPutItBack);
            this.gbxEvents.Controls.Add(this.btnMove);
            this.gbxEvents.Controls.Add(this.lbxAllEvents);
            this.gbxEvents.Controls.Add(this.lbxSelectedEvents);
            this.gbxEvents.Location = new System.Drawing.Point(144, 49);
            this.gbxEvents.Name = "gbxEvents";
            this.gbxEvents.Size = new System.Drawing.Size(291, 258);
            this.gbxEvents.TabIndex = 4;
            this.gbxEvents.TabStop = false;
            this.gbxEvents.Text = "Events to Report";
            // 
            // staticEventsToReport
            // 
            this.staticEventsToReport.AutoSize = true;
            this.staticEventsToReport.Location = new System.Drawing.Point(174, 17);
            this.staticEventsToReport.Name = "staticEventsToReport";
            this.staticEventsToReport.Size = new System.Drawing.Size(87, 13);
            this.staticEventsToReport.TabIndex = 5;
            this.staticEventsToReport.Text = "Events to Report";
            // 
            // btnPutItBack
            // 
            this.btnPutItBack.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPutItBack.Location = new System.Drawing.Point(132, 146);
            this.btnPutItBack.Name = "btnPutItBack";
            this.btnPutItBack.Size = new System.Drawing.Size(27, 23);
            this.btnPutItBack.TabIndex = 4;
            this.btnPutItBack.Text = "á";
            this.btnPutItBack.UseVisualStyleBackColor = true;
            this.btnPutItBack.Click += new System.EventHandler(this.btnPutItBack_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMove.Location = new System.Drawing.Point(132, 117);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(27, 23);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "â";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(12, 143);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(126, 23);
            this.btnRender.TabIndex = 5;
            this.btnRender.Text = "Render!";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // SaveReport
            // 
            this.SaveReport.Filter = "Report Files |*.html";
            // 
            // ReportTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.gbxEvents);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.staticHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportTool";
            this.Text = "Event Reports";
            this.Load += new System.EventHandler(this.ReportTool_Load);
            this.Leave += new System.EventHandler(this.ReportTool_Leave);
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxEvents.ResumeLayout(false);
            this.gbxEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticHeader;
        private System.Windows.Forms.ListBox lbxAllEvents;
        private System.Windows.Forms.ListBox lbxSelectedEvents;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.CheckBox chkOpen;
        private System.Windows.Forms.GroupBox gbxEvents;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.SaveFileDialog SaveReport;
        private System.Windows.Forms.Button btnPutItBack;
        private System.Windows.Forms.CheckBox chkGrandTotals;
        private System.Windows.Forms.CheckBox chkRunningTotals;
        private System.Windows.Forms.Label staticEventsToReport;
    }
}