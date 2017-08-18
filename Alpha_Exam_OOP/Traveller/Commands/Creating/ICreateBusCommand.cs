using System.Collections.Generic;

namespace Traveller.Commands.Creating
{
    public interface ICreateBusCommand
    {
        string Execute(IList<string> parameters);
    }
}