﻿namespace SocketSignalServer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_portNumber = new System.Windows.Forms.TextBox();
            this.panel_StatusListFrame = new System.Windows.Forms.Panel();
            this.panel_StatusList = new System.Windows.Forms.Panel();
            this.tabControl_Top = new System.Windows.Forms.TabControl();
            this.tabPage_Status = new System.Windows.Forms.TabPage();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.textBox_DuplexActiveListCheckInterval = new System.Windows.Forms.TextBox();
            this.button_AddDuplexActiveList = new System.Windows.Forms.Button();
            this.tabControl_DuplexSystemView = new System.Windows.Forms.TabControl();
            this.tabPage_DuplexSystemView = new System.Windows.Forms.TabPage();
            this.panel_DuplexSystemViewFrame = new System.Windows.Forms.Panel();
            this.panel_DuplexSystemView = new System.Windows.Forms.Panel();
            this.tabPage_DuplexSystemText = new System.Windows.Forms.TabPage();
            this.textBox_DuplexActiveList = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_IntervalSelectorNow = new System.Windows.Forms.Label();
            this.label_IntervalSelector = new System.Windows.Forms.Label();
            this.checkBox_serverAutoStart = new System.Windows.Forms.CheckBox();
            this.button_LoadDuplexSystemView = new System.Windows.Forms.Button();
            this.button_SchedulerList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_SchedulerList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IntervalAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_NotifySetting = new System.Windows.Forms.TabPage();
            this.checkBox_voiceOffSwitch = new System.Windows.Forms.CheckBox();
            this.textBox_TimeoutCheckInterval = new System.Windows.Forms.TextBox();
            this.textBox_httpTimeout = new System.Windows.Forms.TextBox();
            this.textBox_ClearMessageParameter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_TimeoutMessageParameter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ClientListLoad = new System.Windows.Forms.Button();
            this.dataGridView_ClientList = new System.Windows.Forms.DataGridView();
            this.Column_ClientList_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_needCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimeOutMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddressListLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_AddressList = new System.Windows.Forms.DataGridView();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_AddressName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button_DebugOutDirPathReset = new System.Windows.Forms.Button();
            this.textBox_PostTime = new System.Windows.Forms.TextBox();
            this.button_getDataBaseFilePath = new System.Windows.Forms.Button();
            this.label_DebugOutDirPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DebugOutDirPath = new System.Windows.Forms.TextBox();
            this.textBox_DataBaseFilePath = new System.Windows.Forms.TextBox();
            this.button_LogReload = new System.Windows.Forms.Button();
            this.label_LogUpdateTime = new System.Windows.Forms.Label();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.tabPage_Test = new System.Windows.Forms.TabPage();
            this.button_BreakupDatabasefile = new System.Windows.Forms.Button();
            this.button_CreateDammyData = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_queueList = new System.Windows.Forms.TextBox();
            this.timer_CheckQueue = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton_Class = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton_VoiceSwitch = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_DebugFilepathUpdate = new System.Windows.Forms.Timer(this.components);
            this.timer_checkTimeout = new System.Windows.Forms.Timer(this.components);
            this.timer_DuplexActiveListUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel_StatusListFrame.SuspendLayout();
            this.tabControl_Top.SuspendLayout();
            this.tabPage_Status.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.tabControl_DuplexSystemView.SuspendLayout();
            this.tabPage_DuplexSystemView.SuspendLayout();
            this.panel_DuplexSystemViewFrame.SuspendLayout();
            this.tabPage_DuplexSystemText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SchedulerList)).BeginInit();
            this.tabPage_NotifySetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddressList)).BeginInit();
            this.tabPage_Log.SuspendLayout();
            this.tabPage_Test.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(4, 4);
            this.button_Start.Margin = new System.Windows.Forms.Padding(2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(86, 24);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "ServerStart";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // textBox_portNumber
            // 
            this.textBox_portNumber.Location = new System.Drawing.Point(38, 45);
            this.textBox_portNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_portNumber.Name = "textBox_portNumber";
            this.textBox_portNumber.Size = new System.Drawing.Size(52, 19);
            this.textBox_portNumber.TabIndex = 1;
            this.textBox_portNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_portNumber_KeyDown);
            // 
            // panel_StatusListFrame
            // 
            this.panel_StatusListFrame.AutoScroll = true;
            this.panel_StatusListFrame.Controls.Add(this.panel_StatusList);
            this.panel_StatusListFrame.Location = new System.Drawing.Point(4, 5);
            this.panel_StatusListFrame.Margin = new System.Windows.Forms.Padding(2);
            this.panel_StatusListFrame.Name = "panel_StatusListFrame";
            this.panel_StatusListFrame.Size = new System.Drawing.Size(522, 400);
            this.panel_StatusListFrame.TabIndex = 2;
            // 
            // panel_StatusList
            // 
            this.panel_StatusList.Location = new System.Drawing.Point(0, 0);
            this.panel_StatusList.Margin = new System.Windows.Forms.Padding(2);
            this.panel_StatusList.Name = "panel_StatusList";
            this.panel_StatusList.Size = new System.Drawing.Size(491, 80);
            this.panel_StatusList.TabIndex = 0;
            // 
            // tabControl_Top
            // 
            this.tabControl_Top.Controls.Add(this.tabPage_Status);
            this.tabControl_Top.Controls.Add(this.tabPage_Setting);
            this.tabControl_Top.Controls.Add(this.tabPage_NotifySetting);
            this.tabControl_Top.Controls.Add(this.tabPage_Log);
            this.tabControl_Top.Controls.Add(this.tabPage_Test);
            this.tabControl_Top.Controls.Add(this.tabPage1);
            this.tabControl_Top.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl_Top.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Top.Name = "tabControl_Top";
            this.tabControl_Top.SelectedIndex = 0;
            this.tabControl_Top.Size = new System.Drawing.Size(584, 450);
            this.tabControl_Top.TabIndex = 4;
            // 
            // tabPage_Status
            // 
            this.tabPage_Status.Controls.Add(this.panel_StatusListFrame);
            this.tabPage_Status.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Status.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Status.Name = "tabPage_Status";
            this.tabPage_Status.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Status.Size = new System.Drawing.Size(576, 424);
            this.tabPage_Status.TabIndex = 0;
            this.tabPage_Status.Text = "Status";
            this.tabPage_Status.UseVisualStyleBackColor = true;
            this.tabPage_Status.Enter += new System.EventHandler(this.tabPage_Status_Enter);
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.textBox_DuplexActiveListCheckInterval);
            this.tabPage_Setting.Controls.Add(this.button_AddDuplexActiveList);
            this.tabPage_Setting.Controls.Add(this.tabControl_DuplexSystemView);
            this.tabPage_Setting.Controls.Add(this.label12);
            this.tabPage_Setting.Controls.Add(this.label11);
            this.tabPage_Setting.Controls.Add(this.label_IntervalSelectorNow);
            this.tabPage_Setting.Controls.Add(this.label_IntervalSelector);
            this.tabPage_Setting.Controls.Add(this.checkBox_serverAutoStart);
            this.tabPage_Setting.Controls.Add(this.button_LoadDuplexSystemView);
            this.tabPage_Setting.Controls.Add(this.button_SchedulerList);
            this.tabPage_Setting.Controls.Add(this.label2);
            this.tabPage_Setting.Controls.Add(this.button_Start);
            this.tabPage_Setting.Controls.Add(this.dataGridView_SchedulerList);
            this.tabPage_Setting.Controls.Add(this.textBox_portNumber);
            this.tabPage_Setting.Controls.Add(this.label4);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Setting.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Setting.Size = new System.Drawing.Size(576, 424);
            this.tabPage_Setting.TabIndex = 2;
            this.tabPage_Setting.Text = "ServerSetting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // textBox_DuplexActiveListCheckInterval
            // 
            this.textBox_DuplexActiveListCheckInterval.Location = new System.Drawing.Point(222, 283);
            this.textBox_DuplexActiveListCheckInterval.Name = "textBox_DuplexActiveListCheckInterval";
            this.textBox_DuplexActiveListCheckInterval.Size = new System.Drawing.Size(35, 19);
            this.textBox_DuplexActiveListCheckInterval.TabIndex = 14;
            this.textBox_DuplexActiveListCheckInterval.Text = "10";
            this.textBox_DuplexActiveListCheckInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_DuplexActiveListCheckInterval.TextChanged += new System.EventHandler(this.textBox_DuplexActiveListCheckInterval_TextChanged);
            // 
            // button_AddDuplexActiveList
            // 
            this.button_AddDuplexActiveList.Location = new System.Drawing.Point(257, 283);
            this.button_AddDuplexActiveList.Name = "button_AddDuplexActiveList";
            this.button_AddDuplexActiveList.Size = new System.Drawing.Size(20, 20);
            this.button_AddDuplexActiveList.TabIndex = 13;
            this.button_AddDuplexActiveList.Text = "+";
            this.button_AddDuplexActiveList.UseVisualStyleBackColor = true;
            this.button_AddDuplexActiveList.Click += new System.EventHandler(this.button_AddDuplexActiveList_Click);
            // 
            // tabControl_DuplexSystemView
            // 
            this.tabControl_DuplexSystemView.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl_DuplexSystemView.Controls.Add(this.tabPage_DuplexSystemView);
            this.tabControl_DuplexSystemView.Controls.Add(this.tabPage_DuplexSystemText);
            this.tabControl_DuplexSystemView.Location = new System.Drawing.Point(5, 300);
            this.tabControl_DuplexSystemView.Multiline = true;
            this.tabControl_DuplexSystemView.Name = "tabControl_DuplexSystemView";
            this.tabControl_DuplexSystemView.SelectedIndex = 0;
            this.tabControl_DuplexSystemView.Size = new System.Drawing.Size(390, 119);
            this.tabControl_DuplexSystemView.TabIndex = 12;
            this.tabControl_DuplexSystemView.SelectedIndexChanged += new System.EventHandler(this.tabControl_DuplexSystemView_SelectedIndexChanged);
            // 
            // tabPage_DuplexSystemView
            // 
            this.tabPage_DuplexSystemView.Controls.Add(this.panel_DuplexSystemViewFrame);
            this.tabPage_DuplexSystemView.Location = new System.Drawing.Point(4, 4);
            this.tabPage_DuplexSystemView.Name = "tabPage_DuplexSystemView";
            this.tabPage_DuplexSystemView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DuplexSystemView.Size = new System.Drawing.Size(364, 111);
            this.tabPage_DuplexSystemView.TabIndex = 0;
            this.tabPage_DuplexSystemView.Text = "View";
            this.tabPage_DuplexSystemView.UseVisualStyleBackColor = true;
            // 
            // panel_DuplexSystemViewFrame
            // 
            this.panel_DuplexSystemViewFrame.AutoScroll = true;
            this.panel_DuplexSystemViewFrame.Controls.Add(this.panel_DuplexSystemView);
            this.panel_DuplexSystemViewFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DuplexSystemViewFrame.Location = new System.Drawing.Point(3, 3);
            this.panel_DuplexSystemViewFrame.Name = "panel_DuplexSystemViewFrame";
            this.panel_DuplexSystemViewFrame.Size = new System.Drawing.Size(358, 105);
            this.panel_DuplexSystemViewFrame.TabIndex = 0;
            // 
            // panel_DuplexSystemView
            // 
            this.panel_DuplexSystemView.Location = new System.Drawing.Point(0, 0);
            this.panel_DuplexSystemView.Name = "panel_DuplexSystemView";
            this.panel_DuplexSystemView.Size = new System.Drawing.Size(340, 55);
            this.panel_DuplexSystemView.TabIndex = 0;
            // 
            // tabPage_DuplexSystemText
            // 
            this.tabPage_DuplexSystemText.Controls.Add(this.textBox_DuplexActiveList);
            this.tabPage_DuplexSystemText.Location = new System.Drawing.Point(4, 4);
            this.tabPage_DuplexSystemText.Name = "tabPage_DuplexSystemText";
            this.tabPage_DuplexSystemText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DuplexSystemText.Size = new System.Drawing.Size(364, 111);
            this.tabPage_DuplexSystemText.TabIndex = 1;
            this.tabPage_DuplexSystemText.Text = "Text";
            this.tabPage_DuplexSystemText.UseVisualStyleBackColor = true;
            // 
            // textBox_DuplexActiveList
            // 
            this.textBox_DuplexActiveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DuplexActiveList.Location = new System.Drawing.Point(3, 3);
            this.textBox_DuplexActiveList.Multiline = true;
            this.textBox_DuplexActiveList.Name = "textBox_DuplexActiveList";
            this.textBox_DuplexActiveList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_DuplexActiveList.Size = new System.Drawing.Size(358, 105);
            this.textBox_DuplexActiveList.TabIndex = 10;
            this.textBox_DuplexActiveList.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "checkInterval(sec.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "DuplexActiveList";
            // 
            // label_IntervalSelectorNow
            // 
            this.label_IntervalSelectorNow.AutoSize = true;
            this.label_IntervalSelectorNow.Location = new System.Drawing.Point(211, 55);
            this.label_IntervalSelectorNow.Name = "label_IntervalSelectorNow";
            this.label_IntervalSelectorNow.Size = new System.Drawing.Size(11, 12);
            this.label_IntervalSelectorNow.TabIndex = 9;
            this.label_IntervalSelectorNow.Text = "...";
            // 
            // label_IntervalSelector
            // 
            this.label_IntervalSelector.Location = new System.Drawing.Point(152, 32);
            this.label_IntervalSelector.Name = "label_IntervalSelector";
            this.label_IntervalSelector.Size = new System.Drawing.Size(98, 51);
            this.label_IntervalSelector.TabIndex = 8;
            this.label_IntervalSelector.Text = "Interval = EveryDays / EveryHours / EverySeconds";
            this.label_IntervalSelector.Click += new System.EventHandler(this.label_IntervalSelector_Click);
            // 
            // checkBox_serverAutoStart
            // 
            this.checkBox_serverAutoStart.AutoSize = true;
            this.checkBox_serverAutoStart.Location = new System.Drawing.Point(5, 29);
            this.checkBox_serverAutoStart.Name = "checkBox_serverAutoStart";
            this.checkBox_serverAutoStart.Size = new System.Drawing.Size(105, 16);
            this.checkBox_serverAutoStart.TabIndex = 7;
            this.checkBox_serverAutoStart.Text = "serverAutoStart";
            this.checkBox_serverAutoStart.UseVisualStyleBackColor = true;
            // 
            // button_LoadDuplexSystemView
            // 
            this.button_LoadDuplexSystemView.Location = new System.Drawing.Point(275, 283);
            this.button_LoadDuplexSystemView.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadDuplexSystemView.Name = "button_LoadDuplexSystemView";
            this.button_LoadDuplexSystemView.Size = new System.Drawing.Size(42, 19);
            this.button_LoadDuplexSystemView.TabIndex = 6;
            this.button_LoadDuplexSystemView.Text = "Load";
            this.button_LoadDuplexSystemView.UseVisualStyleBackColor = true;
            this.button_LoadDuplexSystemView.Click += new System.EventHandler(this.button_LoadDuplexSystemView_Click);
            // 
            // button_SchedulerList
            // 
            this.button_SchedulerList.Location = new System.Drawing.Point(498, 66);
            this.button_SchedulerList.Margin = new System.Windows.Forms.Padding(2);
            this.button_SchedulerList.Name = "button_SchedulerList";
            this.button_SchedulerList.Size = new System.Drawing.Size(65, 19);
            this.button_SchedulerList.TabIndex = 6;
            this.button_SchedulerList.Text = "Load";
            this.button_SchedulerList.UseVisualStyleBackColor = true;
            this.button_SchedulerList.Click += new System.EventHandler(this.button_SchedulerList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // dataGridView_SchedulerList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SchedulerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SchedulerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SchedulerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column_Interval,
            this.Column_IntervalAt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_SchedulerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_SchedulerList.Location = new System.Drawing.Point(7, 85);
            this.dataGridView_SchedulerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_SchedulerList.Name = "dataGridView_SchedulerList";
            this.dataGridView_SchedulerList.RowTemplate.Height = 24;
            this.dataGridView_SchedulerList.Size = new System.Drawing.Size(556, 198);
            this.dataGridView_SchedulerList.TabIndex = 3;
            this.dataGridView_SchedulerList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SchedulerList_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "StatusName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column_Interval
            // 
            this.Column_Interval.HeaderText = "Interval";
            this.Column_Interval.Name = "Column_Interval";
            // 
            // Column_IntervalAt
            // 
            this.Column_IntervalAt.HeaderText = "At";
            this.Column_IntervalAt.Name = "Column_IntervalAt";
            this.Column_IntervalAt.Width = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "SchedulerList";
            // 
            // tabPage_NotifySetting
            // 
            this.tabPage_NotifySetting.Controls.Add(this.checkBox_voiceOffSwitch);
            this.tabPage_NotifySetting.Controls.Add(this.textBox_TimeoutCheckInterval);
            this.tabPage_NotifySetting.Controls.Add(this.textBox_httpTimeout);
            this.tabPage_NotifySetting.Controls.Add(this.textBox_ClearMessageParameter);
            this.tabPage_NotifySetting.Controls.Add(this.label9);
            this.tabPage_NotifySetting.Controls.Add(this.label8);
            this.tabPage_NotifySetting.Controls.Add(this.textBox_TimeoutMessageParameter);
            this.tabPage_NotifySetting.Controls.Add(this.label7);
            this.tabPage_NotifySetting.Controls.Add(this.button_ClientListLoad);
            this.tabPage_NotifySetting.Controls.Add(this.dataGridView_ClientList);
            this.tabPage_NotifySetting.Controls.Add(this.label10);
            this.tabPage_NotifySetting.Controls.Add(this.label3);
            this.tabPage_NotifySetting.Controls.Add(this.button_AddressListLoad);
            this.tabPage_NotifySetting.Controls.Add(this.label6);
            this.tabPage_NotifySetting.Controls.Add(this.dataGridView_AddressList);
            this.tabPage_NotifySetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NotifySetting.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_NotifySetting.Name = "tabPage_NotifySetting";
            this.tabPage_NotifySetting.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_NotifySetting.Size = new System.Drawing.Size(576, 424);
            this.tabPage_NotifySetting.TabIndex = 3;
            this.tabPage_NotifySetting.Text = "NotifySetting";
            this.tabPage_NotifySetting.UseVisualStyleBackColor = true;
            // 
            // checkBox_voiceOffSwitch
            // 
            this.checkBox_voiceOffSwitch.AutoSize = true;
            this.checkBox_voiceOffSwitch.Checked = true;
            this.checkBox_voiceOffSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_voiceOffSwitch.Location = new System.Drawing.Point(270, 255);
            this.checkBox_voiceOffSwitch.Name = "checkBox_voiceOffSwitch";
            this.checkBox_voiceOffSwitch.Size = new System.Drawing.Size(73, 16);
            this.checkBox_voiceOffSwitch.TabIndex = 13;
            this.checkBox_voiceOffSwitch.Text = "voiceOFF";
            this.checkBox_voiceOffSwitch.UseVisualStyleBackColor = true;
            this.checkBox_voiceOffSwitch.CheckedChanged += new System.EventHandler(this.checkBox_voiceOffSwitch_CheckedChanged);
            // 
            // textBox_TimeoutCheckInterval
            // 
            this.textBox_TimeoutCheckInterval.Location = new System.Drawing.Point(429, 2);
            this.textBox_TimeoutCheckInterval.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TimeoutCheckInterval.Name = "textBox_TimeoutCheckInterval";
            this.textBox_TimeoutCheckInterval.Size = new System.Drawing.Size(43, 19);
            this.textBox_TimeoutCheckInterval.TabIndex = 12;
            this.textBox_TimeoutCheckInterval.Text = "10";
            this.textBox_TimeoutCheckInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_TimeoutCheckInterval.TextChanged += new System.EventHandler(this.textBox_TimeoutCheckInterval_TextChanged);
            // 
            // textBox_httpTimeout
            // 
            this.textBox_httpTimeout.Location = new System.Drawing.Point(450, 274);
            this.textBox_httpTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_httpTimeout.Name = "textBox_httpTimeout";
            this.textBox_httpTimeout.Size = new System.Drawing.Size(82, 19);
            this.textBox_httpTimeout.TabIndex = 12;
            this.textBox_httpTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_httpTimeout.TextChanged += new System.EventHandler(this.textBox_httpTimeout_TextChanged);
            // 
            // textBox_ClearMessageParameter
            // 
            this.textBox_ClearMessageParameter.Location = new System.Drawing.Point(160, 218);
            this.textBox_ClearMessageParameter.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClearMessageParameter.Name = "textBox_ClearMessageParameter";
            this.textBox_ClearMessageParameter.Size = new System.Drawing.Size(408, 19);
            this.textBox_ClearMessageParameter.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "http Timeout(sec.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "ClearMessageParameter";
            // 
            // textBox_TimeoutMessageParameter
            // 
            this.textBox_TimeoutMessageParameter.Location = new System.Drawing.Point(160, 196);
            this.textBox_TimeoutMessageParameter.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TimeoutMessageParameter.Name = "textBox_TimeoutMessageParameter";
            this.textBox_TimeoutMessageParameter.Size = new System.Drawing.Size(408, 19);
            this.textBox_TimeoutMessageParameter.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "TimeoutMessageParameter";
            // 
            // button_ClientListLoad
            // 
            this.button_ClientListLoad.Location = new System.Drawing.Point(513, 2);
            this.button_ClientListLoad.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientListLoad.Name = "button_ClientListLoad";
            this.button_ClientListLoad.Size = new System.Drawing.Size(54, 18);
            this.button_ClientListLoad.TabIndex = 9;
            this.button_ClientListLoad.Text = "Load";
            this.button_ClientListLoad.UseVisualStyleBackColor = true;
            this.button_ClientListLoad.Click += new System.EventHandler(this.button_ClientListLoad_Click);
            // 
            // dataGridView_ClientList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClientList_Name,
            this.Column_Target,
            this.Column_needCheck,
            this.Column_Timeout,
            this.Column_TimeOutMessage});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ClientList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ClientList.Location = new System.Drawing.Point(11, 23);
            this.dataGridView_ClientList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_ClientList.Name = "dataGridView_ClientList";
            this.dataGridView_ClientList.RowTemplate.Height = 24;
            this.dataGridView_ClientList.Size = new System.Drawing.Size(556, 170);
            this.dataGridView_ClientList.TabIndex = 8;
            this.dataGridView_ClientList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ClientList_CellValueChanged);
            this.dataGridView_ClientList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_ClientList_CurrentCellDirtyStateChanged);
            // 
            // Column_ClientList_Name
            // 
            this.Column_ClientList_Name.HeaderText = "ClientName";
            this.Column_ClientList_Name.Name = "Column_ClientList_Name";
            // 
            // Column_Target
            // 
            this.Column_Target.HeaderText = "NoticeTarget";
            this.Column_Target.Name = "Column_Target";
            // 
            // Column_needCheck
            // 
            this.Column_needCheck.HeaderText = "check";
            this.Column_needCheck.Name = "Column_needCheck";
            this.Column_needCheck.Width = 50;
            // 
            // Column_Timeout
            // 
            this.Column_Timeout.HeaderText = "Timeout(sec.)";
            this.Column_Timeout.Name = "Column_Timeout";
            this.Column_Timeout.Width = 50;
            // 
            // Column_TimeOutMessage
            // 
            this.Column_TimeOutMessage.HeaderText = "TimeOutMessage";
            this.Column_TimeOutMessage.Name = "Column_TimeOutMessage";
            this.Column_TimeOutMessage.Width = 250;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "TimeoutCheckInterval (sec.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "ClientList";
            // 
            // button_AddressListLoad
            // 
            this.button_AddressListLoad.Location = new System.Drawing.Point(360, 254);
            this.button_AddressListLoad.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddressListLoad.Name = "button_AddressListLoad";
            this.button_AddressListLoad.Size = new System.Drawing.Size(54, 18);
            this.button_AddressListLoad.TabIndex = 3;
            this.button_AddressListLoad.Text = "Load";
            this.button_AddressListLoad.UseVisualStyleBackColor = true;
            this.button_AddressListLoad.Click += new System.EventHandler(this.button_AddressListLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "AddressList";
            // 
            // dataGridView_AddressList
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AddressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_AddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAddress,
            this.Column_AddressName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AddressList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_AddressList.Location = new System.Drawing.Point(11, 274);
            this.dataGridView_AddressList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_AddressList.Name = "dataGridView_AddressList";
            this.dataGridView_AddressList.RowTemplate.Height = 24;
            this.dataGridView_AddressList.Size = new System.Drawing.Size(404, 120);
            this.dataGridView_AddressList.TabIndex = 0;
            this.dataGridView_AddressList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridView_CellPainting_AddRowIndex);
            this.dataGridView_AddressList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AddressList_CellValueChanged);
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // Column_AddressName
            // 
            this.Column_AddressName.HeaderText = "Name";
            this.Column_AddressName.Name = "Column_AddressName";
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.Controls.Add(this.label5);
            this.tabPage_Log.Controls.Add(this.button_DebugOutDirPathReset);
            this.tabPage_Log.Controls.Add(this.textBox_PostTime);
            this.tabPage_Log.Controls.Add(this.button_getDataBaseFilePath);
            this.tabPage_Log.Controls.Add(this.label_DebugOutDirPath);
            this.tabPage_Log.Controls.Add(this.label1);
            this.tabPage_Log.Controls.Add(this.textBox_DebugOutDirPath);
            this.tabPage_Log.Controls.Add(this.textBox_DataBaseFilePath);
            this.tabPage_Log.Controls.Add(this.button_LogReload);
            this.tabPage_Log.Controls.Add(this.label_LogUpdateTime);
            this.tabPage_Log.Controls.Add(this.textBox_Log);
            this.tabPage_Log.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Log.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Log.Size = new System.Drawing.Size(576, 424);
            this.tabPage_Log.TabIndex = 1;
            this.tabPage_Log.Text = "DatabaseSetting";
            this.tabPage_Log.UseVisualStyleBackColor = true;
            this.tabPage_Log.Enter += new System.EventHandler(this.tabPage_Log_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "BackupTime(minute)";
            // 
            // button_DebugOutDirPathReset
            // 
            this.button_DebugOutDirPathReset.Location = new System.Drawing.Point(235, 74);
            this.button_DebugOutDirPathReset.Margin = new System.Windows.Forms.Padding(2);
            this.button_DebugOutDirPathReset.Name = "button_DebugOutDirPathReset";
            this.button_DebugOutDirPathReset.Size = new System.Drawing.Size(47, 19);
            this.button_DebugOutDirPathReset.TabIndex = 6;
            this.button_DebugOutDirPathReset.Text = "Reset";
            this.button_DebugOutDirPathReset.UseVisualStyleBackColor = true;
            this.button_DebugOutDirPathReset.Click += new System.EventHandler(this.button_DebugOutDirPathReset_Click);
            // 
            // textBox_PostTime
            // 
            this.textBox_PostTime.Location = new System.Drawing.Point(237, 11);
            this.textBox_PostTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PostTime.Name = "textBox_PostTime";
            this.textBox_PostTime.Size = new System.Drawing.Size(45, 19);
            this.textBox_PostTime.TabIndex = 9;
            this.textBox_PostTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_getDataBaseFilePath
            // 
            this.button_getDataBaseFilePath.Location = new System.Drawing.Point(254, 30);
            this.button_getDataBaseFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.button_getDataBaseFilePath.Name = "button_getDataBaseFilePath";
            this.button_getDataBaseFilePath.Size = new System.Drawing.Size(28, 23);
            this.button_getDataBaseFilePath.TabIndex = 12;
            this.button_getDataBaseFilePath.Text = "...";
            this.button_getDataBaseFilePath.UseVisualStyleBackColor = true;
            // 
            // label_DebugOutDirPath
            // 
            this.label_DebugOutDirPath.AutoSize = true;
            this.label_DebugOutDirPath.Location = new System.Drawing.Point(7, 60);
            this.label_DebugOutDirPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DebugOutDirPath.Name = "label_DebugOutDirPath";
            this.label_DebugOutDirPath.Size = new System.Drawing.Size(93, 12);
            this.label_DebugOutDirPath.TabIndex = 10;
            this.label_DebugOutDirPath.Text = "DebugOutDirPath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "DataBaseFilePath";
            // 
            // textBox_DebugOutDirPath
            // 
            this.textBox_DebugOutDirPath.Location = new System.Drawing.Point(9, 74);
            this.textBox_DebugOutDirPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DebugOutDirPath.Name = "textBox_DebugOutDirPath";
            this.textBox_DebugOutDirPath.Size = new System.Drawing.Size(222, 19);
            this.textBox_DebugOutDirPath.TabIndex = 7;
            // 
            // textBox_DataBaseFilePath
            // 
            this.textBox_DataBaseFilePath.Location = new System.Drawing.Point(9, 32);
            this.textBox_DataBaseFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DataBaseFilePath.Name = "textBox_DataBaseFilePath";
            this.textBox_DataBaseFilePath.Size = new System.Drawing.Size(243, 19);
            this.textBox_DataBaseFilePath.TabIndex = 8;
            // 
            // button_LogReload
            // 
            this.button_LogReload.Location = new System.Drawing.Point(516, 98);
            this.button_LogReload.Margin = new System.Windows.Forms.Padding(2);
            this.button_LogReload.Name = "button_LogReload";
            this.button_LogReload.Size = new System.Drawing.Size(56, 18);
            this.button_LogReload.TabIndex = 2;
            this.button_LogReload.Text = "Reload";
            this.button_LogReload.UseVisualStyleBackColor = true;
            this.button_LogReload.Click += new System.EventHandler(this.button_LogReload_Click);
            // 
            // label_LogUpdateTime
            // 
            this.label_LogUpdateTime.AutoSize = true;
            this.label_LogUpdateTime.Location = new System.Drawing.Point(7, 104);
            this.label_LogUpdateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LogUpdateTime.Name = "label_LogUpdateTime";
            this.label_LogUpdateTime.Size = new System.Drawing.Size(84, 12);
            this.label_LogUpdateTime.TabIndex = 1;
            this.label_LogUpdateTime.Text = "LogUpdateTime";
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(6, 118);
            this.textBox_Log.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Log.Size = new System.Drawing.Size(566, 291);
            this.textBox_Log.TabIndex = 0;
            this.textBox_Log.WordWrap = false;
            // 
            // tabPage_Test
            // 
            this.tabPage_Test.Controls.Add(this.button_BreakupDatabasefile);
            this.tabPage_Test.Controls.Add(this.button_CreateDammyData);
            this.tabPage_Test.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Test.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Test.Name = "tabPage_Test";
            this.tabPage_Test.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Test.Size = new System.Drawing.Size(576, 424);
            this.tabPage_Test.TabIndex = 4;
            this.tabPage_Test.Text = "Test";
            this.tabPage_Test.UseVisualStyleBackColor = true;
            // 
            // button_BreakupDatabasefile
            // 
            this.button_BreakupDatabasefile.Location = new System.Drawing.Point(15, 47);
            this.button_BreakupDatabasefile.Margin = new System.Windows.Forms.Padding(2);
            this.button_BreakupDatabasefile.Name = "button_BreakupDatabasefile";
            this.button_BreakupDatabasefile.Size = new System.Drawing.Size(120, 18);
            this.button_BreakupDatabasefile.TabIndex = 3;
            this.button_BreakupDatabasefile.Text = "BreakupDatabasefile";
            this.button_BreakupDatabasefile.UseVisualStyleBackColor = true;
            this.button_BreakupDatabasefile.Click += new System.EventHandler(this.button_BreakupDatabasefile_Click);
            // 
            // button_CreateDammyData
            // 
            this.button_CreateDammyData.Location = new System.Drawing.Point(15, 14);
            this.button_CreateDammyData.Margin = new System.Windows.Forms.Padding(2);
            this.button_CreateDammyData.Name = "button_CreateDammyData";
            this.button_CreateDammyData.Size = new System.Drawing.Size(120, 18);
            this.button_CreateDammyData.TabIndex = 2;
            this.button_CreateDammyData.Text = "CreateDammyData";
            this.button_CreateDammyData.UseVisualStyleBackColor = true;
            this.button_CreateDammyData.Click += new System.EventHandler(this.button_CreateDammyData_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_queueList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 424);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Queue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_queueList
            // 
            this.textBox_queueList.Location = new System.Drawing.Point(8, 6);
            this.textBox_queueList.Multiline = true;
            this.textBox_queueList.Name = "textBox_queueList";
            this.textBox_queueList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_queueList.Size = new System.Drawing.Size(562, 399);
            this.textBox_queueList.TabIndex = 0;
            this.textBox_queueList.WordWrap = false;
            // 
            // timer_CheckQueue
            // 
            this.timer_CheckQueue.Interval = 1000;
            this.timer_CheckQueue.Tick += new System.EventHandler(this.timer_CheckQueue_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_Class,
            this.toolStripDropDownButton_VoiceSwitch,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(593, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton_Class
            // 
            this.toolStripDropDownButton_Class.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_Class.Image = global::SocketSignalServer.Properties.Resources.Active048;
            this.toolStripDropDownButton_Class.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Class.Name = "toolStripDropDownButton_Class";
            this.toolStripDropDownButton_Class.ShowDropDownArrow = false;
            this.toolStripDropDownButton_Class.Size = new System.Drawing.Size(24, 24);
            this.toolStripDropDownButton_Class.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton_VoiceSwitch
            // 
            this.toolStripDropDownButton_VoiceSwitch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton_VoiceSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_VoiceSwitch.Image = global::SocketSignalServer.Properties.Resources.VoiceON048;
            this.toolStripDropDownButton_VoiceSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_VoiceSwitch.Name = "toolStripDropDownButton_VoiceSwitch";
            this.toolStripDropDownButton_VoiceSwitch.ShowDropDownArrow = false;
            this.toolStripDropDownButton_VoiceSwitch.Size = new System.Drawing.Size(24, 24);
            this.toolStripDropDownButton_VoiceSwitch.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton_VoiceSwitch.Click += new System.EventHandler(this.toolStripDropDownButton_VoiceSwitch_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 21);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 21);
            this.toolStripStatusLabel2.Text = "...";
            // 
            // timer_DebugFilepathUpdate
            // 
            this.timer_DebugFilepathUpdate.Interval = 1000;
            this.timer_DebugFilepathUpdate.Tick += new System.EventHandler(this.timer_DebugFilepathUpdate_Tick);
            // 
            // timer_checkTimeout
            // 
            this.timer_checkTimeout.Interval = 10000;
            this.timer_checkTimeout.Tick += new System.EventHandler(this.timer_checkTimeout_Tick);
            // 
            // timer_DuplexActiveListUpdate
            // 
            this.timer_DuplexActiveListUpdate.Interval = 10000;
            this.timer_DuplexActiveListUpdate.Tick += new System.EventHandler(this.timer_DuplexActiveListUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SocketRelayServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_StatusListFrame.ResumeLayout(false);
            this.tabControl_Top.ResumeLayout(false);
            this.tabPage_Status.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.tabPage_Setting.PerformLayout();
            this.tabControl_DuplexSystemView.ResumeLayout(false);
            this.tabPage_DuplexSystemView.ResumeLayout(false);
            this.panel_DuplexSystemViewFrame.ResumeLayout(false);
            this.tabPage_DuplexSystemText.ResumeLayout(false);
            this.tabPage_DuplexSystemText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SchedulerList)).EndInit();
            this.tabPage_NotifySetting.ResumeLayout(false);
            this.tabPage_NotifySetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddressList)).EndInit();
            this.tabPage_Log.ResumeLayout(false);
            this.tabPage_Log.PerformLayout();
            this.tabPage_Test.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_portNumber;
        private System.Windows.Forms.Panel panel_StatusListFrame;
        private System.Windows.Forms.Panel panel_StatusList;
        private System.Windows.Forms.TabControl tabControl_Top;
        private System.Windows.Forms.TabPage tabPage_Status;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.Timer timer_CheckQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView_SchedulerList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_NotifySetting;
        private System.Windows.Forms.DataGridView dataGridView_AddressList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_AddressName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.TabPage tabPage_Test;
        private System.Windows.Forms.Button button_BreakupDatabasefile;
        private System.Windows.Forms.Button button_CreateDammyData;
        private System.Windows.Forms.Label label_LogUpdateTime;
        private System.Windows.Forms.Button button_LogReload;
        private System.Windows.Forms.Button button_AddressListLoad;
        private System.Windows.Forms.Button button_SchedulerList;
        private System.Windows.Forms.Button button_ClientListLoad;
        private System.Windows.Forms.DataGridView dataGridView_ClientList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IntervalAt;
        private System.Windows.Forms.TextBox textBox_TimeoutMessageParameter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ClearMessageParameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_httpTimeout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClientList_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Target;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_needCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimeOutMessage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_queueList;
        private System.Windows.Forms.CheckBox checkBox_serverAutoStart;
        private System.Windows.Forms.CheckBox checkBox_voiceOffSwitch;
        private System.Windows.Forms.Label label_IntervalSelector;
        private System.Windows.Forms.Label label_IntervalSelectorNow;
        private System.Windows.Forms.Timer timer_DebugFilepathUpdate;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_VoiceSwitch;
        private System.Windows.Forms.Timer timer_checkTimeout;
        private System.Windows.Forms.TextBox textBox_TimeoutCheckInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_DebugOutDirPathReset;
        private System.Windows.Forms.TextBox textBox_PostTime;
        private System.Windows.Forms.Button button_getDataBaseFilePath;
        private System.Windows.Forms.Label label_DebugOutDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DebugOutDirPath;
        private System.Windows.Forms.TextBox textBox_DataBaseFilePath;
        private System.Windows.Forms.TextBox textBox_DuplexActiveList;
        private System.Windows.Forms.TabControl tabControl_DuplexSystemView;
        private System.Windows.Forms.TabPage tabPage_DuplexSystemView;
        private System.Windows.Forms.Panel panel_DuplexSystemViewFrame;
        private System.Windows.Forms.Panel panel_DuplexSystemView;
        private System.Windows.Forms.TabPage tabPage_DuplexSystemText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_AddDuplexActiveList;
        private System.Windows.Forms.Timer timer_DuplexActiveListUpdate;
        private System.Windows.Forms.Button button_LoadDuplexSystemView;
        private System.Windows.Forms.TextBox textBox_DuplexActiveListCheckInterval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Class;
    }
}

