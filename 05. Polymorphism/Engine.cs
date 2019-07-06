
namespace VehicleTwo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VehicleTwo.Contracts;
    using VehicleTwo.Models;

    public class Engine
    {
        public void Run()
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            string [] carPartitions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantity = double.Parse(carPartitions[1]);
            double litersPerKm = double.Parse(carPartitions[2]);

            IVehicle car = new Car(fuelQuantity, litersPerKm);
            vehicles.Add(car);

            string[] truckPartitions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            fuelQuantity = double.Parse(truckPartitions[1]);
            litersPerKm = double.Parse(truckPartitions[2]);

            IVehicle truck = new Truck(fuelQuantity, litersPerKm);
            vehicles.Add(truck);


            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string[] partitions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = partitions[0];
                string vehicleName = partitions[1];
                double value = double.Parse(partitions[2]);

                if (vehicleName=="Car")
                {
                    if (command=="Drive")
                    {
                        Console.WriteLine(car.DriveDistance(value)); 
                    }
                    else
                    {
                        car.Refuel(value);
                    }
                }
                else
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(truck.DriveDistance(value));
                    }
                    else
                    {
                        truck.Refuel(value);
                    }
                }

            }

            foreach (var veh in vehicles)
            {
                Console.WriteLine(veh.ToString());
            }


        }
    }
}
