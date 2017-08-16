using OlympicGames.Olympics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Models
{
    public class Boxer : Olympian, IOlympian
    {
        private int wins;
        private int losses;
        private BoxingCategory category;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses)
            :base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
        }

        public BoxingCategory Category { get; set; } 

        public int Wins
        {
            get
            {
                return this.wins;
            }
            set
            {
                Validator.ValidateMinAndMaxNumber(value, Constants.winsLossesMin, Constants.winsLossesMax, null);
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
                Validator.ValidateMinAndMaxNumber(value, Constants.winsLossesMin, Constants.winsLossesMax, null);
                this.losses = value;
            }
        }

        public override string ToString()
        {
            return $"Category: {this.Category}\nWins: {this.Wins}\nLosses: {this.Losses}"; 
        }

        public override string PrintTypeOlympian()
        {
            return "BOXER: ";
        }
    }
}
