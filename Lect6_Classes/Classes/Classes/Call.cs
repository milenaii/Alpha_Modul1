using System;

namespace MobilePhoneDevices
{
    public class Call
    {
        private DateTime dateOfCall;
        private string dialledNumber;
        private decimal? duration;

        public Call( DateTime dateOfCall, string dialledNumber, decimal? duration)
        {
            this.dateOfCall = dateOfCall;
            this.dialledNumber = dialledNumber;
            this.duration = duration;
        }

        public  DateTime DateOfCall
        {
            get
            {
                return this.dateOfCall;
            }
            set
            {
                if (dateOfCall < DateTime.Now)
                {
                    throw new ArgumentException("Datetime of the call cannot be in the future.");
                }
                this.dateOfCall = value;
            }
        }
        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter correct dialed number!");
                }
                this.dialledNumber = value;
            }
        }
        public decimal? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The duration must be positive!");
                }
                this.duration = value;
            }
        }

    }
}
