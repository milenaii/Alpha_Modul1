using System;
using System.Windows.Input;
using Traveller.Core.Contracts;
using System.Collections.Generic;
using Traveller.Commands.Contracts;


namespace Traveller.Commands.Creating
{
    internal abstract class Command : Contracts.ICommand
    {
        private  ITravellerFactory factory;
        private  IEngine engine;

        public Command(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }


        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}