using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Models
{
    public abstract class Olympian : IOlympian
    {
        private string firstName;
        private string lastName;
        private string country;

        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value, Constants.nameLengthMin, Constants.nameLengthMax, null);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value, Constants.nameLengthMin, Constants.nameLengthMax, null);
                this.lastName = value;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value, Constants.countryLengthMin, Constants.countroLengthMax, null);
                this.country = value;
            }
        }
        public abstract string PrintTypeOlympian();

       // public abstract string CharacteristicPrintOlympian();

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(PrintTypeOlympian());
            sb.AppendLine($"{FirstName} {lastName} from {country}");
           // sb.AppendLine(CharacteristicPrintOlympian());
            return sb.ToString();
        }

    }
}
