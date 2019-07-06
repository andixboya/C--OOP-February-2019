

namespace VehicleTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car : Vehicle
    {
        private const double airConditionerModifier = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm, airConditionerModifier)
        {

        }

        

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
