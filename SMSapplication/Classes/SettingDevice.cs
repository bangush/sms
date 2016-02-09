using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSapplication.Classes
{
    public class SettingDevice
    {
        public string DeviceName { get; set; }

        public string Cops { get; set; }

        public int DelayTime { get; set; }

        public int Limit { get; set; }
        public SettingDevice(string name, string cops, int delay, int limit)
        {
            this.DeviceName = name;
            this.Cops = cops;
            this.DelayTime = delay;
            this.Limit = limit;
        }
        public SettingDevice()
        {
          
        }
    }
}
