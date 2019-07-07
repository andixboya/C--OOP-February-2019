

namespace VehicleTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VehicleTwo.Contracts;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double airConditionerModifier;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm,double airConditionerModifier)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.airConditionerModifier = airConditionerModifier;
            

        }

        public double FuelQuantity
        {
             get => this.fuelQuantity;

            private set
            {
                this.fuelQuantity = value;
            }
        }

        public  double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm+this.airConditionerModifier;

            private set
            {
                this.fuelConsumptionPerKm = value;
            }
        }



        public string DriveDistance(double distance)
        {
            string message = string.Empty;

            double fuelExpenses = distance * this.FuelConsumptionPerKm;

            if (fuelExpenses<=this.FuelQuantity)
            {
                this.FuelQuantity -= fuelExpenses;
                message = $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                message = $"{this.GetType().Name} needs refueling";
            }

            return message;
        }

        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;

        }

    
    }
}
