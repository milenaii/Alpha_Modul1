namespace OlympicGames.Core.Factories
{
    public interface ICommandParser
    {
        ICommand ParseCommand(string commandLine);
    }
}
