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
    public partial class frmMain : Form
    {
        CommunicationManager comm = new CommunicationManager();
        frmDebug DebugW = new frmDebug();
        public frmMain()
        {
            InitializeComponent();
            comm.InitTimer();
            DebugW.Show();
            DebugW.Hide();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadValues();
            SetDefaults();
            comm.LogFile("------------- Application started -------------", false);
            comm.LogFile("------------- Application started -------------", true);
            this.Text = Properties.Settings.Default.ProgramName + " v." + Properties.Settings.Default.ProgramVer;
            if (Properties.Settings.Default.StartExtApps == true) comm.StartPrograms();
        }

        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            if (comm.comPort.IsOpen == true)
            {
                MessageBox.Show("You need to close the serial port before exiting Serial I/O System.", "Serial Port Open");
                e.Cancel = true;
            }
            else if (timer1.Enabled == true)
            {
                MessageBox.Show("Can not exit Serial I/O System before initializing is complete.", "System Initializing");
                e.Cancel = true;
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Are you sure you want to exit Serial I/O System?", "Exit Serial I/O System", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.No)
                    e.Cancel = true;
                else if (dlg == DialogResult.Yes)
                {
                    comm.LogFile("------------- Application stopped -------------", false);
                    comm.LogFile("------------- Application stopped -------------", true);
                    e.Cancel = false;
                }
            }
        }

        private void SetDefaults()
        {
            cboPort.SelectedText = Properties.Settings.Default.PortName;

            mnuOutlet.Text = Properties.Commands.Default.oOutlet_Name;

            lblLoop1.Text = Properties.Commands.Default.iFire_Name;
            lblLoop2.Text = Properties.Commands.Default.iTamper_Name;

            lblSystem1.Text = Properties.Commands.Default.iSysVolt_Name;
            lblSystem2.Text = Properties.Commands.Default.iSysTemp_Name;
            lblSystem4.Text = Properties.Commands.Default.Battery_Name;

            lblSystem3.Text = Properties.Commands.Default.iTemp1_Name;
            lblSensor1.Text = Properties.Commands.Default.iTemp2_Name;

            lblOutText1.Text = Properties.Commands.Default.oBuzzer_Name;
            lblOutText2.Text = Properties.Commands.Default.oRedLED_Name;
            lblOutText3.Text = Properties.Commands.Default.oStrobe_Name;
            lblOutText4.Text = Properties.Commands.Default.oKeyLED_Name;
            lblOutText5.Text = Properties.Commands.Default.oErrLED_Name;
            lblOutText6.Text = Properties.Commands.Default.oOutlet_Name;

            toolStripProgressBar1.Maximum = Properties.Settings.Default.TimeoutTimer * 10;
        }

        private void SetLinks()
        {
            comm.lblValues[0] = lblAnalog1;
            comm.lblValues[1] = lblIntVolt;
            comm.lblValues[2] = lblAnalog2;
            comm.lblValues[3] = lblIntTemp;
            comm.lblValues[4] = lblExt1;
            comm.lblValues[5] = lblExt2;
            comm.lblValues[6] = lblPower;
            comm.lblValues[7] = lblAlarmTriggered;
            comm.lblValues[8] = lblSystem4;

            comm.lblOutputs[0] = lblOutput1;
            comm.lblOutputs[1] = lblOutput2;
            comm.lblOutputs[2] = lblOutput3;
            comm.lblOutputs[3] = lblOutput4;
            comm.lblOutputs[4] = lblOutput5;
            comm.lblOutputs[5] = lblOutput6;

            comm.DisplayWindow = rtbDisplay;
            comm.lblTopStatus = lblTopStatus;
            //comm.lblButtomStatus1 = toolStripStatusLabel1;
            //comm.lblButtomStatus2 = toolStripStatusLabel2;
            comm.barTimeOut = toolStripProgressBar1;
            comm.toolStrip1 = statusStrip1;
            comm.lblSentMail = lblSentMail;
            comm.lblAlarmActive = lblAlarmActive;
            comm.lblMovement = lblMovement;

            comm.DebugWindow = DebugW.DebugWindow;
        }

        // method to load our serial port option values
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
        }

        private void mnuOpenPort_Click(object sender, EventArgs e)
        {
            comm.PortName = cboPort.Text;
            comm.OpenPort();

            Properties.Settings.Default.PortName = cboPort.Text;
            Properties.Settings.Default.Save();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(txtSend2.Text == ""))comm.WriteData(txtSend2.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sios.no");
        }

        private void GroupBox1_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.ToggleAlarm();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.Outlet(true);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.Outlet(false);
        }

        private void mnuSendTestMail_Click(object sender, EventArgs e)
        {
            comm.SendEmail("Test from user interface", Properties.Settings.Default.TestMailImg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetLinks();
            lblTopStatus.Text = "Ready to Connect";
            mnuFile.Enabled = true;
            timer1.Enabled = false;
        }

        private void mnuClosePort_Click(object sender, EventArgs e)
        {
            new Thread((ThreadStart)delegate
            {
                DialogResult dlg = MessageBox.Show("Are you sure you want to close the serial port?\nThis will disable all monitoring and alarm systems.", "Close Serial Port", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    comm.DoClosePort();
                }
            }).Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            Settings.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (comm.comPort.IsOpen == true)
            {
                this.mnuOpenPort.Enabled = false;
                this.mnuClosePort.Enabled = true;
                this.cboPort.Enabled = false;
                this.mnuCommands.Enabled = true;
                this.mnuSend.Enabled = true;
            }
            else
            {
                this.mnuOpenPort.Enabled = true;
                this.mnuClosePort.Enabled = false;
                this.cboPort.Enabled = true;
                this.mnuCommands.Enabled = false;
                this.mnuSend.Enabled = false;
            }
        }

        private void showDebugWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugW.Show();
        }
    }
}