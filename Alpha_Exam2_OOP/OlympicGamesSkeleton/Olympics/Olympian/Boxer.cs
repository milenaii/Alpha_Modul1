using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;
using System.Text;

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
                return this.category;
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
                //msg = string.Format("Value must be between {0} and {1}!", min, max)

                Validator.ValidateMinAndMaxNumber(value, Constants.MinWinsLosses, Constants.MaxWinsLosses,string.Format(Constants.WinsRangeInvalid, Constants.MinWinsLosses, Constants.MaxWinsLosses));

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
                Validator.ValidateMinAndMaxNumber(value, Constants.MinWinsLosses, Constants.MaxWinsLosses,string.Format(Constants.LossesRangeInvalid, Constants.MinWinsLosses, Constants.MaxWinsLosses));

                this.losses = value;
            }
        }

        protected override string Type
        {
            get
            {
                return "BOXER";
            }
        }
                

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Category: {this.Category}");
            sb.AppendLine($"Wins: {this.Wins}");
            sb.AppendLine($"Losses: {this.Losses}");

            return sb.ToString().TrimEnd();
        }


    }
}
