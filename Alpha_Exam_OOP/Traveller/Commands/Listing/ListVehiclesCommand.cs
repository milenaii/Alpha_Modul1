using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    // TODO
    public class ListVehiclesCommand : Contracts.Command
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public ListVehiclesCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var vehicle = this.engine.Vehicles;

            if (vehicle.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicle);
        }
    }
}
