using System.Collections.Generic;

using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand :Command,ICommand
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine) 
            : base(commandLine)
        {
            this.records = new Dictionary<string, double>();
        }

        public override string Execute()
        {
            var parameters = this.CommandParameters;




            //To string
            return "";
        }
    }
}
