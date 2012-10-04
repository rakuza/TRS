using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
        }

        private Exception exception;

        public Exception Exception
        {
            set { exception = value; }
        }

        private void BugForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = exception.ToString();
        }
    }
}
