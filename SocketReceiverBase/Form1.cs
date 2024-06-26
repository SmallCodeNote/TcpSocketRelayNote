﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormStringCnvClass;

using tcpServer;
using tcpClient;
using ServerInfoUserControl;
using SourceInfoUserControl;
using PathSearchClass;

using UserControlPanelViewSet;


namespace SocketReceiverBase
{
    public partial class Form1 : Form
    {
        //===================
        // Constructor
        //===================
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

            tcpSrv_LockFunctionListener = new TcpSocketServer();
            tcpClt_JudgmentReporter = new TcpSocketClient();

            LockReleaseTime = DateTime.Now;
        }

        //===================
        // Member variable
        //===================
        string thisExeDirPath;

        TcpSocketServer tcpSrv_LockFunctionListener;
        TcpSocketClient tcpClt_JudgmentReporter;

        UserControlPanelView ServerInfoView;
        UserControlPanelView SourceInfoView;

        /// <summary>
        /// Free,Lock
        /// </summary>
        string LockFunctionStatus = "Free";

        public string LockSignalSourceName = "";
        public DateTime LockReleaseTime;
        public DateTime LockTime;
        public DateTime LastCheckTime;
        public bool Locked { get { return DateTime.Now < LockReleaseTime; } }

        public int PortNumber_LockFunctionSrv
        {
            get
            {
                int b = -1;
                if (!int.TryParse(textBox_PortNumber.Text, out b)) { b = -1; }
                return b;
            }
            set
            {
                textBox_PortNumber.Text = value.ToString();
            }
        }

        /// <summary>
        /// OK,NG,Error
        /// </summary>
        public string JudgmentResultString = "OK";

        /// <summary>
        /// true : OK , false : NG
        /// </summary>
        public bool JudgmentFlag
        {
            get
            {
                return button_JudgmentResult.BackColor == Color.YellowGreen;
            }
            set
            {
                if (value)
                {
                    button_JudgmentResult.BackColor = Color.YellowGreen;
                    JudgmentResultString = "OK";
                }
                else
                {
                    button_JudgmentResult.BackColor = Color.Red;
                    JudgmentResultString = "NG";
                }

                tcpSrv_LockFunctionListener.ResponceMessage = LockFunctionStatus + "\t" + JudgmentResultString;
            }
        }

        public string ClientName
        {
            get { return textBox_clientName.Text; }
            set {
                if (textBox_clientName.InvokeRequired) { textBox_clientName.Invoke(((Action)(() => ClientName = value))); }
                else { textBox_clientName.Text = value; }
            }
        }

        public string MessageOK
        {
            get { return textBox_MessageOK.Text; }
            set
            {
                if (textBox_MessageOK.InvokeRequired) { textBox_MessageOK.Invoke((Action)(() => MessageOK = value)); }
                else { textBox_MessageOK.Text = value; }
            }
        }

        public string MessageNG
        {
            get { return textBox_MessageNG.Text; }
            set
            {
                if (textBox_MessageNG.InvokeRequired) { textBox_MessageNG.Invoke((Action)(() => MessageNG = value)); }
                else { textBox_MessageNG.Text = value; }
            }
        }

        public string StatusNG
        {
            get { return textBox_StatusNG.Text; }
            set
            {
                if (textBox_StatusNG.InvokeRequired) { textBox_StatusNG.Invoke((Action)(() => StatusNG = value)); }
                else { textBox_StatusNG.Text = value; }
            }
        }

        public string ParameterNG
        {
            get { return textBox_ParameterNG.Text; }
            set
            {
                if (textBox_ParameterNG.InvokeRequired) { textBox_ParameterNG.Invoke((Action)(() => ParameterNG = value)); }
                else { textBox_ParameterNG.Text = value; }
            }
        }

        public string CheckStyleNG
        {
            get { return textBox_CheckStyleNG.Text; }
            set
            {
                if (textBox_CheckStyleNG.InvokeRequired) { textBox_CheckStyleNG.Invoke((Action)(() => CheckStyleNG = value)); }
                else { textBox_CheckStyleNG.Text = value; }
            }
        }

        public string StatusOK
        {
            get { return textBox_StatusOK.Text; }
            set
            {
                if (textBox_StatusOK.InvokeRequired) { textBox_StatusOK.Invoke((Action)(() => StatusOK = value)); }
                else { textBox_StatusOK.Text = value; }
            }
        }

