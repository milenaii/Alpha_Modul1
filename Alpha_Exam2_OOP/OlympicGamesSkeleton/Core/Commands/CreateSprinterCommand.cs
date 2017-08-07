using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Olympics;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand :Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine) 
            : base(commandLine)
        {
            this.records = new Dictionary<string, double>();
        }

        public object Commettee { get; private set; }

        public override string Execute()
        {
            var parameters = this.CommandParameters;

            if (parameters.Count < Constants.SprinterMinParamsCount)
            {
                throw new Exception(GlobalConstants.ParametersCountInvalid);
            }

            string firstName = parameters[0];
            string lastName = parameters[1];
            string country = parameters[2];

            // ["100/19.5", "200/25.3"]

            var recordsAsArray = parameters.Skip(Constants.SprinterMinParamsCount).ToArray();
            foreach (var record in recordsAsArray)
            {
                var splitted = record.Split('/');
                string discipline = splitted[0];
                double time = double.Parse(splitted[1]);
                this.records[discipline] = time;    //IDictionary<string, double> records
            }

            IOlympian sprinter = this.Factory.CreateSprinter(firstName, lastName, country, this.records);
            this.Committee.Olympians.Add(sprinter);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Created Sprinter");
            sb.AppendLine(sprinter.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}
