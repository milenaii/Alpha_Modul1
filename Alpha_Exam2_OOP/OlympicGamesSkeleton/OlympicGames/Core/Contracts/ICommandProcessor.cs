using System.Collections.Generic;

namespace OlympicGames.Core.Factories
{
    public interface ICommandProcessor 
    {
        ICollection<ICommand> Commands { get; }

        void Add(ICommand command);

        void ProcessCommands();

        void ProcessSingleCommand(ICommand command);
    }
}
