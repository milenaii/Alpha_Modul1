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
        private const int MinLengthCountry = 3;
        private const int MaxLengthCountry = 25;
        private const int MinLengthName = 2;
        private const int MaxLengthName = 20;

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
                Validator.ValidateIfNull(this.firstName, null);
                Validator.ValidateMinAndMaxLength(this.firstName, MinLengthName, MaxLengthName);

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
                Validator.ValidateIfNull(this.lastName, null);
                Validator.ValidateMinAndMaxLength(this.lastName, MinLengthName, MaxLengthName);

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
                Validator.ValidateIfNull(this.country, null);
                Validator.ValidateMinAndMaxLength(this.country, MinLengthCountry, MaxLengthCountry);

                this.country = value;
            }
        }
        

    }
}
