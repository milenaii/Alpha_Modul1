using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Constants
{
    public class Constant
    {
        //vehicle
        public const int VehicleMinPassanger = 1;
        public const int VehicleMaxPassanger = 800;

        public const string VehicleExceptionPassengers = "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!";

        public const decimal VehicleMinPriceKm = 0.10M;
        public const decimal VehicleMaxPriceKm = 2.50M;

        public const string VehicleExceptionPricePerKm = "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";
    }
}
