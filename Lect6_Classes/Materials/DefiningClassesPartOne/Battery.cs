using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Battery
    {
        public Battery()
            : this("Samsung", 100, 40, BatteryType.LiIon)
        {
        }

        public Battery(string model, int hoursIdle, 
            int hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get;
            set;
        }

        public int HoursIdle
        {
            get;
            set;
        }

        public int HoursTalk
        {
            get;
            set;
        }

        public BatteryType BatteryType
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Model - {this.Model}; Hours idle - {this.HoursIdle};Hours talk - {this.HoursTalk}; Battery type - {this.BatteryType}";
        }
    }
}
