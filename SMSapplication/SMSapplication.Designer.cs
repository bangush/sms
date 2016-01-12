namespace SMSapplication
{
    partial class SMSapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSapplication));
            this.tabSMSapplication = new System.Windows.Forms.TabControl();
            this.tbListNumber = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoaSo = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPortSettings = new System.Windows.Forms.TabPage();
            this.gboPortSettings = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtWriteTimeOut = new System.Windows.Forms.TextBox();
            this.txtReadTimeOut = new System.Windows.Forms.TextBox();
            this.cboParityBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSendSMS = new System.Windows.Forms.TabPage();
            this.gboSendSMS = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSIM = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tbReadSMS = new System.Windows.Forms.TabPage();
            this.gboReadSMS = new System.Windows.Forms.GroupBox();
            this.rbReadStoreUnSent = new System.Windows.Forms.RadioButton();
            this.rbReadStoreSent = new System.Windows.Forms.RadioButton();
            this.rbReadUnRead = new System.Windows.Forms.RadioButton();
            this.rbReadAll = new System.Windows.Forms.RadioButton();
            this.btnReadSMS = new System.Windows.Forms.Button();
            this.lvwMessages = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSentTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDeleteSMS = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCountSMS = new System.Windows.Forms.Button();
            this.txtCountSMS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gboDeleteSMS = new System.Windows.Forms.GroupBox();
            this.rbDeleteReadSMS = new System.Windows.Forms.RadioButton();
            this.btnDeleteSMS = new System.Windows.Forms.Button();
            this.rbDeleteAllSMS = new System.Windows.Forms.RadioButton();
            this.gboConnectionStatus = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.opfFileExcel = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabSMSapplication.SuspendLayout();
            this.tbListNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.tbPortSettings.SuspendLayout();
            this.gboPortSettings.SuspendLayout();
            this.tbSendSMS.SuspendLayout();
            this.gboSendSMS.SuspendLayout();
            this.tbReadSMS.SuspendLayout();
            this.gboReadSMS.SuspendLayout();
            this.tbDeleteSMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboDeleteSMS.SuspendLayout();
            this.gboConnectionStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSMSapplication
            // 
            this.tabSMSapplication.Controls.Add(this.tbListNumber);
            this.tabSMSapplication.Controls.Add(this.tbPortSettings);
            this.tabSMSapplication.Controls.Add(this.tbSendSMS);
            this.tabSMSapplication.Controls.Add(this.tbReadSMS);
            this.tabSMSapplication.Controls.Add(this.tbDeleteSMS);
            this.tabSMSapplication.Location = new System.Drawing.Point(10, 109);
            this.tabSMSapplication.Name = "tabSMSapplication";
            this.tabSMSapplication.SelectedIndex = 0;
            this.tabSMSapplication.Size = new System.Drawing.Size(524, 387);
            this.tabSMSapplication.TabIndex = 0;
            // 
            // tbListNumber
            // 
            this.tbListNumber.Controls.Add(this.label11);
            this.tbListNumber.Controls.Add(this.btnThem);
            this.tbListNumber.Controls.Add(this.btnXoaSo);
            this.tbListNumber.Controls.Add(this.btnSaveFile);
            this.tbListNumber.Controls.Add(this.btnOpenFile);
            this.tbListNumber.Controls.Add(this.dgvPhoneList);
            this.tbListNumber.Location = new System.Drawing.Point(4, 22);
            this.tbListNumber.Name = "tbListNumber";
            this.tbListNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tbListNumber.Size = new System.Drawing.Size(516, 361);
            this.tbListNumber.TabIndex = 4;
            this.tbListNumber.Text = "List Send";
            this.tbListNumber.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(264, 321);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm số";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoaSo
            // 
            this.btnXoaSo.Location = new System.Drawing.Point(177, 321);
            this.btnXoaSo.Name = "btnXoaSo";
            this.btnXoaSo.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSo.TabIndex = 3;
            this.btnXoaSo.Text = "Xóa số";
            this.btnXoaSo.UseVisualStyleBackColor = true;
            this.btnXoaSo.Click += new System.EventHandler(this.btnXoaSo_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(93, 321);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save ra file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(8, 321);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Mở file excel";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.AllowUserToAddRows = false;
            this.dgvPhoneList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhoneList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colSDT});
            this.dgvPhoneList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPhoneList.Location = new System.Drawing.Point(0, 0);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.Size = new System.Drawing.Size(516, 306);
            this.dgvPhoneList.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colSDT
            // 
            this.colSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            // 
            // tbPortSettings
            // 
            this.tbPortSettings.Controls.Add(this.gboPortSettings);
            this.tbPortSettings.Location = new System.Drawing.Point(4, 22);
            this.tbPortSettings.Name = "tbPortSettings";
            this.tbPortSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbPortSettings.Size = new System.Drawing.Size(516, 361);
            this.tbPortSettings.TabIndex = 0;
            this.tbPortSettings.Text = "Port Settings";
            this.tbPortSettings.UseVisualStyleBackColor = true;
            // 
            // gboPortSettings
            // 
            this.gboPortSettings.Controls.Add(this.btnOK);
            this.gboPortSettings.Controls.Add(this.txtWriteTimeOut);
            this.gboPortSettings.Controls.Add(this.txtReadTimeOut);
            this.gboPortSettings.Controls.Add(this.cboParityBits);
            this.gboPortSettings.Controls.Add(this.cboStopBits);
            this.gboPortSettings.Controls.Add(this.cboDataBits);
            this.gboPortSettings.Controls.Add(this.cboBaudRate);
            this.gboPortSettings.Controls.Add(this.cboPortName);
            this.gboPortSettings.Controls.Add(this.label7);
            this.gboPortSettings.Controls.Add(this.label6);
            this.gboPortSettings.Controls.Add(this.label5);
            this.gboPortSettings.Controls.Add(this.label4);
            this.gboPortSettings.Controls.Add(this.label3);
            this.gboPortSettings.Controls.Add(this.label2);
            this.gboPortSettings.Controls.Add(this.label1);
            this.gboPortSettings.Location = new System.Drawing.Point(16, 17);
            this.gboPortSettings.Name = "gboPortSettings";
            this.gboPortSettings.Size = new System.Drawing.Size(469, 337);
            this.gboPortSettings.TabIndex = 0;
            this.gboPortSettings.TabStop = false;
            this.gboPortSettings.Text = "Port Settings";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "Connect";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtWriteTimeOut
            // 
            this.txtWriteTimeOut.Location = new System.Drawing.Point(219, 220);
            this.txtWriteTimeOut.MaxLength = 5;
            this.txtWriteTimeOut.Name = "txtWriteTimeOut";
            this.txtWriteTimeOut.Size = new System.Drawing.Size(121, 20);
            this.txtWriteTimeOut.TabIndex = 13;
            this.txtWriteTimeOut.Text = "300";
            // 
            // txtReadTimeOut
            // 
            this.txtReadTimeOut.Location = new System.Drawing.Point(219, 194);
            this.txtReadTimeOut.MaxLength = 5;
            this.txtReadTimeOut.Name = "txtReadTimeOut";
            this.txtReadTimeOut.Size = new System.Drawing.Size(121, 20);
            this.txtReadTimeOut.TabIndex = 12;
            this.txtReadTimeOut.Text = "300";
            // 
            // cboParityBits
            // 
            this.cboParityBits.FormattingEnabled = true;
            this.cboParityBits.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.cboParityBits.Location = new System.Drawing.Point(219, 167);
            this.cboParityBits.Name = "cboParityBits";
            this.cboParityBits.Size = new System.Drawing.Size(121, 21);
            this.cboParityBits.TabIndex = 11;
            this.cboParityBits.Text = "None";
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(219, 140);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 10;
            this.cboStopBits.Text = "1";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(219, 113);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 9;
            this.cboDataBits.Text = "8";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cboBaudRate.Location = new System.Drawing.Point(219, 85);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 8;
            this.cboBaudRate.Text = "9600";
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(219, 58);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(121, 21);
            this.cboPortName.TabIndex = 7;
            this.cboPortName.Text = "COM1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Write Timeout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Read Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name";
            // 
            // tbSendSMS
            // 
            this.tbSendSMS.Controls.Add(this.gboSendSMS);
            this.tbSendSMS.Location = new System.Drawing.Point(4, 22);
            this.tbSendSMS.Name = "tbSendSMS";
            this.tbSendSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbSendSMS.Size = new System.Drawing.Size(516, 361);
            this.tbSendSMS.TabIndex = 1;
            this.tbSendSMS.Text = "Send SMS";
            this.tbSendSMS.UseVisualStyleBackColor = true;
            // 
            // gboSendSMS
            // 
            this.gboSendSMS.Controls.Add(this.label8);
            this.gboSendSMS.Controls.Add(this.btnSendSMS);
            this.gboSendSMS.Controls.Add(this.label9);
            this.gboSendSMS.Controls.Add(this.txtSIM);
            this.gboSendSMS.Controls.Add(this.txtMessage);
            this.gboSendSMS.Location = new System.Drawing.Point(20, 6);
            this.gboSendSMS.Name = "gboSendSMS";
            this.gboSendSMS.Size = new System.Drawing.Size(479, 352);
            this.gboSendSMS.TabIndex = 43;
            this.gboSendSMS.TabStop = false;
            this.gboSendSMS.Text = "Send SMS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Message";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(198, 297);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(75, 25);
            this.btnSendSMS.TabIndex = 40;
            this.btnSendSMS.Text = "Send";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "SIM";
            // 
            // txtSIM
            // 
            this.txtSIM.Location = new System.Drawing.Point(185, 62);
            this.txtSIM.MaxLength = 15;
            this.txtSIM.Name = "txtSIM";
            this.txtSIM.Size = new System.Drawing.Size(118, 20);
            this.txtSIM.TabIndex = 41;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(75, 131);
            this.txtMessage.MaxLength = 160;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(323, 134);
            this.txtMessage.TabIndex = 39;
            // 
            // tbReadSMS
            // 
            this.tbReadSMS.Controls.Add(this.gboReadSMS);
            this.tbReadSMS.Location = new System.Drawing.Point(4, 22);
            this.tbReadSMS.Name = "tbReadSMS";
            this.tbReadSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbReadSMS.Size = new System.Drawing.Size(516, 361);
            this.tbReadSMS.TabIndex = 2;
            this.tbReadSMS.Text = "Read SMS";
            this.tbReadSMS.UseVisualStyleBackColor = true;
            // 
            // gboReadSMS
            // 
            this.gboReadSMS.Controls.Add(this.rbReadStoreUnSent);
            this.gboReadSMS.Controls.Add(this.rbReadStoreSent);
            this.gboReadSMS.Controls.Add(this.rbReadUnRead);
            this.gboReadSMS.Controls.Add(this.rbReadAll);
            this.gboReadSMS.Controls.Add(this.btnReadSMS);
            this.gboReadSMS.Controls.Add(this.lvwMessages);
            this.gboReadSMS.Location = new System.Drawing.Point(19, 10);
            this.gboReadSMS.Name = "gboReadSMS";
            this.gboReadSMS.Size = new System.Drawing.Size(481, 347);
            this.gboReadSMS.TabIndex = 43;
            this.gboReadSMS.TabStop = false;
            this.gboReadSMS.Text = "Read SMS";
            // 
            // rbReadStoreUnSent
            // 
            this.rbReadStoreUnSent.AutoSize = true;
            this.rbReadStoreUnSent.Location = new System.Drawing.Point(191, 53);
            this.rbReadStoreUnSent.Name = "rbReadStoreUnSent";
            this.rbReadStoreUnSent.Size = new System.Drawing.Size(144, 17);
            this.rbReadStoreUnSent.TabIndex = 48;
            this.rbReadStoreUnSent.Text = "Read Store UnSent SMS";
            this.rbReadStoreUnSent.UseVisualStyleBackColor = true;
            // 
            // rbReadStoreSent
            // 
            this.rbReadStoreSent.AutoSize = true;
            this.rbReadStoreSent.Location = new System.Drawing.Point(191, 30);
            this.rbReadStoreSent.Name = "rbReadStoreSent";
            this.rbReadStoreSent.Size = new System.Drawing.Size(130, 17);
            this.rbReadStoreSent.TabIndex = 47;
            this.rbReadStoreSent.Text = "Read Store Sent SMS";
            this.rbReadStoreSent.UseVisualStyleBackColor = true;
            // 
            // rbReadUnRead
            // 
            this.rbReadUnRead.AutoSize = true;
            this.rbReadUnRead.Location = new System.Drawing.Point(24, 53);
            this.rbReadUnRead.Name = "rbReadUnRead";
            this.rbReadUnRead.Size = new System.Drawing.Size(120, 17);
            this.rbReadUnRead.TabIndex = 45;
            this.rbReadUnRead.Text = "Read UnRead SMS";
            this.rbReadUnRead.UseVisualStyleBackColor = true;
            // 
            // rbReadAll
            // 
            this.rbReadAll.AutoSize = true;
            this.rbReadAll.Location = new System.Drawing.Point(24, 30);
            this.rbReadAll.Name = "rbReadAll";
            this.rbReadAll.Size = new System.Drawing.Size(91, 17);
            this.rbReadAll.TabIndex = 44;
            this.rbReadAll.Text = "Read All SMS";
            this.rbReadAll.UseVisualStyleBackColor = true;
            // 
            // btnReadSMS
            // 
            this.btnReadSMS.Location = new System.Drawing.Point(203, 300);
            this.btnReadSMS.Name = "btnReadSMS";
            this.btnReadSMS.Size = new System.Drawing.Size(75, 25);
            this.btnReadSMS.TabIndex = 41;
            this.btnReadSMS.Text = "Read";
            this.btnReadSMS.UseVisualStyleBackColor = true;
            this.btnReadSMS.Click += new System.EventHandler(this.btnReadSMS_Click);
            // 
            // lvwMessages
            // 
            this.lvwMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colSentTime,
            this.colSender,
            this.colMessage});
            this.lvwMessages.FullRowSelect = true;
            this.lvwMessages.Location = new System.Drawing.Point(16, 127);
            this.lvwMessages.MultiSelect = false;
            this.lvwMessages.Name = "lvwMessages";
            this.lvwMessages.Size = new System.Drawing.Size(448, 152);
            this.lvwMessages.TabIndex = 38;
            this.lvwMessages.UseCompatibleStateImageBehavior = false;
            this.lvwMessages.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            this.colIndex.Width = 43;
            // 
            // colSentTime
            // 
            this.colSentTime.Text = "SentTime";
            this.colSentTime.Width = 69;
            // 
            // colSender
            // 
            this.colSender.Text = "Sender";
            this.colSender.Width = 50;
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 275;
            // 
            // tbDeleteSMS
            // 
            this.tbDeleteSMS.Controls.Add(this.groupBox1);
            this.tbDeleteSMS.Controls.Add(this.gboDeleteSMS);
            this.tbDeleteSMS.Location = new System.Drawing.Point(4, 22);
            this.tbDeleteSMS.Name = "tbDeleteSMS";
            this.tbDeleteSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeleteSMS.Size = new System.Drawing.Size(516, 361);
            this.tbDeleteSMS.TabIndex = 3;
            this.tbDeleteSMS.Text = "Delete SMS";
            this.tbDeleteSMS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCountSMS);
            this.groupBox1.Controls.Add(this.txtCountSMS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(70, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 96);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count SMS";
            // 
            // btnCountSMS
            // 
            this.btnCountSMS.Location = new System.Drawing.Point(149, 55);
            this.btnCountSMS.Name = "btnCountSMS";
            this.btnCountSMS.Size = new System.Drawing.Size(75, 25);
            this.btnCountSMS.TabIndex = 46;
            this.btnCountSMS.Text = "Count";
            this.btnCountSMS.UseVisualStyleBackColor = true;
            this.btnCountSMS.Click += new System.EventHandler(this.btnCountSMS_Click);
            // 
            // txtCountSMS
            // 
            this.txtCountSMS.Location = new System.Drawing.Point(80, 26);
            this.txtCountSMS.Name = "txtCountSMS";
            this.txtCountSMS.ReadOnly = true;
            this.txtCountSMS.Size = new System.Drawing.Size(34, 20);
            this.txtCountSMS.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Count SMS";
            // 
            // gboDeleteSMS
            // 
            this.gboDeleteSMS.Controls.Add(this.rbDeleteReadSMS);
            this.gboDeleteSMS.Controls.Add(this.btnDeleteSMS);
            this.gboDeleteSMS.Controls.Add(this.rbDeleteAllSMS);
            this.gboDeleteSMS.Location = new System.Drawing.Point(70, 169);
            this.gboDeleteSMS.Name = "gboDeleteSMS";
            this.gboDeleteSMS.Size = new System.Drawing.Size(375, 153);
            this.gboDeleteSMS.TabIndex = 44;
            this.gboDeleteSMS.TabStop = false;
            this.gboDeleteSMS.Text = "Delete SMS";
            // 
            // rbDeleteReadSMS
            // 
            this.rbDeleteReadSMS.AutoSize = true;
            this.rbDeleteReadSMS.Checked = true;
            this.rbDeleteReadSMS.Location = new System.Drawing.Point(16, 58);
            this.rbDeleteReadSMS.Name = "rbDeleteReadSMS";
            this.rbDeleteReadSMS.Size = new System.Drawing.Size(114, 17);
            this.rbDeleteReadSMS.TabIndex = 45;
            this.rbDeleteReadSMS.TabStop = true;
            this.rbDeleteReadSMS.Text = "Delete Read SMS ";
            this.rbDeleteReadSMS.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSMS
            // 
            this.btnDeleteSMS.Location = new System.Drawing.Point(149, 111);
            this.btnDeleteSMS.Name = "btnDeleteSMS";
            this.btnDeleteSMS.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteSMS.TabIndex = 42;
            this.btnDeleteSMS.Text = "Delete";
            this.btnDeleteSMS.UseVisualStyleBackColor = true;
            this.btnDeleteSMS.Click += new System.EventHandler(this.btnDeleteSMS_Click);
            // 
            // rbDeleteAllSMS
            // 
            this.rbDeleteAllSMS.AutoSize = true;
            this.rbDeleteAllSMS.Location = new System.Drawing.Point(16, 26);
            this.rbDeleteAllSMS.Name = "rbDeleteAllSMS";
            this.rbDeleteAllSMS.Size = new System.Drawing.Size(96, 17);
            this.rbDeleteAllSMS.TabIndex = 43;
            this.rbDeleteAllSMS.Text = "Delete All SMS";
            this.rbDeleteAllSMS.UseVisualStyleBackColor = true;
            // 
            // gboConnectionStatus
            // 
            this.gboConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.gboConnectionStatus.Controls.Add(this.label23);
            this.gboConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.gboConnectionStatus.Controls.Add(this.btnDisconnect);
            this.gboConnectionStatus.Location = new System.Drawing.Point(93, 499);
            this.gboConnectionStatus.Name = "gboConnectionStatus";
            this.gboConnectionStatus.Size = new System.Drawing.Size(361, 56);
            this.gboConnectionStatus.TabIndex = 41;
            this.gboConnectionStatus.TabStop = false;
            this.gboConnectionStatus.Text = "Connection Status";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Connection Status :";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(25, 32);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.lblConnectionStatus.TabIndex = 36;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(259, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 25);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.statusBar1.Location = new System.Drawing.Point(0, 561);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(546, 20);
            this.statusBar1.TabIndex = 75;
            this.statusBar1.Text = "Message";
            // 
            // opfFileExcel
            // 
            this.opfFileExcel.FileName = "openFileDialog1";
            this.opfFileExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.opfFileExcel_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 101);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "label11";
            // 
            // SMSapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.gboConnectionStatus);
            this.Controls.Add(this.tabSMSapplication);
            this.MaximizeBox = false;
            this.Name = "SMSapplication";
            this.Text = "SMS Application";
            this.Load += new System.EventHandler(this.SMSapplication_Load);
            this.tabSMSapplication.ResumeLayout(false);
            this.tbListNumber.ResumeLayout(false);
            this.tbListNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.tbPortSettings.ResumeLayout(false);
            this.gboPortSettings.ResumeLayout(false);
            this.gboPortSettings.PerformLayout();
            this.tbSendSMS.ResumeLayout(false);
            this.gboSendSMS.ResumeLayout(false);
            this.gboSendSMS.PerformLayout();
            this.tbReadSMS.ResumeLayout(false);
            this.gboReadSMS.ResumeLayout(false);
            this.gboReadSMS.PerformLayout();
            this.tbDeleteSMS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboDeleteSMS.ResumeLayout(false);
            this.gboDeleteSMS.PerformLayout();
            this.gboConnectionStatus.ResumeLayout(false);
            this.gboConnectionStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSMSapplication;
        private System.Windows.Forms.TabPage tbPortSettings;
        private System.Windows.Forms.TabPage tbSendSMS;
        private System.Windows.Forms.TabPage tbReadSMS;
        private System.Windows.Forms.TabPage tbDeleteSMS;
        private System.Windows.Forms.GroupBox gboPortSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWriteTimeOut;
        private System.Windows.Forms.TextBox txtReadTimeOut;
        private System.Windows.Forms.ComboBox cboParityBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gboSendSMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSIM;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.GroupBox gboReadSMS;
        private System.Windows.Forms.Button btnReadSMS;
        private System.Windows.Forms.ListView lvwMessages;
        private System.Windows.Forms.ColumnHeader colSender;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.GroupBox gboConnectionStatus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnDeleteSMS;
        private System.Windows.Forms.GroupBox gboDeleteSMS;
        private System.Windows.Forms.RadioButton rbDeleteAllSMS;
        private System.Windows.Forms.RadioButton rbDeleteReadSMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCountSMS;
        private System.Windows.Forms.TextBox txtCountSMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.RadioButton rbReadUnRead;
        private System.Windows.Forms.RadioButton rbReadAll;
        private System.Windows.Forms.RadioButton rbReadStoreUnSent;
        private System.Windows.Forms.RadioButton rbReadStoreSent;
        private System.Windows.Forms.ColumnHeader colSentTime;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabPage tbListNumber;
        private System.Windows.Forms.DataGridView dgvPhoneList;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog opfFileExcel;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.Button btnXoaSo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
    }
}

