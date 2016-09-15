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
        public static string MobiphoneProvider { get { return "Mobifone"; } }
        public static string VietnamobileProvider { get { return "Vietnamobile"; } }
        public static string SphoneProvider { get { return "Sphone"; } }
        public static string GmobileProvider { get { return "Gmobile"; } }
        
        // Chuoi nhan dien cong com can xu ly
        public static string PortComNameAvaiable_1 { get { return "PC UI Interface"; } }

        // Chuoi them vao message gui di
        public static string AddMessage_HoTen { get { return "<HOTEN>"; } }
        public static string AddMessage_SoDienThoai { get { return "<DIENTHOAI>"; } }
        public static string AddMessage_ThongTin1 { get { return "<THONGTIN#1>"; } }
        public static string AddMessage_ThongTin2 { get { return "<THONGTIN#2>"; } }
        public static string AddMessage_ThongTin3 { get { return "<THONGTIN#3>"; } }

        // Dau so dien thoai theo mang
        public static Dictionary<string, string> Names_NhaMang { get { return new Dictionary<string, string> { 
        { "096", "Viettel" },
        { "097", "Viettel" },
        { "098", "Viettel" },
        { "0163", "Viettel" },
        { "0164", "Viettel" },
        { "0165", "Viettel" },
        { "0166", "Viettel" },
        { "0167", "Viettel" },
        { "0168", "Viettel" },
        { "0169", "Viettel" },
        { "090", "Mobifone" },
        { "093", "Mobifone" },
        { "0120", "Mobifone" },
        { "0121", "Mobifone" },
        { "0122", "Mobifone" },
        { "0126", "Mobifone" },
        { "0128", "Mobifone" },
        { "091", "Vinafone" },
        { "094", "Vinafone" },
        { "0123", "Vinafone" },
        { "0124", "Vinafone" },
        { "0125", "Vinafone" },
        { "0127", "Vinafone" },
        { "0129", "Vinafone" },
        { "092", "Vietnamobile" },
        { "0188", "Vietnamobile" },
        { "0186", "Vietnamobile" },
        { "095", "Sphone" },
        { "0993", "Gmobile" },
        { "0994", "Gmobile" },
        { "0995", "Gmobile" },
        { "0996", "Gmobile" },
        { "0199", "Gmobile" }
        };
        }
        }
    }
}
