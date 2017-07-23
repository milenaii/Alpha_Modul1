using System;
namespace MobilePhoneDevices
{
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batType;
        public Battery()
        {

        }
        public Battery(string model, BatteryType batType)
        {
            this.model = model;
            this.batType = batType;
        }
        public Battery(double hoursId, double hoursT)
        {
            this.hoursIdle = hoursId;
            this.hoursTalk = hoursT;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(model))
                {
                    throw new ArgumentException("Enter valid Model!");
                }
                this.model = value;
            }
        }
        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (hoursIdle == null && hoursIdle <= 0)
                {
                    throw new ArgumentException("Enter valid hours Idle!");
                }
                this.hoursIdle = value;
            }
        }
        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (hoursTalk == null && hoursTalk <= 0)
                {
                    throw new ArgumentException("Enter valid hours Talk!");
                }
                this.hoursTalk = value;
            }
        }
    }
}
