

namespace VehicleTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VehicleTwo.Contracts;

    public abstract class Vehicle : IVehicle, ICarrier
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double airConditionerModifier;
        private double tankCapacity = 0;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double airConditionerModifier, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.airConditionerModifier = airConditionerModifier;


        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;

            set
            {
                

                if (this.TankCapacity < value)
                {
                    this.fuelQuantity += 0;
                }
                //WHY?
                ////QUESTION ... WHY IS THIS CRAP HERE IN THE FIRST PLACE!?
                //if (this.FuelQuantity + fuel > this.TankCapacity)
                //{

                //    throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
                //}


                else
                {
                    this.fuelQuantity = value;
                }

            }
        }

        public virtual double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm + this.airConditionerModifier;

            private set
            {
                this.fuelConsumptionPerKm = value;
            }
        }

        public double TankCapacity
        {
            get => tankCapacity;

            private set
            {
                this.tankCapacity = value;
            }
        }



        public string DriveDistance(double distance)
        {
            string message = string.Empty;

            double fuelExpenses = distance * this.FuelConsumptionPerKm;

            if (fuelExpenses <= this.FuelQuantity)
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

            if (fuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            //QUESTION ... WHY IS THIS CRAP HERE IN THE FIRST PLACE!?

            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel;

        }

        public virtual string TravelWithoutPassengers(double distance)
        {
            string message = this.DriveDistance(distance);
            return message;
        }

    }
}
