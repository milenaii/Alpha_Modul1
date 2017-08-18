using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Enum;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Constants;

namespace Traveller.Models
{
    public class Train : Vehicle, ITrain
    {
        private int carts;

        public Train(int passangerCapacity, decimal pricePerKilometer, int carts)
            : base(passangerCapacity, pricePerKilometer)
        {
            this.Carts = carts;
            //this.type = type;

            if (passangerCapacity < Constant.TrainMinPassanger || passangerCapacity > Constant.TrainMaxPassanger)
            {
                throw new ArgumentOutOfRangeException(Constant.TrainExceptionPassengers);
            }
        }

        public int Carts
        {
            get
            {
                return this.carts;
            }
            private set
            {
                if (value < Constant.TrainMinCarts || value > Constant.TrainMaxCarts)
                {
                    throw new ArgumentOutOfRangeException(Constant.TrainExceptionCarts);
                }
                this.carts = value;
            }
        }

        protected override string VehicleKind
        {
            get
            {
                return "Train";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine($"Carts amount: {this.Carts}");

            return sb.ToString().TrimEnd();
        }
    }
}
