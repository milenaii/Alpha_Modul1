using System.Collections.Generic;

namespace Traveller.Commands.Creating
{
    public interface ICreateTrainCommand
    {
        string Execute(IList<string> parameters);
    }
}