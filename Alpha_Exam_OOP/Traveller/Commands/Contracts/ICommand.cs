using System.Collections.Generic;

namespace Traveller.Commands.Contracts
{
    public interface Command
    {
        string Execute(IList<string> parameters);
    }
}
