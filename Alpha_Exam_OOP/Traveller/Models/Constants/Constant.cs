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
        
        //Train
        public const int TrainMinPassanger = 1;
        public const int TrainMaxPassanger = 800;

        public const string TrainExceptionPassengers = "A train cannot have less than 30 passengers or more than 150 passengers.";

        public const int TrainMinCarts = 1;
        public const int TrainMaxCarts = 15;

        public const string TrainExceptionCarts = "A train cannot have less than 1 cart or more than 15 carts.";

        //Journey
        public const int StartLocationDestinationMinLength = 5;
        public const int StartLocationDestinationMaxLength = 25;

        public const string StartLocationLengthException = "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.";

        public const int DistanceMin = 5;
        public const int DistanceMax = 5000;

        public const string DistanceException = "The Distance cannot be less than 5 or more than 5000 kilometers.";
    }
}
