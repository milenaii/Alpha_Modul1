using Dealership.Common.Enums;
using Dealership.Contracts;
using System;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats) 
            : base(make, model, price)
        {
            this.Seats = seats;
        }
        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Car;
            }
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Enter valid number of seats!");
                }
                this.seats = value;
            }
        }
       
    }
}
