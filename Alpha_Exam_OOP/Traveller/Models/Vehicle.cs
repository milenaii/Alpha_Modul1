using System;
using Traveller.Models.Enum;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Constants;
using System.Text;

namespace Traveller.Models
{
    public abstract class Vehicle : IVehicle

    {
        private int passangerCapacity;
        private decimal pricePerKilometer;
        protected VehicleType type;

        public Vehicle(int passangerCapacity, decimal pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            private set
            {
                if (value < Constant.VehicleMinPriceKm || value > Constant.VehicleMaxPriceKm)
                {
                    throw new ArgumentOutOfRangeException(Constant.VehicleExceptionPricePerKm);
                }
                this.pricePerKilometer = value;
            }
        }

        public int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }
            private set
            {
                if (value < Constant.VehicleMinPassanger || value > Constant.VehicleMaxPassanger)
                {
                    throw new ArgumentOutOfRangeException(Constant.VehicleExceptionPassengers);
                }
                this.passangerCapacity = value;
            }
        }

        public VehicleType Type { get; }

        protected abstract string VehicleKind { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.VehicleKind} ----");
            sb.AppendLine($"Passenger capacity: {this.PassangerCapacity}");
            sb.AppendLine($"rice per kilometer: {this.PricePerKilometer}");
            sb.AppendLine($"Vehicle type: {this.Type}");

            return sb.ToString().TrimEnd();

            //Bus----
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            //Vehicle type: VALUE
        }
    }
}