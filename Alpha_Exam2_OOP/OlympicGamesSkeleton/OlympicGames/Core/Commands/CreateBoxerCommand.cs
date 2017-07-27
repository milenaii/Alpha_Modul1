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
    public class CreateBoxerCommand : Command, ICommand
    {
        public CreateBoxerCommand(IList<string> commandLine)
            : base(commandLine)
        {
        }

        public override string Execute()
        {
            //createboxer Wladimir Klitschko Ukraine heavyweight 64 5
            string input = "";
            while (input != "end")
            {
                input = Console.ReadLine();
                CommandParser.Instance.ParseCommand(input);

                Boxer boxer = new Boxer(input[0].ToString(), input[1].ToString(), input[2].ToString(),(BoxingCategory)input[3],(int)input[4],(int)input[5]);
                
            }
            return ToString();
        }
    }
}
