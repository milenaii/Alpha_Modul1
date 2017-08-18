using System.Collections.Generic;

namespace Traveller.Commands.Creating
{
    public interface ICreateAirplaneCommand
    {
        string Execute(IList<string> parameters);
    }
}