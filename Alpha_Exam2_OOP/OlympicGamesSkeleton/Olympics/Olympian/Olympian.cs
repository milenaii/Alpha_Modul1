using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;

namespace OlympicGames.Olympics.Olympian
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
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthName, Constants.MaxLengthName, string.Format(Constants.FirstNameSizeInvalid, Constants.MinLengthName, Constants.MaxLengthName));

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
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthName, Constants.MaxLengthName, string.Format(Constants.LastNameSizeInvalid, Constants.MinLengthName, Constants.MaxLengthName));

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
                Validator.ValidateMinAndMaxLength(value, Constants.MinLengthCountry, Constants.MaxLengthCountry, string.Format(Constants.CountrySizeInvalid, Constants.MinLengthCountry, Constants.MaxLengthCountry));

                this.country = value;
            }
        }

        protected abstract string Type { get; }

        public override string ToString()
        {
            return $"{this.Type}: {this.FirstName} {this.LastName} from {this.Country}\n";
        }

    }
}
