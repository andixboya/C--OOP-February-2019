
namespace VehicleTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VehicleTwo.Contracts;

    public class Bus : Vehicle , ICarrier
    {
        private const double airConditionerModifier = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, airConditionerModifier, tankCapacity)
        {

        }



        public override string TravelWithoutPassengers(double distance)
        {
            string message = string.Empty;

            double fuelExpensesWithoutAirConditioner = distance * (this.FuelConsumptionPerKm-airConditionerModifier);

            if (fuelExpensesWithoutAirConditioner <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelExpensesWithoutAirConditioner;
                message = $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                message = $"{this.GetType().Name} needs refueling";
            }

            return message;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
