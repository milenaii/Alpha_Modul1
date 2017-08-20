using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Constants;

namespace Traveller.Models
{
    public class Journey : IJourney
    {
        private string startLocation;
        private string destination;
        private int distance;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            this.StartLocation = startLocation;
            this.Destination = destination;
            this.Distance = distance;
            this.Vehicle = vehicle;

        }

        public string StartLocation
        {
            get
            {
                return this.startLocation;
            }
            set
            {
                CheckIsValidName(value);
                this.startLocation = value;
            }
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
            set
            {
                CheckIsValidName(value);
                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }
            private set
            {
                if (value < Constant.DistanceMin || value > Constant.DistanceMax)
                {
                    throw new ArgumentOutOfRangeException(Constant.DistanceException);
                }
                this.distance = value;
            }
        }


        public IVehicle Vehicle { get; private set; }

        public decimal CalculateTravelCosts()
        {
            decimal costs;
            return costs = this.Distance + this.Vehicle.PricePerKilometer;
        }

        protected void CheckIsValidName(string value)
        {
            if (value.Length < Constant.StartLocationDestinationMinLength || value.Length > Constant.StartLocationDestinationMaxLength)
            {
                throw new ArgumentOutOfRangeException("The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Journey ----");
            sb.AppendLine($"Start location: {this.StartLocation}");
            sb.AppendLine($"Destination: {this.Destination}");
            //sb.AppendLine($"Vehicle type: {VehicleType}");
            sb.AppendLine($"Travel costs: {CalculateTravelCosts()}");

            return sb.ToString().TrimEnd();
        }
    }
}
