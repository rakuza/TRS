namespace Event_Management_System
{
    partial class AdminTickets
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.StaticRefresh = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AutoGenerateColumns = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn});
            this.dgvTickets.DataSource = this.ticketBindingSource;
            this.dgvTickets.Location = new System.Drawing.Point(13, 42);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(387, 334);
            this.dgvTickets.TabIndex = 0;
            this.dgvTickets.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTickets_UserDeletingRow);
            this.dgvTickets.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTickets_CellBeginEdit);
            this.dgvTickets.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTickets_UserAddedRow);
            this.dgvTickets.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_RowLeave);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Location = new System.Drawing.Point(133, 16);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(120, 13);
            this.lblRefresh.TabIndex = 9;
            this.lblRefresh.Text = "<time since last refresh>";
            // 
            // StaticRefresh
            // 
            this.StaticRefresh.AutoSize = true;
            this.StaticRefresh.Location = new System.Drawing.Point(42, 16);
            this.StaticRefresh.Name = "StaticRefresh";
            this.StaticRefresh.Size = new System.Drawing.Size(85, 13);
            this.StaticRefresh.TabIndex = 8;
            this.StaticRefresh.Text = "Last Refreshed :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Q";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.UpdateTable);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(Event_Management_System.ticket);
            // 
            // ticketnameDataGridViewTextBoxColumn
            // 
            this.ticketnameDataGridViewTextBoxColumn.DataPropertyName = "ticketname";
            this.ticketnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ticketnameDataGridViewTextBoxColumn.Name = "ticketnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceDataGridViewTextBoxColumn.FillWeight = 40F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Type";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // AdminTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 388);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.StaticRefresh);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminTickets";
            this.Text = "Edit Tickets";
            this.Load += new System.EventHandler(this.UpdateTable);
            this.Leave += new System.EventHandler(this.AdminTickets_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label StaticRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
    }
}