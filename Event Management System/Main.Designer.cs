

namespace Event_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.etbMenu1 = new Event_Management_System.CustomControls.etbMenu();
            this.SuspendLayout();
            // 
            // etbMenu1
            // 
            this.etbMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(100)))));
            this.etbMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.etbMenu1.Location = new System.Drawing.Point(0, 0);
            this.etbMenu1.Me = false;
            this.etbMenu1.Mt = false;
            this.etbMenu1.Mu = false;
            this.etbMenu1.Name = "etbMenu1";
            this.etbMenu1.Pt = false;
            this.etbMenu1.Qs = false;
            this.etbMenu1.Re = false;
            this.etbMenu1.Rt = false;
            this.etbMenu1.Size = new System.Drawing.Size(150, 395);
            this.etbMenu1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Event_Management_System.Properties.Resources.Untitled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(599, 395);
            this.Controls.Add(this.etbMenu1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Event Administration System";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.etbMenu etbMenu1;
    }
}

