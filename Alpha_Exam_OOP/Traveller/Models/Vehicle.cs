using System;
using Traveller.Models.Enum;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Constants;

namespace Traveller.Models
{
    public class Vehicle : IVehicle

    {
        private decimal pricePerKilometer;
        private int passangerCapacity;

        public Vehicle(int passangerCapacity, decimal pricePerKilometer)
        {

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
                    throw new ArgumentException(Constant.VehicleExceptionPricePerKm);
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
                    throw new ArgumentException(Constant.VehicleExceptionPassengers);
                }
                this.passangerCapacity = value;
            }
        }

        public VehicleType Type { get; private set; }
    }
}