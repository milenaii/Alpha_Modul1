using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private List<Call> callHistory;

        private static GSM iPhone4S 
            = new GSM("IPhone4S", "Apple", 800, "Pesho",
                new Battery("Samsung", 400, 10, BatteryType.LiIon),
                new Display(800, 50));

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        public GSM(string model, string manufacturer,
            decimal? price, string owner, 
            Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = null;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
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
                    throw new ArgumentException("The model should not be null or emtpy");
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
                    throw new ArgumentException("The manufacturer should not be null or emtpy");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price; ;
            }
            set
            {
                if (value.HasValue && value.Value < 0)
                {
                    throw new ArgumentException("The price should not be negative");
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
                if (value == string.Empty)
                {
                    throw new ArgumentException("The owner should not be emtpy");
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

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Call history should not be null");
                }

                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistory = null;
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            if (!this.CallHistory.Contains(call))
            {
                throw new ArgumentException("Call is not found");
            }

            this.CallHistory.Remove(call);
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }

        public decimal GetCallPrice()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price}\nOwner: {this.Owner}\nDisplay: {this.Display}\nBattery: {this.Battery}";
        }
    }
}
