﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public CreateTrainCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.engine.Vehicles.Add(train);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}
