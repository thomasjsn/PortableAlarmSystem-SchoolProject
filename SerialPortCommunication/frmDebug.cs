using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PCComm;
using System.Threading;

namespace PCComm
{
    public partial class frmDebug : Form
    {
        CommunicationManager comm = new CommunicationManager();
        public frmDebug()
        {
            InitializeComponent();
        }

        public TextBox DebugWindow
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }

        private void frmDebug_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
