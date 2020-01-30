using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Timers;
using System.Net.Mail;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace PCComm
{
    class CommunicationManager
    {
        #region Set Port Settings
        private int _baudRate = Properties.Settings.Default.BaudRate;
        private Parity _parity = Properties.Settings.Default.Parity;
        private StopBits _stopBits = Properties.Settings.Default.StopBits;
        private int _dataBits = Properties.Settings.Default.DataBits;
        private string _portName = string.Empty;
        #endregion

        #region Set GUI links
        public Label[] lblValues = new Label[10];
        public Label[] lblOutputs = new Label[6];

        public RichTextBox _displayWindow;
        public TextBox _debugWindow;
        public Label lblTopStatus;
        //public ToolStripStatusLabel lblButtomStatus1;
        //public ToolStripStatusLabel lblButtomStatus2;
        public ToolStripProgressBar barTimeOut;
        public ToolStrip toolStrip1;
        public Label lblSentMail;
        public Label lblAlarmActive;
        public Label lblMovement;
        #endregion

        #region Error Variables
        private int[] ErrorHysTimer = new int[16];
        private int[] ErrorHysCount = new int[16];
        private int ErrorHysCountSet = Properties.Settings.Default.ErrorHysCount;
        private int ErrorHysTimerSet = Properties.Settings.Default.ErrorHysTimer;
        private int ErrorHysTimerSet2 = Properties.Settings.Default.ErrorHysTimer2;
        private double[] Input = new double[7];
        private int ErrorRstCount = -1;
        ArrayList alAlarmList = new ArrayList();
        public enum ErrorMSG
        {
            Online,
            OK,
            SysVoltLo,
            SysVoltVeryLo,
            SysIntTempHi,
            SysIntTempVeryHi,
            Tamper,
            Timeout,
            Fire,
            Alarm,
            SysExtTempHi,
            SysExtTempVeryHi,
            ExtTempLo,
            BatteryLo,
            BatteryVeryLo,
            PowerOffline
        };
        private string[] ErrorMSGtxt = 
        {
            Properties.Alarms.Default.Online_Text,
            Properties.Alarms.Default.OK_Text,
            Properties.Alarms.Default.SysVoltLo_Text,
            Properties.Alarms.Default.SysVoltVeryLo_Text,
            Properties.Alarms.Default.SysIntTempHi_Text,
            Properties.Alarms.Default.SysIntTempVeryHi_Text,
            Properties.Alarms.Default.Tamper_Text,
            Properties.Alarms.Default.Timeout_Text,
            Properties.Alarms.Default.Fire_Text,
            Properties.Alarms.Default.Alarm_Text,
            Properties.Alarms.Default.SysExtTempHi_Text,
            Properties.Alarms.Default.SysExtTempVeryHi_Text,
            Properties.Alarms.Default.ExtTempLo_Text,
            Properties.Alarms.Default.BatteryLo_Text,
            Properties.Alarms.Default.BatteryVeryLo_Text,
            Properties.Alarms.Default.PowerOffline_Text,
        };
        private Color[] ErrorMSGcol =
        {
            Properties.Alarms.Default.Online_Color,
            Properties.Alarms.Default.OK_Color,
            Properties.Alarms.Default.SysVoltLo_Color,
            Properties.Alarms.Default.SysVoltVeryLo_Color,
            Properties.Alarms.Default.SysIntTempHi_Color,
            Properties.Alarms.Default.SysIntTempVeryHi_Color,
            Properties.Alarms.Default.Tamper_Color,
            Properties.Alarms.Default.Timeout_Color,
            Properties.Alarms.Default.Fire_Color,
            Properties.Alarms.Default.Alarm_Color,
            Properties.Alarms.Default.SysExtTempHi_Color,
            Properties.Alarms.Default.SysExtTempVeryHi_Color,
            Properties.Alarms.Default.ExtTempLo_Color,
            Properties.Alarms.Default.BatteryLo_Color,
            Properties.Alarms.Default.BatteryVeryLo_Color,
            Properties.Alarms.Default.PowerOffline_Color
        };
        private double[] ErrorLimit =
        {
            0,
            0,
            Properties.Alarms.Default.SysVoltLo_Limit,
            Properties.Alarms.Default.SysVoltVeryLo_Limit,
            Properties.Alarms.Default.SysIntTempHi_Limit,
            Properties.Alarms.Default.SysIntTempVeryHi_Limit,
            Properties.Alarms.Default.Tamper_Limit,
            0,
            Properties.Alarms.Default.Fire_Limit,
            0,
            Properties.Alarms.Default.SysExtTempHi_Limit,
            Properties.Alarms.Default.SysExtTempVeryHi_Limit,
            Properties.Alarms.Default.ExtTempLo_Limit,
            Properties.Alarms.Default.BatteryLo_Limit,
            Properties.Alarms.Default.BatteryVeryLo_Limit,
            0
        };
        private int[] ErrorValue =
        {
            -1,
            -1,
            Properties.Alarms.Default.SysVoltLo_Value,
            Properties.Alarms.Default.SysVoltVeryLo_Value,
            Properties.Alarms.Default.SysIntTempHi_Value,
            Properties.Alarms.Default.SysIntTempVeryHi_Value,
            Properties.Alarms.Default.Tamper_Value,
            Properties.Alarms.Default.Timeout_Value,
            Properties.Alarms.Default.Fire_Value,
            Properties.Alarms.Default.Alarm_Value,
            Properties.Alarms.Default.SysExtTempHi_Value,
            Properties.Alarms.Default.SysExtTempVeryHi_Value,
            Properties.Alarms.Default.ExtTempLo_Value,
            Properties.Alarms.Default.BatteryLo_Value,
            Properties.Alarms.Default.BatteryVeryLo_Value,
            Properties.Alarms.Default.PowerOffline_Value
        };
        private string[] ErrorDenom =
        {
            null,
            null,
            Properties.Alarms.Default.SysVoltLo_Denom,
            Properties.Alarms.Default.SysVoltVeryLo_Denom,
            Properties.Alarms.Default.SysIntTempHi_Denom,
            Properties.Alarms.Default.SysIntTempVeryHi_Denom,
            Properties.Alarms.Default.Tamper_Denom,
            null,
            Properties.Alarms.Default.Fire_Denom,
            null,
            Properties.Alarms.Default.SysExtTempHi_Denom,
            Properties.Alarms.Default.SysExtTempVeryHi_Denom,
            Properties.Alarms.Default.ExtTempLo_Denom,
            Properties.Alarms.Default.BatteryLo_Denom,
            Properties.Alarms.Default.BatteryVeryLo_Denom,
            null
        };
        private bool[] ErrorImage =
        {
            Properties.Alarms.Default.Online_Image,
            Properties.Alarms.Default.OK_Image,
            Properties.Alarms.Default.SysVoltLo_Image,
            Properties.Alarms.Default.SysVoltVeryLo_Image,
            Properties.Alarms.Default.SysTempHi_Image,
            Properties.Alarms.Default.SysTempVeryHi_Image,
            Properties.Alarms.Default.Tamper_Image,
            Properties.Alarms.Default.Timeout_Image,
            Properties.Alarms.Default.Fire_Image,
            Properties.Alarms.Default.Alarm_Image,
            Properties.Alarms.Default.SysExtTempHi_Image,
            Properties.Alarms.Default.SysExtTempVeryHi_Image,
            Properties.Alarms.Default.ExtTempLo_Image,
            Properties.Alarms.Default.BatteryLo_Image,
            Properties.Alarms.Default.BatteryVeryLo_Image,
            Properties.Alarms.Default.PowerOffline_Image,
        };
        #endregion

        #region Command Sending Variables
        public ArrayList alCommandList = new ArrayList();
        public int InputToPull = 0;
        public enum SendCOM
        {
            iFire,
            iSysVolt,
            iTamper,
            iSysTemp,
            iTemp1,
            iTemp2,
            oBuzzerOff,
            oRedLEDOff,
            oStrobeOff,
            oKeyLEDOff,
            oErrLEDOff,
            oOutletOff,
            oBuzzerOn,
            oRedLEDOn,
            oStrobeOn,
            oKeyLEDOn,
            oErrLEDOn,
            oOutletOn
        };
        private string[] SendCOMtxt = 
        {
            Properties.Commands.Default.iFire,
            Properties.Commands.Default.iSysVolt,
            Properties.Commands.Default.iTamper,
            Properties.Commands.Default.iSysTemp,
            Properties.Commands.Default.iTemp1,
            Properties.Commands.Default.iTemp2,
            Properties.Commands.Default.oBuzzerOff,
            Properties.Commands.Default.oRedLEDOff,
            Properties.Commands.Default.oStrobeOff,
            Properties.Commands.Default.oKeyLEDOff,
            Properties.Commands.Default.oErrLEDOff,
            Properties.Commands.Default.oOutletOff,
            Properties.Commands.Default.oBuzzerOn,
            Properties.Commands.Default.oRedLEDOn,
            Properties.Commands.Default.oStrobeOn,
            Properties.Commands.Default.oKeyLEDOn,
            Properties.Commands.Default.oErrLEDOn,
            Properties.Commands.Default.oOutletOn
        };
        #endregion



        #region Variables
        public enum MessageType { Info, Error, Standard, Event };
        private Color[] MessageColor = { Color.Green, Color.Red, Color.Black, Color.Blue };
        private Color[] OutputColor = { Color.Black, Color.Green };

        public SerialPort comPort = new SerialPort();
        private PowerStatus power = SystemInformation.PowerStatus;
        
        public string Location = Properties.Settings.Default.Location;
        private int AlarmTimer = -1;
        private int TimeoutTimerMax = Properties.Settings.Default.TimeoutTimer * 10;
        private int TimeoutTimer = Properties.Settings.Default.TimeoutTimer * 10;
        private int SentMail = 0;
        private string ModuleID = Properties.Settings.Default.ModuleID;
        
        private bool AlarmActive = false;
        private bool AlarmTriggered = false;
        private bool ModuleTimeOut = false;
        private bool Movement = false;
        private bool ErrorNOW = false;
        public bool MailBlock = true;
        public bool ShutDown = false;

        #endregion

        #region Manager Properties
        // property to hold the PortName of our manager class
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        // property to hold our display window value
        public RichTextBox DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }

        public TextBox DebugWindow
        {
            get { return _debugWindow; }
            set { _debugWindow = value; }
        }

        #endregion

        #region Manager Constructors
        // Constructor to set the properties of our Manager Class
        public CommunicationManager(string baud, string par, string sBits, string dBits, string name, RichTextBox rtb, TextBox deb)
        {
            _portName = name;
            _displayWindow = rtb;
            _debugWindow = deb;
            //now add an event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }

        // Comstructor to set the properties of our serial port communicator to nothing
        public CommunicationManager()
        {
            _portName = null;
            _displayWindow = null;
            _debugWindow = null;
            //add event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }
        #endregion

        #region WriteData
        public void WriteData(string msg)
        {
            try
                {
                    //first make sure the port is open, if its not open then open it
                    if (!(comPort.IsOpen == true)) comPort.Open();
                    //send the message to the port
                    comPort.Write("0" + msg + Environment.NewLine);
                    //display the message
                    DisplayDebug("Data <-- " + msg);
                }
                    catch (Exception ex)
                {
                    //display error message
                    //pullTimer.Enabled = false;
                    DisplayData(MessageType.Error, "COM writedata: " + ex.Message);
                }
        }
        #endregion

        #region Display Log
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            _displayWindow.Invoke(new EventHandler(delegate
        {
            try
            {
                _displayWindow.SelectedText = string.Empty;
                _displayWindow.SelectionFont = new Font(_displayWindow.SelectionFont, FontStyle.Bold);
                _displayWindow.SelectionColor = MessageColor[(int)type];
                _displayWindow.AppendText(GetTime() + msg + "\n");
                _displayWindow.ScrollToCaret();
                LogFile(msg, false);
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, "Log window: " + ex.Message);
            }
            }));
        }
        #endregion

        #region Debug Window
        [STAThread]
        private void DisplayDebug(string msg)
        {
            _debugWindow.Invoke(new EventHandler(delegate
            {
                try
                {
                    _debugWindow.SelectedText = string.Empty;
                    _debugWindow.AppendText(GetTime() + msg + "\n");
                    _debugWindow.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    DisplayDebug(ex.Message);
                }
            }));
        }
        #endregion

        #region Display Alarm
        [STAThread]
        private void DisplayAlarm(int nr)
        {
            _displayWindow.Invoke(new EventHandler(delegate
            {
                try
                {
                    lblTopStatus.ForeColor = ErrorMSGcol[nr];
                    lblTopStatus.Invoke(new EventHandler(delegate { lblTopStatus.Text = ErrorMSGtxt[nr]; }));
                    if (ErrorHysCount[nr] < ErrorHysCountSet & nr > (int)ErrorMSG.OK) ErrorHysCount[nr] += 1;

                    if (ErrorValue[nr] > -1)
                    {
                        if (lblValues[(ErrorValue[nr])].ForeColor != ErrorMSGcol[nr]) lblValues[(ErrorValue[nr])].ForeColor = ErrorMSGcol[nr];
                    }

                    if (ErrorHysCount[nr] == ErrorHysCountSet | ((nr == (int)ErrorMSG.Fire | nr == (int)ErrorMSG.Tamper | nr == (int)ErrorMSG.Alarm | nr == (int)ErrorMSG.Timeout) & ErrorHysCount[nr] != 255))
                    {
                        if (MailBlock == false & Properties.Settings.Default.MailEnable == true)
                        {
                            if (ErrorDenom[nr] == null) this.SendEmail(ErrorMSGtxt[nr], ErrorImage[nr]);
                            else this.SendEmail(ErrorMSGtxt[nr] + " (" + Input[(ErrorValue[nr])] + ErrorDenom[nr] + ")", ErrorImage[nr]);
                        }

                        DisplayData(MessageType.Event, "(" + nr + ") " + ErrorMSGtxt[nr]);
                        ErrorHysCount[nr] = 255;
                        ErrorNOW = true;

                        if (ErrorDenom[nr] == null) LogFile(ErrorMSGtxt[nr], true);
                        else LogFile(ErrorMSGtxt[nr] + " (" + Input[(ErrorValue[nr])] + ErrorDenom[nr] + ")", true);
                    }

                    if (ErrorHysCount[nr] == 255) ErrorHysTimer[nr] = ErrorHysTimerSet;
                    else ErrorHysTimer[nr] = ErrorHysTimerSet2;
                }
                catch (Exception ex)
                {
                    DisplayData(MessageType.Error, "Display alarm: " + ex.Message);
                }
            }));
        }
        #endregion

        #region Open/Close Port
        public bool OpenPort()
        {
            try
            {
                //first check if the port is already open, if its open then close it
                if (comPort.IsOpen == true) comPort.Close();

                //set the properties of our SerialPort Object
                comPort.BaudRate = _baudRate;
                comPort.DataBits = _dataBits;
                comPort.StopBits = _stopBits;
                comPort.Parity =_parity;
                comPort.PortName = _portName; 
                //now open the port
                comPort.Open();
                //display message
                DisplayData(MessageType.Info, "Serial port " + _portName +" opened.");
                pullTimer.Enabled = true;
                displayTimer.Enabled = true;
                commandTimer.Enabled = true;
                timeoutTimer.Enabled = true;
                mailblockTimer.Enabled = true;
                DisplayData(MessageType.Standard, "Mail block engaged.");
                Properties.Settings.Default.PortName = _portName;

                //pull output status
                int x = 6;
                while (x < 12)
                {
                    alCommandList.Add(x);
                    x += 1;
                }
                
                //return true
                return true;
            }
            catch (Exception)
            {
                DisplayData(MessageType.Error, "Unable to open port " + _portName + ".");
                return false;
            }
        }

        public void ClosePort(int step)
        {
            switch (step)
            {
                case 0:
                    pullTimer.Enabled = false;
                    displayTimer.Enabled = false;
                    timeoutTimer.Enabled = false;
                    ShutDown = true;
                    DisplayData(MessageType.Standard, "Stopping display and pulling timers.");
                    lblTopStatus.Invoke(new EventHandler(delegate
                    {
                        lblTopStatus.Text = "Closing Serial Port...";
                        lblTopStatus.ForeColor = Color.Black;
                    }));
                    break;

                case 1:
                    alCommandList.Clear();
                    int i = 6;
                    while (i < 12)
                    {
                        alCommandList.Add(i);
                        i += 1;
                    }
                    DisplayData(MessageType.Standard, "Clearing commands and outputs.");
                    break;

                case 2:
                    commandTimer.Enabled = false;
                    DisplayData(MessageType.Standard, "Stopping command timers.");
                    TimeoutTimer = Properties.Settings.Default.TimeoutTimer * 10;
                    break;

                case 3:
                    comPort.Close();
                    DisplayData(MessageType.Info, "Serial port " + _portName + " closed.");
                    lblTopStatus.Invoke(new EventHandler(delegate
                    {
                        lblTopStatus.Text = "System Offline";
                        lblTopStatus.ForeColor = Color.Black;
                    }));
                    break;
            }
        }

        #endregion

        #region SetPortNameValues
        public void SetPortNameValues(object obj)
        {
            foreach (string str in SerialPort.GetPortNames())
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region comPort DataReceived
        // method that will be called when theres data waiting in the buffer
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read data waiting in the buffer
            string msg = comPort.ReadLine();
            //display the data to the user
            DisplayDebug("Data --> " + msg);
            if (msg.Substring(0, 3) == ModuleID) CommandCheck(msg);
        }
        #endregion

        #region Check Total Command
        // Command check and calculation
        private void CommandCheck(string command)
        {
            new Thread((ThreadStart)delegate
                {
            string command_type = command.Substring(4, 1);
            int command_nr = Convert.ToInt16(command.Substring(6, 2));
            int command_stat = Convert.ToInt16(command.Substring(9, 3));

            //toolStrip1.Invoke(new EventHandler(delegate { lblButtomStatus2.Text = command.Substring(0,12); }));
            if (ShutDown == false) pullTimer.Enabled = true;

            if (ErrorRstCount == -1)
            {
                alAlarmList.Add((int)ErrorMSG.Online);
                ErrorRstCount = 0;
            }

            if (command_type == "s" & command_nr == 1)
            {
                TimeoutTimer = TimeoutTimerMax;
                ModuleTimeOut = false;
                //pullTimer.Enabled = true;
            }

            if (command_type == "o") OutputCheck(command_nr, command_stat);

            if (command_type == "i")
            {
                switch(command_nr)
                {
                    case 1:
                        Input1Check(command_stat);
                        break;
                    case 2:
                        Input2Check(command_stat);
                        break;
                    case 3:
                        Input3Check(command_stat);
                        break;
                    case 4:
                        Input4Check(command_stat);
                        break;
                    case 5:
                        Input5Check(command_stat);
                        break;
                    case 6:
                        Input6Check(command_stat);
                        break;
                    default:
                        InputCheck(command_nr, command_stat);
                        break;
                }
            } }).Start();
        } 
        #endregion

        #region Input Analog 1 Command
        private void Input1Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[0] = Math.Round(value * 4.94 * 0.006, 2);
            if (Input[0] > ErrorLimit[(int)ErrorMSG.Fire])
                lblValues[0].Invoke(new EventHandler(delegate { lblValues[0].Text = "Closed"; }));
            else
            {
                lblValues[0].Invoke(new EventHandler(delegate { lblValues[0].Text = "Open"; }));
                alAlarmList.Add((int)ErrorMSG.Fire);
            };
                }).Start();
        }
        #endregion
        #region Input Analog 2 Command
        private void Input2Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[1] = Math.Round(value * 4.94 * 0.006 - 0.26, 2);
            lblValues[1].Invoke(new EventHandler(delegate { lblValues[1].Text = Convert.ToString(Input[1] + ErrorDenom[(int)ErrorMSG.SysVoltLo]); }));
            if (Input[1] < ErrorLimit[(int)ErrorMSG.SysVoltVeryLo])
                alAlarmList.Add((int)ErrorMSG.SysVoltVeryLo);
            else if (Input[1] < ErrorLimit[(int)ErrorMSG.SysVoltLo])
                alAlarmList.Add((int)ErrorMSG.SysVoltLo);
                    }).Start();
        }
        #endregion
        #region Input Analog 3 Command
        private void Input3Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[2] = Math.Round(value * 4.94 * 0.006, 2);
            if (Input[2] > ErrorLimit[(int)ErrorMSG.Tamper])
                lblValues[2].Invoke(new EventHandler(delegate { lblValues[2].Text = "Closed"; }));
            else
            {
                lblValues[2].Invoke(new EventHandler(delegate { lblValues[2].Text = "Open"; }));
                alAlarmList.Add((int)ErrorMSG.Tamper);
            }
                    }).Start();
        }
        #endregion
        #region Input Analog 4 Command
        private void Input4Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[3] = Math.Round(value * 4.94 / 10, 1);
            lblValues[3].Invoke(new EventHandler(delegate { lblValues[3].Text = Convert.ToString(Input[3] + ErrorDenom[(int)ErrorMSG.SysIntTempHi]); }));
            if (Input[3] > ErrorLimit[(int)ErrorMSG.SysIntTempVeryHi])
                alAlarmList.Add((int)ErrorMSG.SysIntTempVeryHi);
            else if (Input[3] > ErrorLimit[(int)ErrorMSG.SysIntTempHi])
                alAlarmList.Add((int)ErrorMSG.SysIntTempHi);
                    }).Start();
        }
        #endregion
        #region Input Analog 5 Command
        private void Input5Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[4] = Math.Round(value * 4.94 / 10, 1);
            lblValues[4].Invoke(new EventHandler(delegate { lblValues[4].Text = Convert.ToString(Input[4] + ErrorDenom[(int)ErrorMSG.SysExtTempHi]); }));
            if (Input[4] > ErrorLimit[(int)ErrorMSG.SysExtTempVeryHi])
                alAlarmList.Add((int)ErrorMSG.SysExtTempVeryHi);
            else if (Input[4] > ErrorLimit[(int)ErrorMSG.SysExtTempHi])
                alAlarmList.Add((int)ErrorMSG.SysExtTempHi);
                    }).Start();
        }
        #endregion
        #region Input Analog 6 Command
        private void Input6Check(double value)
        {
                    new Thread((ThreadStart)delegate
                {
            Input[5] = Math.Round(value * 4.94 / 10, 1);
            lblValues[5].Invoke(new EventHandler(delegate { lblValues[5].Text = Convert.ToString(Input[5] + ErrorDenom[(int)ErrorMSG.ExtTempLo]); }));
            if (Input[5] < ErrorLimit[(int)ErrorMSG.ExtTempLo])
                alAlarmList.Add((int)ErrorMSG.ExtTempLo);
                    }).Start();
        }
        #endregion

        #region Input Digital Command
        private void InputCheck(int nr, int stat)
        {
        new Thread((ThreadStart)delegate
                {
        if (nr == 7)
        {
            if (stat == 1)
            {
                lblMovement.Invoke(new EventHandler(delegate
                {
                    lblMovement.Text = "No";
                    lblMovement.ForeColor = Color.Black;
                }));
                Movement = false;
            }
            if (stat == 0)
            {
                lblMovement.Invoke(new EventHandler(delegate
                {
                    lblMovement.Text = "Yes";
                    lblMovement.ForeColor = Color.Red;
                }));
                Movement = true;
                if (AlarmActive == true & AlarmTriggered == false)
                {
                    if (AlarmTimer == -1) AlarmTimer = Convert.ToInt16(Properties.Settings.Default.AlarmDelayIn);
                    alarmTimer.Enabled = true;
                    alCommandList.Add((int)SendCOM.oStrobeOn);
                }
            }
            }

            if (nr == 8)
            {
                if (stat == 1) ToggleAlarm();
            }
                }).Start();
        }
        #endregion

        #region Outputs Digital Command
        private void OutputCheck(int nr, int stat)
        {
        new Thread((ThreadStart)delegate
                {
            string Output_status = "";

            if (stat == 1) Output_status = "High";
            if (stat == 0) Output_status = "Low";
            if (nr == 1) lblOutputs[0].Invoke(new EventHandler(delegate {
                lblOutputs[0].ForeColor = OutputColor[(stat)];
                lblOutputs[0].Text = Output_status; 
            }));
            if (nr == 2) lblOutputs[1].Invoke(new EventHandler(delegate {
                lblOutputs[1].ForeColor = OutputColor[(stat)];
                lblOutputs[1].Text = Output_status; 
            }));
            if (nr == 3) lblOutputs[2].Invoke(new EventHandler(delegate {
                lblOutputs[2].ForeColor = OutputColor[(stat)];
                lblOutputs[2].Text = Output_status; 
            }));
            if (nr == 4) lblOutputs[3].Invoke(new EventHandler(delegate {
                lblOutputs[3].ForeColor = OutputColor[(stat)]; 
                lblOutputs[3].Text = Output_status;
            }));
            if (nr == 5) lblOutputs[4].Invoke(new EventHandler(delegate {
                lblOutputs[4].ForeColor = OutputColor[(stat)]; 
                lblOutputs[4].Text = Output_status;
            }));
            if (nr == 6) lblOutputs[5].Invoke(new EventHandler(delegate {
                lblOutputs[5].ForeColor = OutputColor[(stat)]; 
                lblOutputs[5].Text = Output_status;
            }));
        } ).Start();
        }
        #endregion

        #region Init Timers
            private System.Timers.Timer pullTimer;
            private System.Timers.Timer timeoutTimer;
            private System.Timers.Timer commandTimer;
            private System.Timers.Timer displayTimer;
            private System.Timers.Timer alarmTimer;
            private System.Timers.Timer mailblockTimer;
            private System.Timers.Timer alarmResetTimer;

        public void InitTimer()
        {
            pullTimer = new System.Timers.Timer(500);
            pullTimer.Elapsed += new ElapsedEventHandler(pullTimerHandler);

            commandTimer = new System.Timers.Timer(100);
            commandTimer.Elapsed += new ElapsedEventHandler(commandTimerHandler);
            
            displayTimer = new System.Timers.Timer(1000);
            displayTimer.Elapsed += new ElapsedEventHandler(displayTimerHandler);

            alarmTimer = new System.Timers.Timer(1000);
            alarmTimer.Elapsed += new ElapsedEventHandler(alarmTimerHandler);

            alarmResetTimer = new System.Timers.Timer(Properties.Settings.Default.AlarmResetTimer * 1000);
            alarmResetTimer.Elapsed += new ElapsedEventHandler(alarmResetTimerHandler);
            alarmResetTimer.AutoReset = false;
            
            timeoutTimer = new System.Timers.Timer(100);
            timeoutTimer.Elapsed += new ElapsedEventHandler(timeoutTimerHandler);

            mailblockTimer = new System.Timers.Timer(Properties.Settings.Default.MailBlockTimer * 1000);
            mailblockTimer.Elapsed += new ElapsedEventHandler(mailblockTimerHandler);
            mailblockTimer.AutoReset = false;
        }
        #endregion

        #region Input Pull Timer Handler
        private void pullTimerHandler(object source, ElapsedEventArgs e)
        {
            int max = 5;

            alCommandList.Add(InputToPull);
            if (InputToPull == 0 && AlarmTriggered == true) alAlarmList.Add((int)ErrorMSG.Alarm);
            if (InputToPull == 1 && power.PowerLineStatus != PowerLineStatus.Online)
            {
                if (Input[6] < ErrorLimit[(int)ErrorMSG.BatteryVeryLo]) alAlarmList.Add((int)ErrorMSG.BatteryVeryLo);
                else if (Input[6] < ErrorLimit[(int)ErrorMSG.BatteryLo]) alAlarmList.Add((int)ErrorMSG.BatteryLo);
            }
            if (InputToPull == 2 && power.PowerLineStatus != PowerLineStatus.Online) alAlarmList.Add((int)ErrorMSG.PowerOffline);
            if (InputToPull == 3 && ModuleTimeOut == true)
            {
                alAlarmList.Add((int)ErrorMSG.Timeout);
                DisplayData(MessageType.Error, "Module offline, closing port.");
                DoClosePort();
            }
                
            InputToPull += 1;
            if (InputToPull > max) InputToPull = 0;
        }
        #endregion

        #region Timeout Timer Handler
        private void timeoutTimerHandler(object source, ElapsedEventArgs e)
        {
            try
            {
                if (TimeoutTimer > 0) TimeoutTimer -= 1;
                else ModuleTimeOut = true;

                if (TimeoutTimer == 25) DisplayData(MessageType.Info, "Module close to timing out.");
                toolStrip1.Invoke(new EventHandler(delegate { barTimeOut.Value = TimeoutTimer; }));

                Input[6] = Convert.ToDouble(Math.Round(power.BatteryLifePercent * 100, 0));
                lblValues[6].Invoke(new EventHandler(delegate { lblValues[6].Text = Convert.ToString(Input[6]) + " %"; }));
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, "Timeout timer: " + ex.Message);
            }
        }
        #endregion

        #region Mailblock Timer Handler
        private void mailblockTimerHandler(object source, ElapsedEventArgs e)
        {
            DisplayData(MessageType.Standard, "Mail block disengaged.");
            MailBlock = false;
        }
        #endregion

        #region Alarm Reset/Rearm Timer Handler
        private void alarmResetTimerHandler(object source, ElapsedEventArgs e)
        {
            DisplayData(MessageType.Info, "Resetting and rearming alarm.");
            alCommandList.Add((int)SendCOM.oBuzzerOff);
            alCommandList.Add((int)SendCOM.oStrobeOff);
            AlarmTriggered = false;
            lblValues[7].Invoke(new EventHandler(delegate { lblValues[7].Text = "No"; }));
        }
        #endregion

        #region Send Command Timer Handler
        private void commandTimerHandler(object source, ElapsedEventArgs e)
        {
            try
            {
                int x = 0;

                while (x < alCommandList.Count)
                {
                    if ((int)alCommandList[x] > -1 & x < alCommandList.Count)
                    {
                        WriteData(SendCOMtxt[(int)alCommandList[x]]);
                        alCommandList.RemoveAt(x);
                        x = 256;
                    }
                    x += 1;
                }
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, "Send command failed!");
            }
        }
        #endregion

        #region Error Display Timer Handler
        private void displayTimerHandler(object source, ElapsedEventArgs e)
        {
            int x = 0;
            int z = 0;
            int cache = 0;

            while (x < alAlarmList.Count)
            {
                if ((int)alAlarmList[x] > -1)
                {
                    DisplayAlarm((int)alAlarmList[x]);
                    cache = (int)alAlarmList[x];
                    alAlarmList.RemoveAt(x);
                    if (alAlarmList.Contains(cache) == true)
                    {
                        //DisplayDebug(cache + " " + alAlarmList.LastIndexOf(cache));
                        alAlarmList.RemoveAt(alAlarmList.LastIndexOf(cache));
                    }
                    x = 255;
                    ErrorRstCount = 6;
                }
                x += 1;
            }

            while (z < (ErrorMSGtxt.Length))
            {
                if (ErrorHysTimer[z] > 0)
                    ErrorHysTimer[z] -= 1;
                if (ErrorHysTimer[z] == 1 & ErrorHysCount[z] == 255)
                {
                    DisplayData(MessageType.Standard, "(" + z + ") Hysteresis resetting.");
                    if (ErrorValue[z] > 0)lblValues[(ErrorValue[z])].ForeColor = Color.Black;
                }
                if (ErrorHysTimer[z] == 0)ErrorHysCount[z] = 0;
                z++;
            }
            //DisplayDebug(alAlarmList.Count);

            if (ErrorRstCount == 1)
            {
                alAlarmList.Add(ErrorMSG.OK);
                ErrorNOW = false;
            }
            if(ErrorRstCount > 0)ErrorRstCount -= 1;

            //ErrorLED Set
            if (Properties.Settings.Default.ErrorLED == false & lblOutputs[4].Text == "High") alCommandList.Add((int)SendCOM.oErrLEDOff);
            if (Properties.Settings.Default.ErrorLED == true & lblOutputs[4].Text == "Low" & ErrorNOW == true) alCommandList.Add((int)SendCOM.oErrLEDOn);
            if (ErrorNOW == false & lblOutputs[4].Text == "High") alCommandList.Add((int)SendCOM.oErrLEDOff); 

        }
        #endregion

        #region Alarm Timer Handler
        private void alarmTimerHandler(object source, ElapsedEventArgs e)
        {
            if (AlarmTimer == 0)
            {
                switch(AlarmActive)
                {
                    case false:
                        if (Movement == false)
                        {
                            lblAlarmActive.Invoke(new EventHandler(delegate
                            {
                                lblAlarmActive.Text = "Yes";
                                lblAlarmActive.ForeColor = Color.Red;
                            }));
                            AlarmActive = true;
                            alCommandList.Add((int)SendCOM.oKeyLEDOn);
                            alCommandList.Add((int)SendCOM.oRedLEDOn);
                            alCommandList.Add((int)SendCOM.oStrobeOff);
                            DisplayData(MessageType.Info, "Alarm system armed!");
                            AlarmTimer = -1;
                            alarmTimer.Enabled = false;
                        }
                        else
                        {
                            AlarmTimer = 10;
                            DisplayData(MessageType.Info, "Movement; delaying alarm arming.");
                        }
                        break;

                    case true:
                        lblValues[7].Invoke(new EventHandler(delegate { lblValues[7].Text = "Yes"; }));
                        if(Properties.Settings.Default.AlarmSimulate == false) alCommandList.Add((int)SendCOM.oBuzzerOn);
                        else if (ErrorHysTimer[(int)ErrorMSG.Alarm] == 0) DisplayData(MessageType.Standard, "Alarm system simulate ONLY!");
                        AlarmTriggered = true;
                        AlarmTimer = -1;
                        alarmTimer.Enabled = false;
                        alarmResetTimer.Enabled = true;
                        break;
                }
            }
            else
            {
                switch(AlarmActive)
                {
                    case false:
                        if (AlarmTimer % 10 == 0) DisplayData(MessageType.Standard, "Arming in " + AlarmTimer + " seconds.");
                        AlarmTimer -= 1;
                        lblAlarmActive.Invoke(new EventHandler(delegate
                        {
                            lblAlarmActive.Text = "Delay";
                            lblAlarmActive.ForeColor = Color.Green;
                        }));
                        break;
                    
                    case true:
                        if (AlarmTimer % 10 == 0) DisplayData(MessageType.Standard, "Triggering in " + AlarmTimer + " seconds.");
                        AlarmTimer -= 1;
                        lblValues[7].Invoke(new EventHandler(delegate { lblValues[7].Text = "Delay"; }));
                        break;
                }
            }
        }
        #endregion

        #region Get Time Function
        public string GetTime()
        {
            string TimeInString = "";
            TimeInString = Convert.ToString(DateTime.Now.TimeOfDay);
            TimeInString = TimeInString.Substring(0, 11);
            return TimeInString + " : ";
        }
        #endregion

        #region Send Mail Handler
        public void SendEmail(string situation, bool bilde)
        {
            new Thread((ThreadStart)delegate
                {
                    try
                    {
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress("SIOS: " + Location + " <alarm@sios.no>");
                        message.To.Add(new MailAddress(Properties.Settings.Default.MailTO));
                        if (Properties.Settings.Default.MailCC != "" & Properties.Settings.Default.MailIgnoreCC == false) message.CC.Add(new MailAddress(Properties.Settings.Default.MailCC));
                        message.Subject = situation;
                        message.Body = "Alarm: " + situation + "\nLoc  : " + Location + "\nTime : " + Convert.ToString(DateTime.Now);
                        if (bilde == true)
                        {
                            message.Attachments.Add(new Attachment(Properties.Settings.Default.Image_Dir+"\\"+Properties.Settings.Default.Image_File+".jpg"));
                            int imagenr = 1;
                            while (imagenr <= Properties.Settings.Default.Image_Nr)
                            {
                                message.Attachments.Add(new Attachment(Properties.Settings.Default.Image_Dir+"\\"+Properties.Settings.Default.Image_File+"0"+imagenr+".jpg"));
                                imagenr++;
                            }
                        }
                        SmtpClient client = new SmtpClient();
                        client.Send(message);
                        SentMail += 1;
                        lblSentMail.Invoke(new EventHandler(delegate { lblSentMail.Text = Convert.ToString(SentMail); }));
                        message.Dispose();
                    }
                    catch (Exception ex)
                    {
                        DisplayData(MessageType.Error, "Send mail: " + ex.Message);
                    } }).Start();
        }
        #endregion

        #region Toggle Alarm Handler
        public void ToggleAlarm()
        {
            if (AlarmActive == false & alarmTimer.Enabled == false)
            {
                if (Movement == true) DisplayData(MessageType.Info, "Movement; can not activate alarm.");
                else
                {
                    AlarmTimer = Convert.ToInt16(Properties.Settings.Default.AlarmDelayOut);
                    alarmTimer.Enabled = true;
                    alCommandList.Add((int)SendCOM.oStrobeOn);
                    DisplayData(MessageType.Standard, "Alarm toggle ON.");
                    if (Properties.Settings.Default.AlarmSimulate == true) DisplayData(MessageType.Standard, "Alarm system simulate ONLY!");
                }
            }
            else
            {
                lblAlarmActive.Invoke(new EventHandler(delegate
                {
                    lblAlarmActive.Text = "No";
                    lblAlarmActive.ForeColor = Color.Black;
                }));
                AlarmActive = false;
                alCommandList.Add((int)SendCOM.oKeyLEDOff);
                alCommandList.Add((int)SendCOM.oStrobeOff);
                alCommandList.Add((int)SendCOM.oRedLEDOff);
                alCommandList.Add((int)SendCOM.oBuzzerOff);
                lblValues[7].Invoke(new EventHandler(delegate { lblValues[7].Text = "No"; }));
                AlarmTriggered = false;
                AlarmTimer = -1;
                alarmTimer.Enabled = false;
                alarmResetTimer.Enabled = false;
                DisplayData(MessageType.Standard, "Alarm toggle OFF.");
            }
        }
        #endregion

        #region Log File Handling
        public void LogFile(string LogText, bool alarm)
        {
            string logfilename = null;
            if (alarm == false) logfilename = Properties.Settings.Default.FileNameLog;
            else logfilename = Properties.Settings.Default.FileNameAlarm;

            StreamWriter log;

            if (!File.Exists(logfilename))
                log = new StreamWriter(logfilename);
            else
                log = File.AppendText(logfilename);

            log.WriteLine(Convert.ToString(DateTime.Now) + " : " + LogText);
            log.Close();
        }
        #endregion

        #region Outlet Handler
        public void Outlet(bool stat)
        {
            switch (stat)
            {
                case true:
                    alCommandList.Add((int)SendCOM.oOutletOn);
                    break;
                case false:
                    alCommandList.Add((int)SendCOM.oOutletOff);
                    break;
            }
        }
        #endregion

        public void StartPrograms()
        {
            Process.Start(Properties.Settings.Default.App1);
            Process.Start(Properties.Settings.Default.App2);
        }

        public void DoClosePort()
        {
            new Thread((ThreadStart)delegate
            {
                ClosePort(0);
                Thread.Sleep(2000);
                ClosePort(1);
                Thread.Sleep(2000);
                ClosePort(2);
                Thread.Sleep(2000);
                ClosePort(3);
            }).Start();
        }
    }
}
