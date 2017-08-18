using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Airplane : Vehicle, IAirplane
    {
        public Airplane(int passangerCapacity, decimal pricePerKilometer, bool hasFreeFood) 
            : base(passangerCapacity, pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
        }

        public bool HasFreeFood { get; private set; }

        protected override string VehicleKind
        {
            get
            {
                return "Airplane";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine($"Has free food: {this.HasFreeFood}");

            return sb.ToString().TrimEnd();
        }
       
    }
}
