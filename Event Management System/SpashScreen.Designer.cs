namespace Event_Management_System
{
    partial class SpashScreen
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
            this.staticInitiziling = new System.Windows.Forms.Label();
            this.lblBuildNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staticInitiziling
            // 
            this.staticInitiziling.AutoSize = true;
            this.staticInitiziling.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticInitiziling.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staticInitiziling.Location = new System.Drawing.Point(315, 302);
            this.staticInitiziling.Name = "staticInitiziling";
            this.staticInitiziling.Size = new System.Drawing.Size(125, 25);
            this.staticInitiziling.TabIndex = 0;
            this.staticInitiziling.Text = "Initializing...";
            // 
            // lblBuildNo
            // 
            this.lblBuildNo.AutoSize = true;
            this.lblBuildNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBuildNo.Location = new System.Drawing.Point(350, 327);
            this.lblBuildNo.Name = "lblBuildNo";
            this.lblBuildNo.Size = new System.Drawing.Size(51, 20);
            this.lblBuildNo.TabIndex = 1;
            this.lblBuildNo.Text = "<null>";
            // 
            // SpashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Event_Management_System.Properties.Resources.Untitled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(546, 363);
            this.Controls.Add(this.lblBuildNo);
            this.Controls.Add(this.staticInitiziling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpashScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SpashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticInitiziling;
        private System.Windows.Forms.Label lblBuildNo;
    }
}