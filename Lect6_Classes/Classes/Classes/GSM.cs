using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhoneDevices
{
    public class GSM
    {

        //fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        public static string iPhone4s;  // stat field, but not const
        //private List<Call> callHistory;
        //constr
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
        }
        public GSM(string model, string manufacturer, string owner, Battery battery)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.battery = battery;
        }
        //Prop
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
                    throw new ArgumentNullException("Enter valid model!");
                }
                this.model = value;
            }
        }

        public string Manufactorer
        {
            get
            {
                return this.Manufactorer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid manufactorer!");
                }
                this.Manufactorer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price <= 0)
                {
                    throw new ArgumentException("The price must be not negative!");
                }
                this.Price = value;
            }

        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid owner!");
                }
                this.owner = value;
            }
        }
        //Ако съм автомат проперти - не ми трябват фийловете;
        //Ако имам валидация - тр ми фийловете;
        public Battery Battery
        {
            get
            {
                return battery;
            }
            set
            {
                if (Battery == null)
                {
                    throw new ArgumentNullException("The Battery must be not null.");
                }
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return display;
            }
            set
            {
                if (Display == null)
                {
                    throw new ArgumentNullException("The Display must be not null.");
                }
                this.display = value;
            }
        }

        public string IPhone4s
        {
            get
            {
                return GSM.iPhone4s;
            }
            set
            {
                if (string.IsNullOrEmpty(iPhone4s))
                {
                    throw new ArgumentNullException("Enter valid iPhone4s!");
                }
                GSM.iPhone4s = value;
            }
        }

        public List<Call> CallHistory { get; set; }
      
        public override string ToString()
        {
            return $"Model: {this.Model}".ToString();
        }

        public void AddCalls(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory(Call call)
        {
            this.CallHistory.Clear();
        }

        public decimal? CountPrice(decimal? pricePerMin)
        {
            decimal? price = 0m;
            decimal? durationOfAllCalls = 0m;

            foreach (var item in CallHistory)
            {
                durationOfAllCalls += item.Duration;
            }

            return price += (durationOfAllCalls / 60) * pricePerMin; 
        }

        public void PrintCallHistory()
        {
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
        }


    }
}
