using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Olympics;
using System;
using System.Collections.Generic;
using OlympicGames.Utils;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using System.Text;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command,ICommand
    {
        public CreateBoxerCommand(IList<string> commandLine)
            : base(commandLine)
        {
            
        }

        public override string Execute()
        {
            var parameters = this.CommandParameters;
            if (parameters.Count != Constants.BoxerParamsCount)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }

            string firstName = parameters[0];
            string lastName = parameters[1];
            string country = parameters[2];
            string boxCategory = parameters[3];
            int wins = int.Parse(parameters[4]);
            int loses = int.Parse(parameters[5]);

            IOlympian boxer = this.Factory.CreateBoxer(firstName, lastName,country, boxCategory, wins, loses);

            this.Committee.Olympians.Add(boxer);
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Created Boxer");
            sb.Append("BOXER: ");
            sb.AppendLine(boxer.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}
