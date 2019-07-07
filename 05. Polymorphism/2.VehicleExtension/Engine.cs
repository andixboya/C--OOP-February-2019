
namespace VehicleTwo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VehicleTwo.Contracts;
    using VehicleTwo.Models;

    public class Engine
    {
        private static Vehicle car;
        private static Vehicle truck;
        private static Vehicle bus;

        public void Run()
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            for (int i = 0; i < 3; i++)
            {
                string[] vehiclePartitions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                double fuelQuantity = double.Parse(vehiclePartitions[1]);
                double fuelConsumptionPerKm = double.Parse(vehiclePartitions[2]);
                double tankCapacity = double.Parse(vehiclePartitions[3]);

                if (i==0)
                {
                     car = new Car(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                    vehicles.Add(car);
                }
                else if (i==1)
                {
                     truck = new Truck(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                    vehicles.Add(truck);
                }
                else
                {
                     bus = new Bus(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
                    vehicles.Add(bus);
                }


            }

            int count = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < count; i++)
            {
                string[] partitions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = partitions[0];
                string type = partitions[1];
                double value = double.Parse(partitions[2]);


                try
                {

                    if (command == "Refuel")
                    {
                        if (type == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (type == "Bus")
                        {
                            bus.Refuel(value);
                        }
                        else
                        {
                            truck.Refuel(value);
                        }


                    }
                    else if (command == "Drive")
                    {
                        if (type == "Car")
                        {
                            Console.WriteLine(car.DriveDistance(value));
                        }
                        else if (type == "Bus")
                        {
                            Console.WriteLine(bus.DriveDistance(value));
                        }
                        else
                        {
                            Console.WriteLine(truck.DriveDistance(value));
                        }

                    }
                    else  // in case of driveEmpty
                    {
                        Console.WriteLine(bus.TravelWithoutPassengers(value));
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

              
            }

            foreach (var veh in vehicles)
            {
                Print(veh.ToString());
            }


        }

        private static void Print(string veh)
        {
            Console.WriteLine(veh.ToString());
        }
    }
}
