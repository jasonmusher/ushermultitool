using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using Microsoft.Win32;
using System.Collections;
using System.Diagnostics;


namespace Ushers_Multi_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Diagnostics.Process myBatProcess;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void configurationManagerActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\Actions.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void lastRebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\Last_Reboot.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void netBackupNSLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\NSLookup.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void lAPSUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\LAPS\LAPS2.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void manualScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\All.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void opNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\Opnet\OPNET_Script.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void crowdStrikeFalconSensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\FalconSensor\Falcon_Sensor_Install.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPUniversalDiscoveryAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\HP_Agent\UDAgentInstall.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void nDCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_NDC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void oPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_OPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hQSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_HQS.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void cHIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_CHI.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void cSMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_CSMC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void enterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Enterprise.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_HPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Web.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_HPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void enterpriseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Enterprise.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void essentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Essentials.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void configuratioManagerActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\Actions.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void lastRebootToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\Last_Reboot.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void netBackupNSLookupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\NSLookup.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void lAPSUtilityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\LAPS\LAPS2.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void manualScriptsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\All.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void opNetAppCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\Opnet\OPNET_Script.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void crowdStrikeFalconSensorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\FalconSensor\Falcon_Sensor_Install.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPUniversalDiscoveryAgentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\HP_Agent\UDAgentInstall.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void nDCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_NDC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void oPCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_OPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hQSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_HQS.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void cHIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_CHI.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void cSMCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\DNS_CSMC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void enterpriseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Enterprise.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPCToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_HPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void webToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Web.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void hPCToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_HPC.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void enterpriseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Enterprise.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2008_R2_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void enterpriseToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void standardToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Standard.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void datacenterToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Datacenter.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void essentialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\2012_R2_Essentials.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeSizeFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"TreeSizeFree\TreeSizeFree.exe");
        }

        private void configurationManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\SCCM.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void operationsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\SCOM.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void universalDiscoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"Installs\HP_Agent\UDAgentinstall.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\HPOM.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void netBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\NetBackup.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void endpointProtectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\SEP.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void installedSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\GetApp.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void systemTrayMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void wS2K8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\ToolsW2K8.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void wS2K12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"BatchFiles\ToolsW2K12.bat";
            myBatProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }
    }
}
