namespace Dealership.Contracts
{
    using Dealership.Common.Enums;

    public interface IVehicle : IMotorcycle, IPriceable
    {
        int Wheels { get; }

        VehicleType Type { get; }

        string Make { get; }

        string Model { get;  }
    }
}
