namespace Event_Management_System
{
    partial class AdminEvents
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.eventnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRefresh = new System.Windows.Forms.Label();
            this.StaticRefresh = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AutoGenerateColumns = false;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventnameDataGridViewTextBoxColumn,
            this.eventdateDataGridViewTextBoxColumn});
            this.dgvEvents.DataSource = this.eventsBindingSource;
            this.dgvEvents.Location = new System.Drawing.Point(12, 40);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(329, 330);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEvents_UserDeletingRow);
            this.dgvEvents.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEvents_CellBeginEdit);
            this.dgvEvents.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_RowLeave);
            this.dgvEvents.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvEvents_RowsAdded);
            // 
            // eventnameDataGridViewTextBoxColumn
            // 
            this.eventnameDataGridViewTextBoxColumn.DataPropertyName = "eventname";
            this.eventnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.eventnameDataGridViewTextBoxColumn.Name = "eventnameDataGridViewTextBoxColumn";
            // 
            // eventdateDataGridViewTextBoxColumn
            // 
            this.eventdateDataGridViewTextBoxColumn.DataPropertyName = "eventdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.eventdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.eventdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.eventdateDataGridViewTextBoxColumn.Name = "eventdateDataGridViewTextBoxColumn";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataSource = typeof(Event_Management_System.events);
            this.eventsBindingSource.CurrentChanged += new System.EventHandler(this.eventsBindingSource_CurrentChanged);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Location = new System.Drawing.Point(131, 16);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(120, 13);
            this.lblRefresh.TabIndex = 9;
            this.lblRefresh.Text = "<time since last refresh>";
            // 
            // StaticRefresh
            // 
            this.StaticRefresh.AutoSize = true;
            this.StaticRefresh.Location = new System.Drawing.Point(40, 16);
            this.StaticRefresh.Name = "StaticRefresh";
            this.StaticRefresh.Size = new System.Drawing.Size(85, 13);
            this.StaticRefresh.TabIndex = 8;
            this.StaticRefresh.Text = "Last Refreshed :";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefesh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefesh.Location = new System.Drawing.Point(12, 12);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(22, 22);
            this.btnRefesh.TabIndex = 7;
            this.btnRefesh.Text = "Q";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.UpdateTable);
            // 
            // AdminEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 385);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.StaticRefresh);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.dgvEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminEvents";
            this.Text = "Edit Events";
            this.Load += new System.EventHandler(this.UpdateTable);
            this.Leave += new System.EventHandler(this.AdminEvents_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label StaticRefresh;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventsBindingSource;
    }
}