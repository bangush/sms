namespace SMSapplication
{
    partial class SMSapplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSapplicationForm));
            this.tabSMSapplication = new System.Windows.Forms.TabControl();
            this.tbListNumber = new System.Windows.Forms.TabPage();
            this.cbChonNhaMang = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoaSo = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnGui = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.opfFileExcel = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbNhieuNoiDung = new System.Windows.Forms.CheckBox();
            this.btnCaNhanHoa = new System.Windows.Forms.Button();
            this.lbSoKyTu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbThietBiCungMang = new System.Windows.Forms.CheckBox();
            this.btnTimThietBi = new System.Windows.Forms.Button();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.ctMenuCaNhanHoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmItemTen = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmItemSDT = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmItemThongTin1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmItemThongTin2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmItemThongTin3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chuyểnSangKhôngDấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThamSo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThamSo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThamSo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSMSapplication.SuspendLayout();
            this.tbListNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.tbPortSettings.SuspendLayout();
            this.gboPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.ctMenuCaNhanHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSMSapplication
            // 
            this.tabSMSapplication.Controls.Add(this.tbListNumber);
            this.tabSMSapplication.Controls.Add(this.tbPortSettings);
            this.tabSMSapplication.Location = new System.Drawing.Point(10, 107);
            this.tabSMSapplication.Name = "tabSMSapplication";
            this.tabSMSapplication.SelectedIndex = 0;
            this.tabSMSapplication.Size = new System.Drawing.Size(524, 387);
            this.tabSMSapplication.TabIndex = 0;
            // 
            // tbListNumber
            // 
            this.tbListNumber.Controls.Add(this.cbChonNhaMang);
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
            // cbChonNhaMang
            // 
            this.cbChonNhaMang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonNhaMang.FormattingEnabled = true;
            this.cbChonNhaMang.Location = new System.Drawing.Point(384, 324);
            this.cbChonNhaMang.Name = "cbChonNhaMang";
            this.cbChonNhaMang.Size = new System.Drawing.Size(126, 21);
            this.cbChonNhaMang.TabIndex = 5;
            this.cbChonNhaMang.SelectedIndexChanged += new System.EventHandler(this.cbChonNhaMang_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::SMSapplication.Properties.Resources._1454919989_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(283, 323);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm số gửi";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoaSo
            // 
            this.btnXoaSo.Image = global::SMSapplication.Properties.Resources._1454919868_f_cross_256;
            this.btnXoaSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSo.Location = new System.Drawing.Point(183, 323);
            this.btnXoaSo.Name = "btnXoaSo";
            this.btnXoaSo.Size = new System.Drawing.Size(97, 23);
            this.btnXoaSo.TabIndex = 3;
            this.btnXoaSo.Text = "Xóa số chọn";
            this.btnXoaSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSo.UseVisualStyleBackColor = true;
            this.btnXoaSo.Click += new System.EventHandler(this.btnXoaSo_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Image = global::SMSapplication.Properties.Resources._1454919763_document_save;
            this.btnSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFile.Location = new System.Drawing.Point(96, 323);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(84, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save ra file";
            this.btnSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::SMSapplication.Properties.Resources._1454919526_file_extension_xls;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(3, 323);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(91, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Mở file excel";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.AllowUserToAddRows = false;
            this.dgvPhoneList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhoneList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhoneList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon,
            this.colHoTen,
            this.colSDT,
            this.colThamSo1,
            this.colThamSo2,
            this.colThamSo3,
            this.colGui});
            this.dgvPhoneList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPhoneList.Location = new System.Drawing.Point(0, 0);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.RowHeadersVisible = false;
            this.dgvPhoneList.Size = new System.Drawing.Size(516, 306);
            this.dgvPhoneList.TabIndex = 0;
            // 
            // tbPortSettings
            // 
            this.tbPortSettings.Controls.Add(this.gboPortSettings);
            this.tbPortSettings.Location = new System.Drawing.Point(4, 22);
            this.tbPortSettings.Name = "tbPortSettings";
            this.tbPortSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbPortSettings.Size = new System.Drawing.Size(516, 361);
            this.tbPortSettings.TabIndex = 0;
            this.tbPortSettings.Text = "Cấu hình chung";
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
            this.cboPortName.Text = "PORT";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "ftyftyfyft";
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(454, 514);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 47);
            this.btnGui.TabIndex = 6;
            this.btnGui.Text = "Gửi tin";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.statusBar1.Location = new System.Drawing.Point(0, 574);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(864, 20);
            this.statusBar1.TabIndex = 75;
            this.statusBar1.Text = "Message";
            // 
            // opfFileExcel
            // 
            this.opfFileExcel.FileName = "openFileDialog1";
            this.opfFileExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.opfFileExcel_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbNhieuNoiDung);
            this.groupBox1.Controls.Add(this.btnCaNhanHoa);
            this.groupBox1.Controls.Add(this.lbSoKyTu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Location = new System.Drawing.Point(543, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 188);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung tin nhắn";
            // 
            // chbNhieuNoiDung
            // 
            this.chbNhieuNoiDung.AutoSize = true;
            this.chbNhieuNoiDung.Location = new System.Drawing.Point(9, 151);
            this.chbNhieuNoiDung.Name = "chbNhieuNoiDung";
            this.chbNhieuNoiDung.Size = new System.Drawing.Size(124, 17);
            this.chbNhieuNoiDung.TabIndex = 45;
            this.chbNhieuNoiDung.Text = "Chọn nhiều nội dung";
            this.chbNhieuNoiDung.UseVisualStyleBackColor = true;
            // 
            // btnCaNhanHoa
            // 
            this.btnCaNhanHoa.Image = global::SMSapplication.Properties.Resources._1455959346_message_add;
            this.btnCaNhanHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaNhanHoa.Location = new System.Drawing.Point(205, 139);
            this.btnCaNhanHoa.Name = "btnCaNhanHoa";
            this.btnCaNhanHoa.Size = new System.Drawing.Size(94, 23);
            this.btnCaNhanHoa.TabIndex = 44;
            this.btnCaNhanHoa.Text = "Cá nhân hóa";
            this.btnCaNhanHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaNhanHoa.UseVisualStyleBackColor = true;
            this.btnCaNhanHoa.Click += new System.EventHandler(this.btnCaNhanHoa_Click);
            // 
            // lbSoKyTu
            // 
            this.lbSoKyTu.Location = new System.Drawing.Point(36, 171);
            this.lbSoKyTu.Name = "lbSoKyTu";
            this.lbSoKyTu.Size = new System.Drawing.Size(26, 15);
            this.lbSoKyTu.TabIndex = 43;
            this.lbSoKyTu.Text = "160";
            this.lbSoKyTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "/160";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ký tự";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(133, 17);
            this.checkBox2.TabIndex = 40;
            this.checkBox2.Text = "Trộn nội dung tin nhắn";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 17);
            this.txtMessage.MaxLength = 160;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(295, 116);
            this.txtMessage.TabIndex = 39;
            this.txtMessage.Text = "test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbThietBiCungMang);
            this.groupBox2.Controls.Add(this.btnTimThietBi);
            this.groupBox2.Controls.Add(this.dgvDevice);
            this.groupBox2.Location = new System.Drawing.Point(540, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 252);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn thiết bị";
            // 
            // cbThietBiCungMang
            // 
            this.cbThietBiCungMang.AutoSize = true;
            this.cbThietBiCungMang.Location = new System.Drawing.Point(7, 229);
            this.cbThietBiCungMang.Name = "cbThietBiCungMang";
            this.cbThietBiCungMang.Size = new System.Drawing.Size(294, 17);
            this.cbThietBiCungMang.TabIndex = 2;
            this.cbThietBiCungMang.Text = "Tự động gửi từ thiết bị cùng mạng với số điện thoại nhận";
            this.cbThietBiCungMang.UseVisualStyleBackColor = true;
            // 
            // btnTimThietBi
            // 
            this.btnTimThietBi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimThietBi.Image = global::SMSapplication.Properties.Resources._1454919348_sync;
            this.btnTimThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimThietBi.Location = new System.Drawing.Point(214, 203);
            this.btnTimThietBi.Name = "btnTimThietBi";
            this.btnTimThietBi.Size = new System.Drawing.Size(88, 23);
            this.btnTimThietBi.TabIndex = 1;
            this.btnTimThietBi.Text = "Tìm thiết bị";
            this.btnTimThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimThietBi.UseVisualStyleBackColor = true;
            this.btnTimThietBi.Click += new System.EventHandler(this.btnTimThietBi_Click);
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDevice.Location = new System.Drawing.Point(7, 19);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.Size = new System.Drawing.Size(295, 176);
            this.dgvDevice.TabIndex = 0;
            this.dgvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevice_CellClick);
            // 
            // ctMenuCaNhanHoa
            // 
            this.ctMenuCaNhanHoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmItemTen,
            this.ctmItemSDT,
            this.ctmItemThongTin1,
            this.ctmItemThongTin2,
            this.ctmItemThongTin3,
            this.toolStripSeparator1,
            this.chuyểnSangKhôngDấuToolStripMenuItem});
            this.ctMenuCaNhanHoa.Name = "contextMenuStrip1";
            this.ctMenuCaNhanHoa.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctMenuCaNhanHoa.Size = new System.Drawing.Size(204, 142);
            // 
            // ctmItemTen
            // 
            this.ctmItemTen.Name = "ctmItemTen";
            this.ctmItemTen.Size = new System.Drawing.Size(203, 22);
            this.ctmItemTen.Text = "Tên";
            this.ctmItemTen.Click += new System.EventHandler(this.ctmItemTen_Click);
            // 
            // ctmItemSDT
            // 
            this.ctmItemSDT.Name = "ctmItemSDT";
            this.ctmItemSDT.Size = new System.Drawing.Size(203, 22);
            this.ctmItemSDT.Text = "Số điện thoại";
            this.ctmItemSDT.Click += new System.EventHandler(this.ctmItemSDT_Click);
            // 
            // ctmItemThongTin1
            // 
            this.ctmItemThongTin1.Name = "ctmItemThongTin1";
            this.ctmItemThongTin1.Size = new System.Drawing.Size(203, 22);
            this.ctmItemThongTin1.Text = "Thông tin #1";
            this.ctmItemThongTin1.Click += new System.EventHandler(this.ctmItemThongTin1_Click);
            // 
            // ctmItemThongTin2
            // 
            this.ctmItemThongTin2.Name = "ctmItemThongTin2";
            this.ctmItemThongTin2.Size = new System.Drawing.Size(203, 22);
            this.ctmItemThongTin2.Text = "Thông tin #2";
            this.ctmItemThongTin2.Click += new System.EventHandler(this.ctmItemThongTin2_Click);
            // 
            // ctmItemThongTin3
            // 
            this.ctmItemThongTin3.Name = "ctmItemThongTin3";
            this.ctmItemThongTin3.Size = new System.Drawing.Size(203, 22);
            this.ctmItemThongTin3.Text = "Thông tin #3";
            this.ctmItemThongTin3.Click += new System.EventHandler(this.ctmItemThongTin3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // chuyểnSangKhôngDấuToolStripMenuItem
            // 
            this.chuyểnSangKhôngDấuToolStripMenuItem.Name = "chuyểnSangKhôngDấuToolStripMenuItem";
            this.chuyểnSangKhôngDấuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.chuyểnSangKhôngDấuToolStripMenuItem.Text = "Chuyển sang không dấu";
            this.chuyểnSangKhôngDấuToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangKhôngDấuToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 101);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.Name = "colChon";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colSDT
            // 
            this.colSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            // 
            // colThamSo1
            // 
            this.colThamSo1.HeaderText = "#1";
            this.colThamSo1.Name = "colThamSo1";
            // 
            // colThamSo2
            // 
            this.colThamSo2.HeaderText = "#2";
            this.colThamSo2.Name = "colThamSo2";
            // 
            // colThamSo3
            // 
            this.colThamSo3.HeaderText = "#3";
            this.colThamSo3.Name = "colThamSo3";
            // 
            // colGui
            // 
            this.colGui.HeaderText = "Tình trạng";
            this.colGui.Name = "colGui";
            // 
            // SMSapplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 594);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.tabSMSapplication);
            this.MaximizeBox = false;
            this.Name = "SMSapplicationForm";
            this.Text = "7";
            this.Load += new System.EventHandler(this.SMSapplication_Load);
            this.tabSMSapplication.ResumeLayout(false);
            this.tbListNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.tbPortSettings.ResumeLayout(false);
            this.gboPortSettings.ResumeLayout(false);
            this.gboPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ctMenuCaNhanHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSMSapplication;
        private System.Windows.Forms.TabPage tbPortSettings;
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
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabPage tbListNumber;
        private System.Windows.Forms.DataGridView dgvPhoneList;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog opfFileExcel;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnXoaSo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Button btnTimThietBi;
        private System.Windows.Forms.CheckBox cbThietBiCungMang;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSoKyTu;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnCaNhanHoa;
        private System.Windows.Forms.ContextMenuStrip ctMenuCaNhanHoa;
        private System.Windows.Forms.ToolStripMenuItem ctmItemTen;
        private System.Windows.Forms.ToolStripMenuItem ctmItemSDT;
        private System.Windows.Forms.ToolStripMenuItem ctmItemThongTin1;
        private System.Windows.Forms.ToolStripMenuItem ctmItemThongTin2;
        private System.Windows.Forms.ToolStripMenuItem ctmItemThongTin3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangKhôngDấuToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbChonNhaMang;
        private System.Windows.Forms.CheckBox chbNhieuNoiDung;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThamSo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThamSo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThamSo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGui;
    }
}

