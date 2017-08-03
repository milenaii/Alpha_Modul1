using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;

namespace OlympicGames.Olympics.Olympian
{
    public class Olympian : IOlympian
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
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthName, Constants.MaxLengthName);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthName, Constants.MaxLengthName);

                this.lastName = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthCountry, Constants.MaxLengthCountry);

                this.country = value;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} from {this.Country}\n";
        }

    }
}
