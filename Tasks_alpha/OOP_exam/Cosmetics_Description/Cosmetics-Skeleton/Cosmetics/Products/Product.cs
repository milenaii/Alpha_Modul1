using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Text;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value,string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));

                Validator.CheckIfStringLengthIsValid(value, 10, 3, GlobalErrorMessages.InvalidStringLength);
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value, 10, 2, GlobalErrorMessages.InvalidStringLength);
                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be not < 0!");
                }
                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- { this.Brand} – { this.Name}:");
            sb.AppendLine($" *Price: ${ this.Price}");
            sb.AppendLine($" *For gender: { this.Gender}");
            return sb.ToString();
        }
    }
}
