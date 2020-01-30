using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PCComm
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.ProgramName + " Settings";
            LoadValues();
            SetLabels();
        }

        private void SetLabels()
        {
            chkSysVoltLo_Image.Text = Properties.Alarms.Default.SysVoltLo_Text;
            chkSysVoltVeryLo_Image.Text = Properties.Alarms.Default.SysVoltVeryLo_Text;
            chkIntSysTempHi_Image.Text = Properties.Alarms.Default.SysIntTempHi_Text;
            chkIntSysTempVeryHi_Image.Text = Properties.Alarms.Default.SysIntTempVeryHi_Text;
            chkTamper_Image.Text = Properties.Alarms.Default.Tamper_Text;
            chkTimeout_Image.Text = Properties.Alarms.Default.Timeout_Text;
            chkFire_Image.Text = Properties.Alarms.Default.Fire_Text;
            chkAlarm_Image.Text = Properties.Alarms.Default.Alarm_Text;
            chkExtSysTempHi_Image.Text = Properties.Alarms.Default.SysExtTempHi_Text;
            chkExtSysTempVeryHi_Image.Text = Properties.Alarms.Default.SysExtTempVeryHi_Text;
            chkExtTempLo_Image.Text = Properties.Alarms.Default.ExtTempLo_Text;
            chkBatteryLo_Image.Text = Properties.Alarms.Default.BatteryLo_Text;
            chkBatteryVeryLo_Image.Text = Properties.Alarms.Default.BatteryVeryLo_Text;
            chkPowerOffline_Image.Text = Properties.Alarms.Default.PowerOffline_Text;

            label1.Text = Properties.Alarms.Default.SysVoltLo_Text;
            label2.Text = Properties.Alarms.Default.SysVoltVeryLo_Text;
            label3.Text = Properties.Alarms.Default.SysIntTempHi_Text;
            label4.Text = Properties.Alarms.Default.SysIntTempVeryHi_Text;
            label5.Text = Properties.Alarms.Default.Tamper_Text;
            label6.Text = Properties.Alarms.Default.Fire_Text;
            label7.Text = Properties.Alarms.Default.SysExtTempHi_Text;
            label8.Text = Properties.Alarms.Default.ExtTempLo_Text;
            label9.Text = Properties.Alarms.Default.BatteryLo_Text;
            label10.Text = Properties.Alarms.Default.BatteryVeryLo_Text;
            label42.Text = Properties.Alarms.Default.SysExtTempVeryHi_Text;

            label19.Text = Properties.Alarms.Default.SysVoltLo_Denom;
            label20.Text = Properties.Alarms.Default.SysVoltVeryLo_Denom;
            label21.Text = Properties.Alarms.Default.SysIntTempHi_Denom;
            label22.Text = Properties.Alarms.Default.SysIntTempVeryHi_Denom;
            label23.Text = Properties.Alarms.Default.Tamper_Denom;
            label24.Text = Properties.Alarms.Default.Fire_Denom;
            label25.Text = Properties.Alarms.Default.SysExtTempHi_Denom;
            label26.Text = Properties.Alarms.Default.ExtTempLo_Denom;
            label27.Text = Properties.Alarms.Default.BatteryLo_Denom;
            label28.Text = Properties.Alarms.Default.BatteryVeryLo_Denom;
            label41.Text = Properties.Alarms.Default.SysExtTempVeryHi_Denom;
        }

        private void LoadValues()
        {
            numSysVoltLo.Value = (decimal)Properties.Alarms.Default.SysVoltLo_Limit;
            numSysVoltVeryLo.Value = (decimal)Properties.Alarms.Default.SysVoltVeryLo_Limit;
            numIntSysTempHi.Value = (decimal)Properties.Alarms.Default.SysIntTempHi_Limit;
            numIntSysTempVeryHi.Value = (decimal)Properties.Alarms.Default.SysIntTempVeryHi_Limit;
            numTamper.Value = (decimal)Properties.Alarms.Default.Tamper_Limit;
            numFire.Value = (decimal)Properties.Alarms.Default.Fire_Limit;
            numExtSysTempHi.Value = (decimal)Properties.Alarms.Default.SysExtTempHi_Limit;
            numExtSysTempVeryHi.Value = (decimal)Properties.Alarms.Default.SysExtTempVeryHi_Limit;
            numExtTempLo.Value = (decimal)Properties.Alarms.Default.ExtTempLo_Limit;
            numBatteryLo.Value = (decimal)Properties.Alarms.Default.BatteryLo_Limit;
            numBatteryVeryLo.Value = (decimal)Properties.Alarms.Default.BatteryVeryLo_Limit;

            numAlarmResetTimer.Value = (decimal)Properties.Settings.Default.AlarmResetTimer;
            numErrorHysCount.Value = (decimal)Properties.Settings.Default.ErrorHysCount;
            numErrorHysTimer.Value = (decimal)Properties.Settings.Default.ErrorHysTimer;
            numErrorHysTimer2.Value = (decimal)Properties.Settings.Default.ErrorHysTimer2;
            numMailBlockTimer.Value = (decimal)Properties.Settings.Default.MailBlockTimer;
            numTimeoutTimer.Value = (decimal)Properties.Settings.Default.TimeoutTimer;
            numImageNr.Value = (decimal)Properties.Settings.Default.Image_Nr;
            txtLocation.Text = Properties.Settings.Default.Location;
            txtImageDir.Text = Properties.Settings.Default.Image_Dir;
            txtImageFile.Text = Properties.Settings.Default.Image_File;

            chkSysVoltLo_Image.Checked = Properties.Alarms.Default.SysVoltLo_Image;
            chkSysVoltVeryLo_Image.Checked = Properties.Alarms.Default.SysVoltVeryLo_Image;
            chkIntSysTempHi_Image.Checked = Properties.Alarms.Default.SysTempHi_Image;
            chkIntSysTempVeryHi_Image.Checked = Properties.Alarms.Default.SysTempVeryHi_Image;
            chkTamper_Image.Checked = Properties.Alarms.Default.Tamper_Image;
            chkTimeout_Image.Checked = Properties.Alarms.Default.Timeout_Image;
            chkFire_Image.Checked = Properties.Alarms.Default.Fire_Image;
            chkAlarm_Image.Checked = Properties.Alarms.Default.Alarm_Image;
            chkExtSysTempHi_Image.Checked = Properties.Alarms.Default.SysExtTempHi_Image;
            chkExtSysTempVeryHi_Image.Checked = Properties.Alarms.Default.SysExtTempVeryHi_Image;
            chkExtTempLo_Image.Checked = Properties.Alarms.Default.ExtTempLo_Image;
            chkBatteryLo_Image.Checked = Properties.Alarms.Default.BatteryLo_Image;
            chkBatteryVeryLo_Image.Checked = Properties.Alarms.Default.BatteryVeryLo_Image;
            chkPowerOffline_Image.Checked = Properties.Alarms.Default.PowerOffline_Image;

            numAlarmDelayIn.Value = Properties.Settings.Default.AlarmDelayIn;
            numAlarmDelayOut.Value = Properties.Settings.Default.AlarmDelayOut;
            chkAlSimu.Checked = Properties.Settings.Default.AlarmSimulate;
            chkEnableMail.Checked = Properties.Settings.Default.MailEnable;
            chkErrorLed.Checked = Properties.Settings.Default.ErrorLED;
            chkIgnoreCC.Checked = Properties.Settings.Default.MailIgnoreCC;
            chkTestMailImg.Checked = Properties.Settings.Default.TestMailImg;
            chkExtApps.Checked = Properties.Settings.Default.StartExtApps;
            txtMailTo.Text = Properties.Settings.Default.MailTO;
            txtMailCC.Text = Properties.Settings.Default.MailCC;
        }

        private void SaveSettings()
        {
            Properties.Alarms.Default.SysVoltLo_Limit = (double)numSysVoltLo.Value;
            Properties.Alarms.Default.SysVoltVeryLo_Limit = (double)numSysVoltVeryLo.Value;
            Properties.Alarms.Default.SysIntTempHi_Limit = (double)numIntSysTempHi.Value;
            Properties.Alarms.Default.SysIntTempVeryHi_Limit = (double)numIntSysTempVeryHi.Value;
            Properties.Alarms.Default.Tamper_Limit = (double)numTamper.Value;
            Properties.Alarms.Default.Fire_Limit = (double)numFire.Value;
            Properties.Alarms.Default.SysExtTempHi_Limit = (double)numExtSysTempHi.Value;
            Properties.Alarms.Default.SysExtTempVeryHi_Limit = (double)numExtSysTempVeryHi.Value;
            Properties.Alarms.Default.ExtTempLo_Limit = (double)numExtTempLo.Value;
            Properties.Alarms.Default.BatteryLo_Limit = (double)numBatteryLo.Value;
            Properties.Alarms.Default.BatteryVeryLo_Limit = (double)numBatteryVeryLo.Value;

            Properties.Settings.Default.AlarmResetTimer = (int)numAlarmResetTimer.Value;
            Properties.Settings.Default.ErrorHysCount = (int)numErrorHysCount.Value;
            Properties.Settings.Default.ErrorHysTimer = (int)numErrorHysTimer.Value;
            Properties.Settings.Default.ErrorHysTimer2 = (int)numErrorHysTimer2.Value;
            Properties.Settings.Default.MailBlockTimer = (int)numMailBlockTimer.Value;
            Properties.Settings.Default.TimeoutTimer = (int)numTimeoutTimer.Value;
            Properties.Settings.Default.Image_Nr = (int)numImageNr.Value;
            Properties.Settings.Default.Location = txtLocation.Text;
            Properties.Settings.Default.Image_Dir = txtImageDir.Text;
            Properties.Settings.Default.Image_File = txtImageFile.Text;

            Properties.Alarms.Default.SysVoltLo_Image = chkSysVoltLo_Image.Checked;
            Properties.Alarms.Default.SysVoltVeryLo_Image = chkSysVoltVeryLo_Image.Checked;
            Properties.Alarms.Default.SysTempHi_Image = chkIntSysTempHi_Image.Checked;
            Properties.Alarms.Default.SysTempVeryHi_Image = chkIntSysTempVeryHi_Image.Checked;
            Properties.Alarms.Default.Tamper_Image = chkTamper_Image.Checked;
            Properties.Alarms.Default.Timeout_Image = chkTimeout_Image.Checked;
            Properties.Alarms.Default.Fire_Image = chkFire_Image.Checked;
            Properties.Alarms.Default.Alarm_Image = chkAlarm_Image.Checked;
            Properties.Alarms.Default.SysExtTempHi_Image = chkExtSysTempHi_Image.Checked;
            Properties.Alarms.Default.SysExtTempVeryHi_Image = chkExtSysTempVeryHi_Image.Checked;
            Properties.Alarms.Default.ExtTempLo_Image = chkExtTempLo_Image.Checked;
            Properties.Alarms.Default.BatteryLo_Image = chkBatteryLo_Image.Checked;
            Properties.Alarms.Default.BatteryVeryLo_Image = chkBatteryVeryLo_Image.Checked;
            Properties.Alarms.Default.PowerOffline_Image = chkPowerOffline_Image.Checked;

            Properties.Settings.Default.AlarmDelayIn = numAlarmDelayIn.Value;
            Properties.Settings.Default.AlarmDelayOut = numAlarmDelayOut.Value;
            Properties.Settings.Default.AlarmSimulate = chkAlSimu.Checked;
            Properties.Settings.Default.MailEnable = chkEnableMail.Checked;
            Properties.Settings.Default.ErrorLED = chkErrorLed.Checked;
            Properties.Settings.Default.MailIgnoreCC = chkIgnoreCC.Checked;
            Properties.Settings.Default.TestMailImg = chkTestMailImg.Checked;
            Properties.Settings.Default.StartExtApps = chkExtApps.Checked;
            Properties.Settings.Default.MailTO = txtMailTo.Text;
            Properties.Settings.Default.MailCC = txtMailCC.Text;


            Properties.Settings.Default.Save();
            Properties.Alarms.Default.Save();

            toolStripStatusLabel1.Text = "Values saved, restart is required for some changes to take affect.";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
    }
}
