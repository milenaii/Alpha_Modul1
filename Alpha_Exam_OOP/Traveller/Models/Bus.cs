using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models 
{
    public class Bus : Vehicle, IBus
    {
        public Bus(int passangerCapacity, decimal pricePerKilometer) 
            : base(passangerCapacity, pricePerKilometer)
        {
        }

        protected override string VehicleKind
        {
            get
            {
                return "Bus";
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            
            return sb.ToString().TrimEnd();
        }

    }
}

