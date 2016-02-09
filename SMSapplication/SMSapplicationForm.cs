/*
 * Created by: Syeda Anila Nusrat. 
 * Date: 1st August 2009
 * Time: 2:54 PM 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using SMSapplication.Classes;
using System.Xml;
namespace SMSapplication
{
    public partial class SMSapplicationForm : Form
    {
        // Excel provider
        private string Excel03ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        #region Constructor
        public SMSapplicationForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Variables
        // Port ket noi toi device 3g
        SerialPort port = new SerialPort();
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        List<SerialPort> listPortInitial = new List<SerialPort>();
        private string numberString;
        #endregion

        #region Private Methods

        #region Write StatusBar
        private void WriteStatusBar(string status)
        {
            try
            {
                statusBar1.Text = "Message: " + status;
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Private Events

        private void SMSapplication_Load(object sender, EventArgs e)
        {
            try
            {
                #region Display all available COM Ports

                foreach (COMPortInfo comPort in COMPortInfo.GetCOMPortsInfo())
                {
                    if (comPort.Description.Contains("PC UI Interface"))
                    {
                        this.cboPortName.Items.Add(comPort.Name);
                    }

                }

                #endregion

                //Remove tab pages
                this.tabSMSapplication.TabPages.Remove(tbListNumber);

                this.btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Open communication port 
                this.port = objclsSMS.OpenPort(this.cboPortName.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));

                if (this.port != null)
                {
                    this.gboPortSettings.Enabled = false;

                    //MessageBox.Show("Modem is connected at PORT " + this.cboPortName.Text);
                    this.statusBar1.Text = "Modem is connected at PORT " + this.cboPortName.Text;

                    //Add tab pages
                    this.tabSMSapplication.TabPages.Add(tbListNumber);

                    this.lblConnectionStatus.Text = "Connected at " + this.cboPortName.Text;
                    this.btnDisconnect.Enabled = true;

                }

                else
                {
                    //MessageBox.Show("Invalid port settings");
                    this.statusBar1.Text = "Invalid port settings";
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }

        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.gboPortSettings.Enabled = true;
                objclsSMS.ClosePort(this.port);

                //Remove tab pages
                this.tabSMSapplication.TabPages.Remove(tbListNumber);

                this.lblConnectionStatus.Text = "Not Connected";
                this.btnDisconnect.Enabled = false;

            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            int rowsCount = dgvPhoneList.Rows.Count;
            if (rowsCount != 0)
            {
                // Read phone number from Datagridview
                for (int i = 0; i < dgvPhoneList.Rows.Count; i++)
                {
                    //.............................................. Send SMS ....................................................
                    try
                    {

                        if (objclsSMS.sendMsg(this.port, dgvPhoneList.Rows[i].Cells[1].Value.ToString(), this.txtMessage.Text))
                        {
                            this.statusBar1.Text = "Message " + i + " has sent successfully";
                            dgvPhoneList.Rows[i].Cells[3].Value = "Gửi thành công";
                        }
                        else
                        {
                            //MessageBox.Show("Failed to send message");
                            this.statusBar1.Text = "Failed to send message";
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorLog(ex.Message);
                    }
                    dgvPhoneList.Refresh();
                    Thread.Sleep(7000);
                }
            }



        }

        #endregion

        #region Error Log
        public void ErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                WriteStatusBar(Message);

                string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
                //string sPathName = @"E:\";
                string sPathName = @"SMSapplicationErrorLog_";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();

                string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

                sw = new StreamWriter(sPathName + sErrorTime + ".txt", true);

                sw.WriteLine(sLogFormat + Message);
                sw.Flush();

            }
            catch (Exception ex)
            {
                //ErrorLog(ex.ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw.Close();
                }
            }

        }
        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            opfFileExcel.ShowDialog();

        }

        private void opfFileExcel_FileOk(object sender, CancelEventArgs e)
        {
            dgvPhoneList.Columns.Clear();
            string filePath = opfFileExcel.FileName;
            string extension = Path.GetExtension(filePath);
            //string header = rbHeaderYes.Checked ? "YES" : "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, "YES");
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        dgvPhoneList.DataSource = dt;
                    }
                }
            }

            // Checkbox chon vao gridview
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "chbChon";
            dgvCmb.HeaderText = "Chọn";
            dgvPhoneList.Columns.Add(dgvCmb);

            // Textbox da gui vao gridview
            DataGridViewTextBoxColumn dgvTv = new DataGridViewTextBoxColumn();
            dgvTv.Name = "tvGui";
            dgvTv.HeaderText = "Gửi";
            dgvPhoneList.Columns.Add(dgvTv);

            dgvPhoneList.Refresh();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveFile(dgvPhoneList, sfd.FileName);
            }
        }

        // Save tu gridview ra file excel
        private void SaveFile(DataGridView dGV, string filename)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            try
            {
                // Export title
                for (int t = 0; t < dGV.ColumnCount; t++)
                {
                    if (!"chbChon".Equals(dGV.Columns[t].Name))
                    {
                        xlWorkSheet.Cells[1, t + 1].Value = dGV.Columns[t].Name;
                    }

                }

                // Export data
                for (i = 0; i < dGV.RowCount; i++)
                {
                    for (j = 0; j < dGV.ColumnCount; j++)
                    {
                        DataGridViewCell cell = dGV[j, i];
                        xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                    }
                }

                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Đã tạo file excel được lưu tại " + filename);
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("File đang được mở, yêu cầu đóng file");
            }

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        // Xoa nhung so da chon
        private void btnXoaSo_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0; i < dgvPhoneList.Rows.Count; i++)
            {
                row = dgvPhoneList.Rows[i];

                if (Convert.ToBoolean(row.Cells[2].Value) == true)
                {
                    dgvPhoneList.Rows.Remove(row);
                    i--;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddNumberForm formAddNumber = new AddNumberForm();
            formAddNumber.ShowDialog();

            label11.Text = "phone number: " + formAddNumber.rtbNumberAdd.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string copSim = objclsSMS.readSimCode(this.port);
            MessageBox.Show(copSim);
        }

        private void btnTimThietBi_Click(object sender, EventArgs e)
        {
            dgvDevice.Rows.Clear();
            dgvDevice.ColumnCount = 4;
            dgvDevice.Columns[0].Name = "Cổng";
            dgvDevice.Columns[1].Name = "Mạng";
            dgvDevice.Columns[2].Name = "Độ trễ";
            dgvDevice.Columns[3].Name = "Giới hạn";

            foreach (COMPortInfo comPort in COMPortInfo.GetCOMPortsInfo())
            {
                if (comPort.Description.Contains("PC UI Interface"))
                {
                    string portName = comPort.Name;
                    //Open communication port 
                    SerialPort sPort = objclsSMS.OpenPort(portName, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));
                    if (sPort != null)
                    {

                        string copSim = objclsSMS.readSimCode(sPort);
                        if ("\"45201\"".Equals(copSim))
                        {
                            string[] row = new string[] { portName, "Mobifone", "0", "0" };
                            dgvDevice.Rows.Add(row);
                        }
                        if ("\"45202\"".Equals(copSim))
                        {
                            string[] row = new string[] { portName, "Vinaphone", "0", "0" };
                            dgvDevice.Rows.Add(row);
                        }
                        if ("\"45204\"".Equals(copSim))
                        {
                            string[] row = new string[] { portName, "Viettel", "0", "0" };
                            dgvDevice.Rows.Add(row);
                        }


                    }

                    else
                    {
                        //MessageBox.Show("Invalid port settings");
                        this.statusBar1.Text = "Invalid port settings";
                    }
                    objclsSMS.ClosePort(sPort);
                }
                dgvDevice.Refresh();
            }

            DataGridViewButtonColumn btnSetup = new DataGridViewButtonColumn();
            dgvDevice.Columns.Add(btnSetup);
            btnSetup.Text = "Cài đặt";
            btnSetup.Name = "";
            btnSetup.UseColumnTextForButtonValue = true;
        }

        private void dgvDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cai dat cau hinh
            if (e.ColumnIndex == 4)
            {
                int index = e.RowIndex;
                SettingDevice settingDevice = new SettingDevice();
                settingDevice.DeviceName = dgvDevice.Rows[index].Cells[0].Value.ToString();
                settingDevice.Cops = dgvDevice.Rows[index].Cells[1].Value.ToString();
                settingDevice.DelayTime = Int32.Parse(dgvDevice.Rows[index].Cells[2].Value.ToString());
                settingDevice.Limit = Int32.Parse(dgvDevice.Rows[index].Cells[3].Value.ToString());

                SetupDeviceForm deviceSetupForm = new SetupDeviceForm();
                deviceSetupForm.dataSetup = settingDevice;
                deviceSetupForm.ShowDialog();

                dgvDevice.Rows[index].Cells[1].Value = deviceSetupForm.cbMangDiDong.SelectedValue.ToString();
                dgvDevice.Rows[index].Cells[2].Value = deviceSetupForm.cbDoTre.SelectedValue.ToString();
                dgvDevice.Rows[index].Cells[3].Value = deviceSetupForm.cbGioiHan.SelectedValue.ToString();

                dgvDevice.Refresh();

            }

            // Luu cau hinh dung xml
            string envPath = Application.StartupPath;
            // Create a new file in C:\\ dir
            WriteXML(envPath);
            ReadXML(envPath);
        }

        private static void ReadXML(string path)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);

            XmlNodeList NodeList = xdoc.DocumentElement.ChildNodes;
            foreach (XmlNode node in NodeList)
            {
               string first = node.FirstChild.Value;
               MessageBox.Show(first);
            }
        }

        private void WriteXML(string path)
        {
            XmlTextWriter textWriter = new XmlTextWriter(path + "\\myXmFile.xml", null);
            // Opens the document
            textWriter.WriteStartDocument();
            // Write comments
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element
            textWriter.WriteStartElement("Root");
            textWriter.WriteStartElement("Device");
            // Write next element
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteValue("Vinaphone");
            textWriter.WriteEndElement();
            // Write one more element
            textWriter.WriteStartElement("Delay", "");
            textWriter.WriteValue(10);
            textWriter.WriteEndElement();

            // 
            textWriter.WriteStartElement("Limit");
            textWriter.WriteValue(200);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            // Ends the document.
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();

            MessageBox.Show("OK");
        }

    }
}