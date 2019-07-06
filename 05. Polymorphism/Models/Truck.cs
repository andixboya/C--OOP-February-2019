
namespace VehicleTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Truck : Vehicle
    {
        private const double airConditionerModifier = 1.6;
        private const double refuelPenaltyForTruck = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm ) 
            : base(fuelQuantity, fuelConsumptionPerKm,airConditionerModifier)
        {
            
        }

    

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * refuelPenaltyForTruck);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
