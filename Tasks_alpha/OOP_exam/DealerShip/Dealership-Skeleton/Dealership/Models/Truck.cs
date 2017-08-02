using Dealership.Common.Enums;
using Dealership.Contracts;
using System;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Truck;
            }
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            set
            {
                if (value <= 100)
                {
                    throw new ArgumentException("The Wieght capacity must be better than 100!");
                }
                this.weightCapacity = value;
            }
        }
    }
}
