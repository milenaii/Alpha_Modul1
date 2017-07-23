using System;
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
//main
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
            }
        }
//decim - prop? 
        public decimal Price { get; set; }
        public string Owner
        {
            get
            {
                return this.Owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid owner!");
                }
            }
        }
 //       public Battery battery { get; set; }
 //       public Display display{ get; set; }

        //to string Method
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
 // this
            if (this.model != null)
            {
                output.AppendLine(@"Model:, {model}");
            }
            if (this.manufacturer != null)
            {
                output.AppendLine(@"Manufacturer:, {manufacturer}");
            }
            if (price != null)
            {
                output.AppendLine(@"Price:, {price}");
            }
            if (owner != null)
            {
                output.AppendLine(@"Owner:, {owner}");
            }
            if (display.size != null)
            {
                output.AppendLine(@"Display Size: {Display.size}");
            }
            if (display.size != null)
            {
                output.AppendLine(@"Display Size: {Display.size}");
            }
            if (display.numberOfColors != null)
            {
                output.AppendLine(@"Display Number Of Colors: {Display.numberOfColors}");
            }
            if (battery.model != null)
            {
                output.AppendLine(@"Battery Model: {battery.Model}");
            }
            if (battery.hoursIdle != null)
            {
                output.AppendLine(@"Battery Hours Idle: {battery.hoursIdle}");
            }
            if (battery.hoursTalk != null)
            {
                output.AppendLine(@"Battery Hours Talk: {battery.hoursTalk}");
            }

            return base.ToString();
        }


    }
}
