using System.Collections.Generic;

namespace Traveller.Commands.Creating
{
    public interface IListVehiclesCommand1
    {
        string Execute(IList<string> parameters);
    }
}