using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics
{
    public static class Constants
    {
        public const int MinWinsLosses = 0;
        public const int MaxWinsLosses = 100;

        public const int MinLengthCountry = 3;
        public const int MaxLengthCountry = 25;

        public const int MinLengthName = 2;
        public const int MaxLengthName = 20;

        public const int BoxerParamsCount = 6;
        public const int SprinterMinParamsCount = 3;

        public const string CreateBoxerText = "Created Boxer";
        public const string CreateSprinterTextText = "Created Sprinter";

        public const string CountrySizeInvalid = "Country must be between {0} and {1} characters long!";
        public const string FirstNameSizeInvalid = "First name must be between {0} and {1} characters long!";
        public const string LastNameSizeInvalid = "Last name must be between {0} and {1} characters long!";
        public const string WinsRangeInvalid = "Wins must be between {0} and {1}!";
        public const string LossesRangeInvalid = "Losses must be between {0} and {1}!";



    }
}
