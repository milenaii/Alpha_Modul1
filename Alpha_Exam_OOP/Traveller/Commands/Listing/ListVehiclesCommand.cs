using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Commands.Creating;
using Traveller.Commands.Listing;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    // TODO
    public class ListVehiclesCommand : ListingCommand<IVehicle>, ICommand
    {
        public ListVehiclesCommand(ITravellerFactory factory, IEngine engine)
            : base(factory, engine)
        {
        }

        protected override ICollection<IVehicle> Items
        {
            get
            {
                return this.engine.Vehicles;
            }
        }

        protected override string CustomErrorMessage
        {
            get
            {
                return "There are no registered vehicles.";
            }
        }
    }
}
