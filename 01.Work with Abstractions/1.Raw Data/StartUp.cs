using P01_RawData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    public class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                var secondParams = parameters.Skip(5).ToArray();

                Tire[] tires = new Tire[4];

                int counter = 0;
                for (int j = 0; j < secondParams.Length; j+=2)
                {
                    double currentTirePressure = double.Parse(secondParams[j]);
                    int currentTireAge= int.Parse(secondParams[j+1]);

                    Tire currentTire = new Tire(currentTirePressure, currentTireAge);

                    tires[counter] = currentTire;
                    counter++;
                }

                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }



            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(y => y.TirePressure < 1))
                    .Select(c => c.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower> 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
