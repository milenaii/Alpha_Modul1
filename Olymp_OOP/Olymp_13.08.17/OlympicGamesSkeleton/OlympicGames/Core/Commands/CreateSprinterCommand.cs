using System;
using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System.Linq;
using System.Text;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand: Command, ICommand
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine)
            : base(commandLine)
        {
            this.records = new Dictionary<string,double>();
        }

        public override string Execute()
        {
            var parameters = this.CommandParameters;

            string firstName = parameters[0];
            string lastName = parameters[1];
            string country = parameters[2];

            // ["100/19.5", "200/25.3"]

            var recordsToArray = parameters.Skip(3).ToArray();

            foreach (var rec in recordsToArray)
            {
                var splitted = rec.Split('/');
                string discipline = splitted[0];
                double time = double.Parse(splitted[1]);
                this.records[discipline] = time;
            }

                IOlympian sprinter = this.Factory.CreateSprinter(firstName, lastName, country, records);

                this.Committee.Olympians.Add(sprinter);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Created Sprinter");
                sb.AppendLine(sprinter.ToString());

                return sb.ToString().TrimEnd();



        }
    }
}
