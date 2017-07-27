﻿using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Olympian
{
    public class Boxer : Olympian, IBoxer
    {
        private int wins;
        private int losses;
        private const int MinWinsLosses = 0;
        private const int MaxWinsLosses = 100;
        private BoxingCategory category;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses )
            : base(firstName, lastName, country)
        {
            this.category = category;
            this.Wins = wins;
            this.Losses = losses;

        }

        public Boxer()
        {
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
                Validator.ValidateMinAndMaxNumber(this.wins, MinWinsLosses, MaxWinsLosses, null);
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
                Validator.ValidateMinAndMaxNumber(this.losses, MinWinsLosses, MaxWinsLosses, null);

                this.losses = value;
            }
        }
    }
}
