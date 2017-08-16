using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {
        //private uint milliliters;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage) 
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price *= this.Milliliters;
        }

        public uint Milliliters { get; private set; }
        public UsageType Usage { get; private set; }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.AppendLine($" * Quantity: {this.Milliliters} ml");
            sb.AppendLine($" * Usage: {this.Usage}");

            return sb.ToString();
        }

    }
}
