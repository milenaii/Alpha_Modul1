using System.Collections.Generic;

using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Factories
{
    public interface IOlympicCommittee
    {
        ICollection<IOlympian> Olympians { get; }
    }
}
