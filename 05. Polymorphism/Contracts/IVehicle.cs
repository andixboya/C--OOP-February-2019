

namespace VehicleTwo.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }
        string DriveDistance(double distance);
        void Refuel(double fuel);





    }
}
