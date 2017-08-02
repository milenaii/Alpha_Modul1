using Dealership.Common.Enums;
using Dealership.Contracts;
using System;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IVehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Motorcycle;
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Enter valid Category!");
                }
                this.category = value;
            }

        }
    }
}
