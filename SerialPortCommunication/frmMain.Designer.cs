namespace PCComm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.grpSensors = new System.Windows.Forms.GroupBox();
            this.lblLoop1 = new System.Windows.Forms.Label();
            this.lblLoop2 = new System.Windows.Forms.Label();
            this.lblExt2 = new System.Windows.Forms.Label();
            this.lblAnalog2 = new System.Windows.Forms.Label();
            this.lblAnalog1 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblExt1 = new System.Windows.Forms.Label();
            this.lblSystem3 = new System.Windows.Forms.Label();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.lblOutput6 = new System.Windows.Forms.Label();
            this.lblOutput5 = new System.Windows.Forms.Label();
            this.lblOutput4 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutText6 = new System.Windows.Forms.Label();
            this.lblOutText5 = new System.Windows.Forms.Label();
            this.lblOutText4 = new System.Windows.Forms.Label();
            this.lblOutText3 = new System.Windows.Forms.Label();
            this.lblOutText2 = new System.Windows.Forms.Label();
            this.lblOutText1 = new System.Windows.Forms.Label();
            this.grpAlarm = new System.Windows.Forms.GroupBox();
            this.lblMovement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlarmActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSentMail = new System.Windows.Forms.Label();
            this.lblAlarmTriggered = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenPort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClosePort = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDebugWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSendTestMail = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSend2 = new System.Windows.Forms.ToolStripTextBox();
            this.mnuSend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOutlet = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTopStatus = new System.Windows.Forms.Label();
            this.grpSystem = new System.Windows.Forms.GroupBox();
            this.lblSystem4 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblSystem2 = new System.Windows.Forms.Label();
            this.lblIntVolt = new System.Windows.Forms.Label();
            this.lblSystem1 = new System.Windows.Forms.Label();
            this.lblIntTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLog.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.grpSensors.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.grpAlarm.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.rtbDisplay);
            this.grpLog.Location = new System.Drawing.Point(143, 75);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(353, 267);
            this.grpLog.TabIndex = 4;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            this.grpLog.Click += new System.EventHandler(this.GroupBox1_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(6, 19);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(341, 241);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // grpPort
            // 
            this.grpPort.Controls.Add(this.cboPort);
            this.grpPort.Location = new System.Drawing.Point(505, 75);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(125, 50);
            this.grpPort.TabIndex = 6;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "Port";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(9, 21);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(110, 21);
            this.cboPort.TabIndex = 10;
            // 
            // grpSensors
            // 
            this.grpSensors.Controls.Add(this.lblLoop1);
            this.grpSensors.Controls.Add(this.lblLoop2);
            this.grpSensors.Controls.Add(this.lblExt2);
            this.grpSensors.Controls.Add(this.lblAnalog2);
            this.grpSensors.Controls.Add(this.lblAnalog1);
            this.grpSensors.Controls.Add(this.lblSensor1);
            this.grpSensors.Location = new System.Drawing.Point(12, 173);
            this.grpSensors.Name = "grpSensors";
            this.grpSensors.Size = new System.Drawing.Size(125, 74);
            this.grpSensors.TabIndex = 12;
            this.grpSensors.TabStop = false;
            this.grpSensors.Text = "Sensors";
            // 
            // lblLoop1
            // 
            this.lblLoop1.AutoSize = true;
            this.lblLoop1.Location = new System.Drawing.Point(6, 37);
            this.lblLoop1.Name = "lblLoop1";
            this.lblLoop1.Size = new System.Drawing.Size(37, 13);
            this.lblLoop1.TabIndex = 7;
            this.lblLoop1.Text = "Loop1";
            // 
            // lblLoop2
            // 
            this.lblLoop2.AutoSize = true;
            this.lblLoop2.Location = new System.Drawing.Point(6, 53);
            this.lblLoop2.Name = "lblLoop2";
            this.lblLoop2.Size = new System.Drawing.Size(37, 13);
            this.lblLoop2.TabIndex = 8;
            this.lblLoop2.Text = "Loop2";
            // 
            // lblExt2
            // 
            this.lblExt2.AutoSize = true;
            this.lblExt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExt2.Location = new System.Drawing.Point(68, 21);
            this.lblExt2.Name = "lblExt2";
            this.lblExt2.Size = new System.Drawing.Size(27, 13);
            this.lblExt2.TabIndex = 17;
            this.lblExt2.Text = "n/a";
            // 
            // lblAnalog2
            // 
            this.lblAnalog2.AutoSize = true;
            this.lblAnalog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalog2.Location = new System.Drawing.Point(68, 53);
            this.lblAnalog2.Name = "lblAnalog2";
            this.lblAnalog2.Size = new System.Drawing.Size(27, 13);
            this.lblAnalog2.TabIndex = 14;
            this.lblAnalog2.Text = "n/a";
            // 
            // lblAnalog1
            // 
            this.lblAnalog1.AutoSize = true;
            this.lblAnalog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalog1.Location = new System.Drawing.Point(68, 37);
            this.lblAnalog1.Name = "lblAnalog1";
            this.lblAnalog1.Size = new System.Drawing.Size(27, 13);
            this.lblAnalog1.TabIndex = 13;
            this.lblAnalog1.Text = "n/a";
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Location = new System.Drawing.Point(6, 21);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(46, 13);
            this.lblSensor1.TabIndex = 15;
            this.lblSensor1.Text = "Sensor1";
            // 
            // lblExt1
            // 
            this.lblExt1.AutoSize = true;
            this.lblExt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExt1.Location = new System.Drawing.Point(68, 53);
            this.lblExt1.Name = "lblExt1";
            this.lblExt1.Size = new System.Drawing.Size(27, 13);
            this.lblExt1.TabIndex = 16;
            this.lblExt1.Text = "n/a";
            // 
            // lblSystem3
            // 
            this.lblSystem3.AutoSize = true;
            this.lblSystem3.Location = new System.Drawing.Point(6, 53);
            this.lblSystem3.Name = "lblSystem3";
            this.lblSystem3.Size = new System.Drawing.Size(47, 13);
            this.lblSystem3.TabIndex = 14;
            this.lblSystem3.Text = "System3";
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.lblOutput6);
            this.grpOutputs.Controls.Add(this.lblOutput5);
            this.grpOutputs.Controls.Add(this.lblOutput4);
            this.grpOutputs.Controls.Add(this.lblOutput3);
            this.grpOutputs.Controls.Add(this.lblOutput2);
            this.grpOutputs.Controls.Add(this.lblOutput1);
            this.grpOutputs.Controls.Add(this.lblOutText6);
            this.grpOutputs.Controls.Add(this.lblOutText5);
            this.grpOutputs.Controls.Add(this.lblOutText4);
            this.grpOutputs.Controls.Add(this.lblOutText3);
            this.grpOutputs.Controls.Add(this.lblOutText2);
            this.grpOutputs.Controls.Add(this.lblOutText1);
            this.grpOutputs.Location = new System.Drawing.Point(505, 134);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(125, 122);
            this.grpOutputs.TabIndex = 13;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Outputs";
            // 
            // lblOutput6
            // 
            this.lblOutput6.AutoSize = true;
            this.lblOutput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput6.Location = new System.Drawing.Point(81, 100);
            this.lblOutput6.Name = "lblOutput6";
            this.lblOutput6.Size = new System.Drawing.Size(14, 13);
            this.lblOutput6.TabIndex = 14;
            this.lblOutput6.Text = "?";
            // 
            // lblOutput5
            // 
            this.lblOutput5.AutoSize = true;
            this.lblOutput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput5.Location = new System.Drawing.Point(81, 84);
            this.lblOutput5.Name = "lblOutput5";
            this.lblOutput5.Size = new System.Drawing.Size(14, 13);
            this.lblOutput5.TabIndex = 13;
            this.lblOutput5.Text = "?";
            // 
            // lblOutput4
            // 
            this.lblOutput4.AutoSize = true;
            this.lblOutput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput4.Location = new System.Drawing.Point(81, 68);
            this.lblOutput4.Name = "lblOutput4";
            this.lblOutput4.Size = new System.Drawing.Size(14, 13);
            this.lblOutput4.TabIndex = 12;
            this.lblOutput4.Text = "?";
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput3.Location = new System.Drawing.Point(81, 52);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(14, 13);
            this.lblOutput3.TabIndex = 11;
            this.lblOutput3.Text = "?";
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput2.Location = new System.Drawing.Point(81, 36);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(14, 13);
            this.lblOutput2.TabIndex = 10;
            this.lblOutput2.Text = "?";
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput1.Location = new System.Drawing.Point(81, 20);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(14, 13);
            this.lblOutput1.TabIndex = 9;
            this.lblOutput1.Text = "?";
            // 
            // lblOutText6
            // 
            this.lblOutText6.AutoSize = true;
            this.lblOutText6.Location = new System.Drawing.Point(6, 100);
            this.lblOutText6.Name = "lblOutText6";
            this.lblOutText6.Size = new System.Drawing.Size(45, 13);
            this.lblOutText6.TabIndex = 8;
            this.lblOutText6.Text = "Output6";
            // 
            // lblOutText5
            // 
            this.lblOutText5.AutoSize = true;
            this.lblOutText5.Location = new System.Drawing.Point(6, 84);
            this.lblOutText5.Name = "lblOutText5";
            this.lblOutText5.Size = new System.Drawing.Size(45, 13);
            this.lblOutText5.TabIndex = 7;
            this.lblOutText5.Text = "Output5";
            // 
            // lblOutText4
            // 
            this.lblOutText4.AutoSize = true;
            this.lblOutText4.Location = new System.Drawing.Point(6, 68);
            this.lblOutText4.Name = "lblOutText4";
            this.lblOutText4.Size = new System.Drawing.Size(45, 13);
            this.lblOutText4.TabIndex = 6;
            this.lblOutText4.Text = "Output4";
            // 
            // lblOutText3
            // 
            this.lblOutText3.AutoSize = true;
            this.lblOutText3.Location = new System.Drawing.Point(6, 52);
            this.lblOutText3.Name = "lblOutText3";
            this.lblOutText3.Size = new System.Drawing.Size(45, 13);
            this.lblOutText3.TabIndex = 5;
            this.lblOutText3.Text = "Output3";
            // 
            // lblOutText2
            // 
            this.lblOutText2.AutoSize = true;
            this.lblOutText2.Location = new System.Drawing.Point(6, 36);
            this.lblOutText2.Name = "lblOutText2";
            this.lblOutText2.Size = new System.Drawing.Size(45, 13);
            this.lblOutText2.TabIndex = 4;
            this.lblOutText2.Text = "Output2";
            // 
            // lblOutText1
            // 
            this.lblOutText1.AutoSize = true;
            this.lblOutText1.Location = new System.Drawing.Point(6, 20);
            this.lblOutText1.Name = "lblOutText1";
            this.lblOutText1.Size = new System.Drawing.Size(45, 13);
            this.lblOutText1.TabIndex = 3;
            this.lblOutText1.Text = "Output1";
            // 
            // grpAlarm
            // 
            this.grpAlarm.Controls.Add(this.lblMovement);
            this.grpAlarm.Controls.Add(this.label2);
            this.grpAlarm.Controls.Add(this.lblAlarmActive);
            this.grpAlarm.Controls.Add(this.label1);
            this.grpAlarm.Controls.Add(this.lblSentMail);
            this.grpAlarm.Controls.Add(this.lblAlarmTriggered);
            this.grpAlarm.Controls.Add(this.label5);
            this.grpAlarm.Controls.Add(this.label12);
            this.grpAlarm.Location = new System.Drawing.Point(12, 253);
            this.grpAlarm.Name = "grpAlarm";
            this.grpAlarm.Size = new System.Drawing.Size(125, 89);
            this.grpAlarm.TabIndex = 14;
            this.grpAlarm.TabStop = false;
            this.grpAlarm.Text = "Alarm / Error";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovement.Location = new System.Drawing.Point(68, 53);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(23, 13);
            this.lblMovement.TabIndex = 30;
            this.lblMovement.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Movement";
            // 
            // lblAlarmActive
            // 
            this.lblAlarmActive.AutoSize = true;
            this.lblAlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmActive.Location = new System.Drawing.Point(68, 21);
            this.lblAlarmActive.Name = "lblAlarmActive";
            this.lblAlarmActive.Size = new System.Drawing.Size(23, 13);
            this.lblAlarmActive.TabIndex = 28;
            this.lblAlarmActive.Text = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Active";
            // 
            // lblSentMail
            // 
            this.lblSentMail.AutoSize = true;
            this.lblSentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentMail.Location = new System.Drawing.Point(68, 69);
            this.lblSentMail.Name = "lblSentMail";
            this.lblSentMail.Size = new System.Drawing.Size(14, 13);
            this.lblSentMail.TabIndex = 26;
            this.lblSentMail.Text = "0";
            // 
            // lblAlarmTriggered
            // 
            this.lblAlarmTriggered.AutoSize = true;
            this.lblAlarmTriggered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmTriggered.Location = new System.Drawing.Point(68, 37);
            this.lblAlarmTriggered.Name = "lblAlarmTriggered";
            this.lblAlarmTriggered.Size = new System.Drawing.Size(23, 13);
            this.lblAlarmTriggered.TabIndex = 16;
            this.lblAlarmTriggered.Text = "No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mails Sent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Triggered";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.txtSend2,
            this.mnuSend,
            this.mnuCommands});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.debugToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.mnuFile.Enabled = false;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 23);
            this.mnuFile.Text = "File";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenPort,
            this.mnuClosePort});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // mnuOpenPort
            // 
            this.mnuOpenPort.Name = "mnuOpenPort";
            this.mnuOpenPort.Size = new System.Drawing.Size(103, 22);
            this.mnuOpenPort.Text = "Open";
            this.mnuOpenPort.Click += new System.EventHandler(this.mnuOpenPort_Click);
            // 
            // mnuClosePort
            // 
            this.mnuClosePort.Enabled = false;
            this.mnuClosePort.Name = "mnuClosePort";
            this.mnuClosePort.Size = new System.Drawing.Size(103, 22);
            this.mnuClosePort.Text = "Close";
            this.mnuClosePort.Click += new System.EventHandler(this.mnuClosePort_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDebugWindowToolStripMenuItem,
            this.mnuSendTestMail});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // showDebugWindowToolStripMenuItem
            // 
            this.showDebugWindowToolStripMenuItem.Name = "showDebugWindowToolStripMenuItem";
            this.showDebugWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showDebugWindowToolStripMenuItem.Text = "Show Window";
            this.showDebugWindowToolStripMenuItem.Click += new System.EventHandler(this.showDebugWindowToolStripMenuItem_Click);
            // 
            // mnuSendTestMail
            // 
            this.mnuSendTestMail.Name = "mnuSendTestMail";
            this.mnuSendTestMail.Size = new System.Drawing.Size(151, 22);
            this.mnuSendTestMail.Text = "Send Test Mail";
            this.mnuSendTestMail.Click += new System.EventHandler(this.mnuSendTestMail_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeProgramToolStripMenuItem.Text = "Exit SIOS";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // txtSend2
            // 
            this.txtSend2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSend2.Name = "txtSend2";
            this.txtSend2.Size = new System.Drawing.Size(100, 23);
            // 
            // mnuSend
            // 
            this.mnuSend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSend.Enabled = false;
            this.mnuSend.Name = "mnuSend";
            this.mnuSend.Size = new System.Drawing.Size(45, 23);
            this.mnuSend.Text = "Send";
            this.mnuSend.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // mnuCommands
            // 
            this.mnuCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmToolStripMenuItem,
            this.mnuOutlet});
            this.mnuCommands.Enabled = false;
            this.mnuCommands.Name = "mnuCommands";
            this.mnuCommands.Size = new System.Drawing.Size(81, 23);
            this.mnuCommands.Text = "Commands";
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleToolStripMenuItem});
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alarmToolStripMenuItem.Text = "Alarm System";
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.toggleToolStripMenuItem.Text = "Toggle";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // mnuOutlet
            // 
            this.mnuOutlet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offToolStripMenuItem,
            this.onToolStripMenuItem});
            this.mnuOutlet.Name = "mnuOutlet";
            this.mnuOutlet.Size = new System.Drawing.Size(152, 22);
            this.mnuOutlet.Text = "Output6";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onToolStripMenuItem.Text = "Off";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.offToolStripMenuItem.Text = "On";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoToolTip = true;
            this.toolStripProgressBar1.Maximum = 300;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(110, 16);
            this.toolStripProgressBar1.ToolTipText = "Remaining module timeout counter.";
            // 
            // lblTopStatus
            // 
            this.lblTopStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopStatus.Location = new System.Drawing.Point(15, 27);
            this.lblTopStatus.Name = "lblTopStatus";
            this.lblTopStatus.Size = new System.Drawing.Size(615, 43);
            this.lblTopStatus.TabIndex = 18;
            this.lblTopStatus.Text = "System Initializing...";
            this.lblTopStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSystem
            // 
            this.grpSystem.Controls.Add(this.lblSystem4);
            this.grpSystem.Controls.Add(this.lblPower);
            this.grpSystem.Controls.Add(this.lblSystem2);
            this.grpSystem.Controls.Add(this.lblIntVolt);
            this.grpSystem.Controls.Add(this.lblExt1);
            this.grpSystem.Controls.Add(this.lblSystem1);
            this.grpSystem.Controls.Add(this.lblIntTemp);
            this.grpSystem.Controls.Add(this.lblSystem3);
            this.grpSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSystem.Location = new System.Drawing.Point(12, 75);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.Size = new System.Drawing.Size(125, 92);
            this.grpSystem.TabIndex = 19;
            this.grpSystem.TabStop = false;
            this.grpSystem.Text = "System";
            // 
            // lblSystem4
            // 
            this.lblSystem4.AutoSize = true;
            this.lblSystem4.Location = new System.Drawing.Point(6, 69);
            this.lblSystem4.Name = "lblSystem4";
            this.lblSystem4.Size = new System.Drawing.Size(47, 13);
            this.lblSystem4.TabIndex = 16;
            this.lblSystem4.Text = "System4";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(68, 69);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(27, 13);
            this.lblPower.TabIndex = 17;
            this.lblPower.Text = "n/a";
            // 
            // lblSystem2
            // 
            this.lblSystem2.AutoSize = true;
            this.lblSystem2.Location = new System.Drawing.Point(6, 37);
            this.lblSystem2.Name = "lblSystem2";
            this.lblSystem2.Size = new System.Drawing.Size(47, 13);
            this.lblSystem2.TabIndex = 13;
            this.lblSystem2.Text = "System2";
            // 
            // lblIntVolt
            // 
            this.lblIntVolt.AutoSize = true;
            this.lblIntVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntVolt.Location = new System.Drawing.Point(68, 21);
            this.lblIntVolt.Name = "lblIntVolt";
            this.lblIntVolt.Size = new System.Drawing.Size(27, 13);
            this.lblIntVolt.TabIndex = 15;
            this.lblIntVolt.Text = "n/a";
            // 
            // lblSystem1
            // 
            this.lblSystem1.AutoSize = true;
            this.lblSystem1.Location = new System.Drawing.Point(6, 21);
            this.lblSystem1.Name = "lblSystem1";
            this.lblSystem1.Size = new System.Drawing.Size(47, 13);
            this.lblSystem1.TabIndex = 12;
            this.lblSystem1.Text = "System1";
            // 
            // lblIntTemp
            // 
            this.lblIntTemp.AutoSize = true;
            this.lblIntTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntTemp.Location = new System.Drawing.Point(68, 37);
            this.lblIntTemp.Name = "lblIntTemp";
            this.lblIntTemp.Size = new System.Drawing.Size(27, 13);
            this.lblIntTemp.TabIndex = 14;
            this.lblIntTemp.Text = "n/a";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(502, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "Main Project FE2 2010\r\nThomas Jensen\r\nRoy Ryvænge\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCComm.Properties.Resources.Sios;
            this.pictureBox1.Location = new System.Drawing.Point(505, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpSystem);
            this.Controls.Add(this.lblTopStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAlarm);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.grpSensors);
            this.Controls.Add(this.grpPort);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial I/O System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.grpLog.ResumeLayout(false);
            this.grpPort.ResumeLayout(false);
            this.grpSensors.ResumeLayout(false);
            this.grpSensors.PerformLayout();
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.grpAlarm.ResumeLayout(false);
            this.grpAlarm.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.GroupBox grpSensors;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.Label lblExt2;
        private System.Windows.Forms.Label lblExt1;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblSystem3;
        private System.Windows.Forms.Label lblOutText6;
        private System.Windows.Forms.Label lblOutText5;
        private System.Windows.Forms.Label lblOutText4;
        private System.Windows.Forms.Label lblOutText3;
        private System.Windows.Forms.Label lblOutText2;
        private System.Windows.Forms.Label lblOutText1;
        private System.Windows.Forms.GroupBox grpAlarm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLoop2;
        private System.Windows.Forms.Label lblLoop1;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblOutput6;
        private System.Windows.Forms.Label lblOutput5;
        private System.Windows.Forms.Label lblOutput4;
        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblAlarmTriggered;
        private System.Windows.Forms.Label lblAnalog2;
        private System.Windows.Forms.Label lblAnalog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSend2;
        private System.Windows.Forms.ToolStripMenuItem mnuSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblTopStatus;
        private System.Windows.Forms.GroupBox grpSystem;
        private System.Windows.Forms.Label lblSystem2;
        private System.Windows.Forms.Label lblIntVolt;
        private System.Windows.Forms.Label lblSystem1;
        private System.Windows.Forms.Label lblIntTemp;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label lblSentMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem mnuCommands;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.Label lblSystem4;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOutlet;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblAlarmActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenPort;
        private System.Windows.Forms.ToolStripMenuItem mnuClosePort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSendTestMail;
        private System.Windows.Forms.ToolStripMenuItem showDebugWindowToolStripMenuItem;
    }
}