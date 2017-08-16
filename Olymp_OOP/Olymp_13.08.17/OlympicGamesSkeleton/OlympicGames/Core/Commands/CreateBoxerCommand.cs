using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using System.Text;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command, ICommand
    {
        public CreateBoxerCommand(IList<string> commandLine)
            : base(commandLine)
        {
        }

        public override string Execute()
        {
            var parameters = this.CommandParameters;

            
            string firstName = parameters[0];
            string lastName = parameters[1];
            string country = parameters[2];
            string category = parameters[3];

            //int wins = int.Parse(parameters[4]);
            //int losses = int.Parse(parameters[5]);

            int wins;
            bool parsedWin = int.TryParse(parameters[4], out wins);

            int losses;
            bool parsedLosses = int.TryParse(parameters[5], out losses);

            if (!parsedWin || !parsedLosses)
            {
                throw new ArgumentException(GlobalConstants.WinsLossesMustBeNumbers);
            }

            IOlympian boxer = this.Factory.CreateBoxer(firstName, lastName, country, category, wins, losses);

            this.Committee.Olympians.Add(boxer);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Created Boxer");
            sb.AppendLine(boxer.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}
