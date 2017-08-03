using System;
using System.Collections.Generic;

using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics.Olympian;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        private static OlympicsFactory instance = new OlympicsFactory();
        private IDictionary<string, double> personalRecords;

        private OlympicsFactory() { }

        public static OlympicsFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            BoxingCategory finalCategory = BoxingCategory.Middleweight;
            Enum.TryParse(category, out finalCategory);

            return new Boxer(firstName, lastName, country, finalCategory, wins, losses);
        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
        {
            return new Sprinter(firstName, lastName, country,  personalRecords);
        }
    }
}
