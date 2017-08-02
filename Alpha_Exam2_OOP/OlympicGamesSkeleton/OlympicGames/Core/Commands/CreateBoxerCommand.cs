using OlympicGames.Core.Commands.Abstracts;
using System;
using System.Collections.Generic;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Providers;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Olympian;
using OlympicGames.Olympics.Enums;

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
            throw new NotImplementedException();
        }
    }
}
