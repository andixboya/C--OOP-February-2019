using System;
using System.Collections.Generic;
using WildFarm.Animals.Contracts;
using WildFarm.Animals.Models.Birds.Factories;
using WildFarm.Animals.Models.Mammals.Factories;
using WildFarm.Animals.Models.Mammals.Felines.Factories;
using WildFarm.Food.Factory;

namespace WildFarm.Core
{
    public class Engine
    {
        private FoodFactory foodFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private BirdsFactory birdsFactory;
        private IAnimal animal;
        private List<IAnimal> animals;

        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.felineFactory = new FelineFactory();
            this.mammalFactory = new MammalFactory();
            this.birdsFactory = new BirdsFactory();
            this.animals = new List<IAnimal> { };


        }

        public void Run()
        {

            string input = Console.ReadLine();

            while (input!="End")
            {
                try
                {
                    string[] animalInfo = input.Split();
                    string[] foodInfo = Console.ReadLine().Split();

                    string vegType = foodInfo[0];
                    int vegQuantity = int.Parse(foodInfo[1]);

                    Food.Models.Food food = foodFactory.GenerateFood(vegType, vegQuantity);

                    string type = animalInfo[0];
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);

                    if (type == "Cat" || type == "Tiger")
                    {

                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = felineFactory.GenerateFeline(type, name, weight, livingRegion, breed);

                    }
                    else if (type == "Dog" || type == "Mouse")
                    {
                        string livingRegion = animalInfo[3];

                        animal = mammalFactory.GenerateAnimal(type, name, weight, livingRegion);

                    }
                    else if (type == "Owl" || type == "Hen")
                    {
                        double wingSize = double.Parse(animalInfo[3]);
                        animal = birdsFactory.CreateBird(type, name, weight, wingSize);

                    }

                    animals.Add(animal);
                    animal.ProduceSound();
                    animal.Eat(food);

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
               
                input = Console.ReadLine();
            }


            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
