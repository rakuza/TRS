namespace Event_Management_System
{
    partial class Prefs
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
            this.btnSave = new System.Windows.Forms.Button();
            this.staticlblUserName = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.staticlblPassword = new System.Windows.Forms.Label();
            this.tbxServer = new System.Windows.Forms.TextBox();
            this.staticlblServer = new System.Windows.Forms.Label();
            this.tbxDataSource = new System.Windows.Forms.TextBox();
            this.staticlblDatabase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Preferences";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // staticlblUserName
            // 
            this.staticlblUserName.AutoSize = true;
            this.staticlblUserName.Location = new System.Drawing.Point(12, 9);
            this.staticlblUserName.Name = "staticlblUserName";
            this.staticlblUserName.Size = new System.Drawing.Size(55, 13);
            this.staticlblUserName.TabIndex = 1;
            this.staticlblUserName.Text = "Username";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(12, 25);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(205, 20);
            this.tbxUserName.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(12, 64);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '卐';
            this.tbxPassword.Size = new System.Drawing.Size(205, 20);
            this.tbxPassword.TabIndex = 4;
            // 
            // staticlblPassword
            // 
            this.staticlblPassword.AutoSize = true;
            this.staticlblPassword.Location = new System.Drawing.Point(12, 48);
            this.staticlblPassword.Name = "staticlblPassword";
            this.staticlblPassword.Size = new System.Drawing.Size(53, 13);
            this.staticlblPassword.TabIndex = 3;
            this.staticlblPassword.Text = "Password";
            // 
            // tbxServer
            // 
            this.tbxServer.Location = new System.Drawing.Point(12, 103);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.Size = new System.Drawing.Size(205, 20);
            this.tbxServer.TabIndex = 6;
            // 
            // staticlblServer
            // 
            this.staticlblServer.AutoSize = true;
            this.staticlblServer.Location = new System.Drawing.Point(12, 87);
            this.staticlblServer.Name = "staticlblServer";
            this.staticlblServer.Size = new System.Drawing.Size(38, 13);
            this.staticlblServer.TabIndex = 5;
            this.staticlblServer.Text = "Server";
            // 
            // tbxDataSource
            // 
            this.tbxDataSource.Location = new System.Drawing.Point(12, 142);
            this.tbxDataSource.Name = "tbxDataSource";
            this.tbxDataSource.Size = new System.Drawing.Size(205, 20);
            this.tbxDataSource.TabIndex = 8;
            // 
            // staticlblDatabase
            // 
            this.staticlblDatabase.AutoSize = true;
            this.staticlblDatabase.Location = new System.Drawing.Point(12, 126);
            this.staticlblDatabase.Name = "staticlblDatabase";
            this.staticlblDatabase.Size = new System.Drawing.Size(53, 13);
            this.staticlblDatabase.TabIndex = 7;
            this.staticlblDatabase.Text = "Database";
            // 
            // Prefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 200);
            this.Controls.Add(this.tbxDataSource);
            this.Controls.Add(this.staticlblDatabase);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.staticlblServer);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.staticlblPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.staticlblUserName);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Prefs";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Prefs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label staticlblUserName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label staticlblPassword;
        private System.Windows.Forms.TextBox tbxServer;
        private System.Windows.Forms.Label staticlblServer;
        private System.Windows.Forms.TextBox tbxDataSource;
        private System.Windows.Forms.Label staticlblDatabase;
    }
}