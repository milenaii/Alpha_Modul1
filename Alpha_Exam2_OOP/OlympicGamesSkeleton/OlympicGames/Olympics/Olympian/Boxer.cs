using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Olympian
{
    public class Boxer : Olympian, IBoxer
    {
        private int wins;
        private int losses;
        private BoxingCategory category;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses )
            : base(firstName, lastName, country)
        {
            this.category = category;
            this.Wins = wins;
            this.Losses = losses;
        }

        public BoxingCategory Category
        {
            get
            {
                return this.Category;
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }
            set
            {
                Validator.ValidateMinAndMaxNumber(this.wins, Constants.MinWinsLosses, Constants.MaxWinsLosses, null);
                this.wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }
            set
            {
                Validator.ValidateMinAndMaxNumber(this.losses, Constants.MinWinsLosses, Constants.MaxWinsLosses, null);

                this.losses = value;
            }
        }

        public override string ToString()
        {
            return string.Format("BOXER: {0} {1} from {2}\nCategory: {3}\nWins: {4}\nLosses: {5}", this.FirstName, this.LastName, this.Country, this.Category, this.Wins, this.Losses);
        }

    }
}
