using OlympicGames.Olympics.Contracts;
using System;
using System.Collections.Generic;

namespace OlympicGames.Olympics.Olympian
{
    public class Sprinter : Olympian, ISprinter
    {

        public Sprinter(string firstName, string lastName, string country)
            : base(firstName, lastName, country)
        {
        }

        public IDictionary<string, double> PersonalRecords { get; }
    }
}
