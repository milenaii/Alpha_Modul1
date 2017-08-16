using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IList<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to add to cart"));

            this.products.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to remove from cart"));
            this.products.Remove(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            //this.products.All(a => a.Price);
            foreach (var prod in products)
            {
                totalPrice += prod.Price;
            }
            return totalPrice;
        }
    }
}