        public string ParameterOK
        {
            get { return textBox_ParameterOK.Text; }
            set
            {
                if (textBox_ParameterOK.InvokeRequired) { textBox_ParameterOK.Invoke((Action)(() => ParameterOK = value)); }
                else { textBox_ParameterOK.Text = value; }
            }
        }

        public string CheckStyleOK
        {
            get { return textBox_CheckStyleOK.Text; }
            set
            {
                if (textBox_CheckStyleOK.InvokeRequired) { textBox_CheckStyleOK.Invoke((Action)(() => CheckStyleOK = value)); }
                else { textBox_CheckStyleOK.Text = value; }
            }
        }

        public int IntervalOK
        {
            get { return int.Parse(textBox_IntervalOK.Text); }
            set
            {
                if (textBox_IntervalOK.InvokeRequired) { textBox_IntervalOK.Invoke((Action)(() => IntervalOK = value)); }
                else { textBox_IntervalOK.Text = value.ToString(); }
            }
        }

        public int IntervalNG
        {
            get { return int.Parse(textBox_IntervalNG.Text); }
            set
            {
                if (textBox_IntervalNG.InvokeRequired) { textBox_IntervalNG.Invoke((Action)(() => IntervalNG = value)); }
                else { textBox_IntervalNG.Text = value.ToString(); }
            }
        }


        //===================
        // Member function
        //===================
        public void LockClient(double Minutes)
        {
            LockTime = DateTime.Now;
            LockReleaseTime = DateTime.Now.AddMinutes(Minutes);
        }

        private void LockStatusUpdate()
        {
            if (this.InvokeRequired) { this.Invoke((Action)(() => LockStatusUpdate())); }
            else
            {
                if (DateTime.Now > LockReleaseTime)
                {
                    label_LockedFrom.Text = "- Release -";
                    label_LockedTime.Text = "- Release -";
                    label_ResetTime.Text = "- Release -";
                    button_Lock.Text = "";
                    button_Lock.BackColor = Color.YellowGreen;
                }
                else
                {
                    label_LockedFrom.Text = LockSignalSourceName;
                    label_LockedTime.Text = LockTime.ToString("yyyy/MM/dd HH:mm:ss");
                    label_ResetTime.Text = LockReleaseTime.ToString("yyyy/MM/dd HH:mm:ss");
                    label_RemainingTime.Text = getElapsedTimeString(LockReleaseTime - DateTime.Now);

                    button_Lock.Text = "";
                    button_Lock.BackColor = Color.Gray;
                }
            }
        }

        public string getElapsedTimeString(TimeSpan elapsedTime)
        {
            if (elapsedTime.TotalDays >= 365) { return (elapsedTime.TotalDays / 365.2425).ToString("0") + " year"; }
            if (elapsedTime.TotalDays >= 30) { return (elapsedTime.TotalDays / 30.436875).ToString("0") + " month"; }
            if (elapsedTime.TotalDays >= 7) { return (elapsedTime.TotalDays / 7).ToString("0") + " week"; }
            if (elapsedTime.TotalDays >= 1) { return (elapsedTime.TotalDays / 7).ToString("0") + " day"; }
            if (elapsedTime.TotalHours >= 1) { return (elapsedTime.TotalHours).ToString("0") + " hour"; }
            if (elapsedTime.TotalMinutes >= 1) { return (elapsedTime.TotalMinutes).ToString("0") + " minute"; }
            if (elapsedTime.TotalSeconds >= 1) { return (elapsedTime.TotalSeconds).ToString("0") + " sec."; }
            return "now";
        }

