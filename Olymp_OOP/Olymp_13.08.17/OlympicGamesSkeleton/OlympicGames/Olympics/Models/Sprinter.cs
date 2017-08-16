using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Models
{
    public class Sprinter : Olympian, ISprinter
    {
        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords )
            : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecords;
        }

        public IDictionary<string, double> PersonalRecords { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GlobalConstants.PersonalRecords);
            foreach (var rec in PersonalRecords)
            {
                sb.Append($"{rec.Key}m: {rec.Value}s");
            }

            return sb.ToString().TrimEnd();
        }

        public override string PrintTypeOlympian()
        {
            return "SPRINTER: ";
        }
    }
}
