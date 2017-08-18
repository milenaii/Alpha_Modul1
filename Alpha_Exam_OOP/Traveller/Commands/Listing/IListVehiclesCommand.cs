using System.Collections.Generic;

namespace Traveller.Commands.Creating
{
    public interface IListVehiclesCommand
    {
        string Execute(IList<string> parameters);
    }
}