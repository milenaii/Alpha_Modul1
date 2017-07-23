using System;

namespace ClassMI
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        private static GSM iPhone4s = new GSM("iPhone4s", "Apple", "Hr.Hr.", new Battery("batModel"), new Display(12, 25), 300);

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, string owner, Battery battery, Display display, decimal? price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.Price = price;

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
                    throw new ArgumentException("You must enter a valid model!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must enter a valid manufacturer!");
                }
                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price should not be negative!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must enter a valid owner!");
                }
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get;
            set;
        }
        public Display Display
        {
            get;
            set;
        }
        public static GSM IPhone4s
        {
            get
            {
                return iPhone4s;
            }
        }

        public override string ToString()
        {

            return $"Model: {Model}\nManufactorer: {Manufacturer}\nPrice: {Price}\nOwner: {Owner}\nBattery: {Battery}\nDisplay: ";
        }

    }
}
