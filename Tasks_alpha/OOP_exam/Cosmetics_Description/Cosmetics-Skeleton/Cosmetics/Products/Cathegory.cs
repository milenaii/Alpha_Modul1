using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private string name;
        private readonly IList<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, 15, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));

            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format
                (GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove from category"));
            if (!this.products.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            this.products.Remove(cosmetics);
        }


        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} category - {this.products.Count} product in total");

            var sortedProduct = this.products
                .OrderBy(a => a.Brand)
                .ThenByDescending(a => a.Price);
            foreach (var prod in sortedProduct)
            {
                sb.AppendLine(prod.Print());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
