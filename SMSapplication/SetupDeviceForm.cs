using SMSapplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSapplication
{
    public partial class SetupDeviceForm : Form
    {
        public SettingDevice dataSetup { get; set; }

        public SetupDeviceForm()
        {
            InitializeComponent();
        }

        private void SetupDevice_Load(object sender, EventArgs e)
        {
            MangDiDongCombobox_Load();
            DoTreCombobox_Load();
            GioiHanCombobox_Load();

            lbThietBi.Text = dataSetup.DeviceName;
            cbMangDiDong.SelectedValue = dataSetup.Cops;
            cbDoTre.SelectedValue = dataSetup.DelayTime.ToString();
            cbGioiHan.SelectedValue = dataSetup.Limit.ToString();

        }

        private void MangDiDongCombobox_Load()
        {
            // Mang di dong
            var deviceDatasource = new[] { 
                new { Text = "Vinaphone", Value = "Vinaphone" }, 
                new { Text = "Mobifone", Value = "Mobifone" }, 
                new { Text = "Viettel", Value = "Viettel" },
            };

            cbMangDiDong.DataSource = deviceDatasource;
            cbMangDiDong.DisplayMember = "key";
            cbMangDiDong.ValueMember = "value";
        }

        private void DoTreCombobox_Load()
        {
            // Mang di dong
            var deviceDatasource = new[] { 
                new { Text = "0", Value = "0" }, 
                new { Text = "1", Value = "1" }, 
                new { Text = "2", Value = "2" },
                new { Text = "3", Value = "3" }, 
                new { Text = "4", Value = "4" }, 
                new { Text = "5", Value = "5" },
                new { Text = "10", Value = "10" }, 
                new { Text = "15", Value = "15" }, 
                new { Text = "20", Value = "20" },
                new { Text = "25", Value = "25" }, 
                new { Text = "30", Value = "30" }, 
                new { Text = "40", Value = "40" },
                new { Text = "60", Value = "60" }, 
                new { Text = "90", Value = "90" }, 
                new { Text = "180", Value = "180" },
                new { Text = "240", Value = "240" }, 
            };

            cbDoTre.DataSource = deviceDatasource;
            cbDoTre.DisplayMember = "key";
            cbDoTre.ValueMember = "value";
        }

        private void GioiHanCombobox_Load()
        {
            // Mang di dong
            var deviceDatasource = new[] { 
                new { Text = "0", Value = "0" }, 
                new { Text = "50", Value = "50" }, 
                new { Text = "80", Value = "80" },
                new { Text = "100", Value = "100" }, 
                new { Text = "150", Value = "150" }, 
                new { Text = "200", Value = "200" },
                new { Text = "250", Value = "250" }, 
                new { Text = "300", Value = "300" }, 
                new { Text = "400", Value = "400" },
                new { Text = "500", Value = "500" }, 
                new { Text = "1000", Value = "1000" }, 
                new { Text = "1", Value = "1" },
            };

            cbGioiHan.DataSource = deviceDatasource;
            cbGioiHan.DisplayMember = "key";
            cbGioiHan.ValueMember = "value";
        }

        private void btnLuuCaiDat_Click(object sender, EventArgs e)
        {
            //dataSetup.Cops = cbMangDiDong.SelectedValue.ToString();
            this.Close();
        }
    }
}
