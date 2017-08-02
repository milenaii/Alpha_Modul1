using Dealership.Contracts;
using System;
using Dealership.Common.Enums;
using System.Collections.Generic;
using Dealership.Common;


namespace Dealership.Models
{
    public abstract class Vehicle: IVehicle
    {
        private int wheels;
        private VehicleType type;
        private string make;
        private string model;
        private decimal price;


        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public abstract int Wheels {get;}

        public VehicleType Type
        {
            get
            {
                return this.Type;
            }
            private set
            {
                this.Type = value;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter correct Model!");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter valid Model!");
                }
                this.model = value;
            }
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.Comments;
            }
            set
            {
                Validator.ValidateNull(value, "........");
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0 || value > 2000000)
                {
                    throw new ArgumentException("The price must be better than 0!");
                }
                this.price = value;
            }
        }

        //public string Category => throw new NotImplementedException();
    }
}
