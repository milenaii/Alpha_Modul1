using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredients(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ",ingredients);
            }
            
        }
        private void ValidateIngredients(IList<string> ingredients)
        {
            if (ingredients.Any(i => i.Length < 4 || i.Length > 12))
            {
                throw new IndexOutOfRangeException(string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));

            }
        }
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.AppendLine($" * Ingredients: {this.Ingredients} ");

            return sb.ToString();
        }

    }
}