        private void ButtonEnable(Button button, bool enable)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => ButtonEnable(button, enable)));
            }
            else
            {
                if (enable)
                {
                    button.Enabled = true;
                    button.BackColor = Color.GreenYellow;
                }
                else
                {
                    button.Enabled = false;
                    button.BackColor = Color.Transparent;
                }
            }
        }

        private void DebugOutFilenameReset(string targetDir)
        {
            string outFilename = "";
            try
            {
                if (targetDir == "{ExecutablePath}") { targetDir = Path.GetDirectoryName(Application.ExecutablePath); }
                if (Directory.Exists(targetDir))
                {
                    outFilename = Path.Combine(targetDir, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("yyyyMM"), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd_HHmm").Substring(0, 12) + "0.txt");
                    if (!Directory.Exists(Path.GetDirectoryName(outFilename))) { Directory.CreateDirectory(Path.GetDirectoryName(outFilename)); };

                    DefaultTraceListener dtl = (DefaultTraceListener)Debug.Listeners["Default"];
                    if (dtl.LogFileName != outFilename) { dtl.LogFileName = outFilename; };
                }
            }
            catch (Exception ex)
            {
                Debug.Write(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " filename " + outFilename);
                Debug.WriteLine(ex.ToString());
            }
        }

        private void DebugOutDirPathReset(string targetDir)
        {
            if (targetDir == "{ExecutablePath}") { targetDir = Path.GetDirectoryName(Application.ExecutablePath); }
            if (Directory.Exists(targetDir))
            {
                string outFilename = Path.Combine(targetDir, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("yyyyMM"), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd_HHmm").Substring(0, 12) + "0.txt");
                if (!Directory.Exists(Path.GetDirectoryName(outFilename))) { Directory.CreateDirectory(Path.GetDirectoryName(outFilename)); };

                DefaultTraceListener dtl = (DefaultTraceListener)Debug.Listeners["Default"];
                dtl.LogFileName = outFilename;
            }
            else if (textBox_DebugOutDirPath.Text.Length > 1)
            {
                MessageBox.Show("DebugOutDirPath Not Found.\r\n[" + textBox_DebugOutDirPath.Text + "]", "Directory Not Found.", MessageBoxButtons.OK);
            }
        }

        //ServerList Set================================

        private void EnableLoadServerListView()
        {
            ButtonEnable(button_LoadServerListView, true);
        }

        private void SendMessageForServers(string request)
        {
            foreach (var ctrl in ServerInfoView.Controls)
            {
                if (ctrl is ServerInfo) ((ServerInfo)ctrl).SendMessage(request);
            }
        }

        //SourceList Set================================
        private void EnableLoadSourceListView()
        {
            ButtonEnable(button_LoadSourceListView, true);
        }

        public void sendMessageOK()
        {
            string request =
                ClientName + "\t" +
                StatusOK + "\t" +
                MessageOK + "\t" +
                ParameterOK + "\t" +
                CheckStyleOK;

            SendMessageForServers(request);
        }

        public void sendMessageNG()
        {
            string request = "";

            if (Locked)
            {
                request =
                    ClientName + "\t" +
                    StatusOK + "\t" +
                    MessageNG + "\t" +
                    ParameterNG + "\t" +
                    CheckStyleNG;
            }
            else
            {
                request =
                    ClientName + "\t" +
                    StatusNG + "\t" +
                    MessageNG + "\t" +
                    ParameterNG + "\t" +
                    CheckStyleNG;
            }
            SendMessageForServers(request);
        }

        //===================
        // Event
        //===================
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename)) WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
            }

            timer_LockFunctionListenerQueueUpdate.Start();
            timer_SendMessage.Start();

            tcpSrv_LockFunctionListener.StartListening(PortNumber_LockFunctionSrv, "UTF8");

            ServerInfoView = new UserControlPanelView(panel_ServerListFrame, textBox_ServerList, new IPanelChildUserControl[1]{ new ServerInfo()});
            ServerInfoView.ControlContentsChanged = (Action)(() => EnableLoadServerListView());
            ServerInfoView.ChildUserControlsCreateFromTextBox();

            SourceInfoView = new UserControlPanelView(panel_SourceListFrame, textBox_SourceList, new IPanelChildUserControl[1] { new SourceInfo() });
            SourceInfoView.ControlContentsChanged = (Action)(() => EnableLoadSourceListView());
            SourceInfoView.ChildUserControlsCreateFromTextBox();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }
        }

        private void timer_LockFunctionListenerQueueUpdate_Tick(object sender, EventArgs e)
        {
            timer_LockFunctionListenerQueueUpdate.Stop();
            //============
            // New data check from Queue
            //============
            if ((tcpSrv_LockFunctionListener.LastReceiveTime - LastCheckTime).TotalSeconds > 0 && tcpSrv_LockFunctionListener.ReceivedSocketQueue.Count > 0)
            {
                string receivedSocketMessage = "";

                //============
                // ReadQueue 
                //============
                while (tcpSrv_LockFunctionListener.ReceivedSocketQueue.TryDequeue(out receivedSocketMessage))
                {
                    Debug.WriteLine(receivedSocketMessage);
                    if (receivedSocketMessage.IndexOf("Lock") >= 0)
                    {
                        string[] cols = receivedSocketMessage.Split('\t');

                        if (cols.Length > 2 && int.TryParse(cols[2], out int Minutes))
                        {
                            LockTime = DateTime.Now;
                            LockReleaseTime = DateTime.Now + new TimeSpan(0, Minutes, 0);
                        }

                        if (cols.Length > 3) LockSignalSourceName = cols[3];

                    }
                    else if (receivedSocketMessage.IndexOf("Release") >= 0)
                    {
                        LockReleaseTime = DateTime.Now;
                    }
                }
                LastCheckTime = DateTime.Now;
            }

            LockStatusUpdate();
            timer_LockFunctionListenerQueueUpdate.Start();
        }

        int timer_SendMessage_Count = 0;
        bool timer_SendMessage_LastJudgmentFlag = true;
        private void timer_SendMessage_Tick(object sender, EventArgs e)
        {
            timer_SendMessage.Stop();

            if (timer_SendMessage_LastJudgmentFlag != JudgmentFlag && !JudgmentFlag) timer_SendMessage_Count = -1;

            if (JudgmentFlag && timer_SendMessage_Count < 0)
            {
                sendMessageOK();
                if (!int.TryParse(textBox_IntervalOK.Text, out timer_SendMessage_Count)) { timer_SendMessage_Count = 300; }
            }
            else if (!JudgmentFlag && timer_SendMessage_Count < 0)
            {
                sendMessageNG();
                if (!int.TryParse(textBox_IntervalNG.Text, out timer_SendMessage_Count)) { timer_SendMessage_Count = 10; }
            }

            timer_SendMessage_Count--;
            timer_SendMessage.Start();
        }

        private void button_JudgmentResult_Click(object sender, EventArgs e)
        {
            JudgmentFlag = !JudgmentFlag;
        }

        private void button_Restrart_Click(object sender, EventArgs e)
        {
            tcpSrv_LockFunctionListener.StopListening();
            tcpSrv_LockFunctionListener.StartListening(PortNumber_LockFunctionSrv, "UTF8");
        }

        private void tabControl_ServerInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_ServerInfo.SelectedTab == tabPage_ServerView)
            {
                ServerInfoView.ChildUserControlsCreateFromTextBox();
            }
            else if (tabControl_ServerInfo.SelectedTab == tabPage_ServerList)
            {
                ServerInfoView.ChildUserControlsStoreToTextBox();
            }
        }

        private void button_AddServerList_Click(object sender, EventArgs e)
        {
            int ctrlIndex = ServerInfoView.Controls.Count;
            ServerInfoView.AddChildUserControl(new ServerInfo(ctrlIndex));
        }

        private void button_LoadServerListView_Click(object sender, EventArgs e)
        {
            ServerInfoView.ChildUserControlsStoreToTextBox();
            ButtonEnable(button_LoadServerListView, false);
        }

        private void tabControl_SourceInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_SourceInfo.SelectedTab == tabPage_SourceView)
            {
                SourceInfoView.ChildUserControlsCreateFromTextBox();
            }
            else if (tabControl_SourceInfo.SelectedTab == tabPage_SourceList)
            {
                SourceInfoView.ChildUserControlsStoreToTextBox();
            }
        }

        private void button_AddSourceList_Click(object sender, EventArgs e)
        {
            int ctrlIndex = SourceInfoView.Controls.Count;
            SourceInfoView.AddChildUserControl(new SourceInfo(ctrlIndex));
            SourceInfoView.ChildUserControlsStoreToTextBox();
        }

        private void button_LoadSourceListView_Click(object sender, EventArgs e)
        {
            SourceInfoView.ChildUserControlsStoreToTextBox();
            ButtonEnable(button_LoadSourceListView, false);
        }

        private void timer_FileCheck_Tick(object sender, EventArgs e)
        {
            foreach (var ctrl in SourceInfoView.Controls)
            {
                if (ctrl is SourceInfo)
                {
                    SourceInfo sourceInfo = (SourceInfo)ctrl;
                    string[] FilePaths = PathSearch.NewerFilesFromDateDirectory(sourceInfo.SaveDirPath, sourceInfo.LastCheckTime, searchPattern: "*.csv");

                    if (FilePaths.Length > 0)
                    {
                        Array.Sort(FilePaths);
                        sourceInfo.LastCheckTime = PathSearch.GetCreateTimeFromFilePath(FilePaths[FilePaths.Length - 1]);
                    }
                }
            }
        }

        private async void timer_DebugFilepathUpdate_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => DebugOutFilenameReset(textBox_DebugOutDirPath.Text));
        }

        private void button_DebugOutDirPathReset_Click(object sender, EventArgs e)
        {
            DebugOutDirPathReset(textBox_DebugOutDirPath.Text);
        }

        private void label_DebugOutDirPath_Key_Click(object sender, EventArgs e)
        {
            textBox_DebugOutDirPath.Text = label_DebugOutDirPath_Key.Text;
        }
    }
}
