using System;

namespace ClassMI
{
    class Battery
    {
        private string model;
        private int hourIdle;
        private int hourTalk;

        public Battery(string model)
            : this (model, 10, 10, BatteryType.LiIon) 
        {

        }

        public Battery (string model, int hourTalk, int hourIdle, BatteryType batteryType)
        {
            this.Model = model;
            this.HourTalk = hourTalk;
            this.HourIdle = hourIdle;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter a valid model!");
                }
                this.model = value;
            }
        }
        public int HourIdle
        {
            get
            {
                return this.hourIdle;
            }
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentException("Enter valid Hour Idle!");
                //}
                this.hourIdle = value;
            }
        }
        public int HourTalk
        {
            get
            {
                return this.hourTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Enter valid Hour Idle!");
                }
                this.hourTalk = value;
            }
        }
        public BatteryType BatteryType
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"Model - {Model}, HourTalk - {HourTalk}, HourIdle - {HourIdle}";
        }
    }
}
