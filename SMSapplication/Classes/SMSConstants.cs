using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSapplication.Classes
{
    public static class SMSConstants
    {
        // Ten cac nha mang
        public static string ViettelProvider { get { return "Viettel"; } }
        public static string VinaphoneProvider { get { return "Vinaphone"; } }
        public static string MobiphoneProvider { get { return "Mobiphone"; } }

        // Chuoi nhan dien cong com can xu ly
        public static string PortComNameAvaiable_1 { get { return "PC UI Interface"; } }

        // Chuoi them vao message gui di
        public static string AddMessage_HoTen { get { return "<HOTEN>"; } }
        public static string AddMessage_SoDienThoai { get { return "<DIENTHOAI>"; } }
        public static string AddMessage_ThongTin1 { get { return "<THONGTIN#1>"; } }
        public static string AddMessage_ThongTin2 { get { return "<THONGTIN#2>"; } }
        public static string AddMessage_ThongTin3 { get { return "<THONGTIN#3>"; } }

    }
}
