using Traveller.Models.Enum;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        int Carts { get; }
    }
}