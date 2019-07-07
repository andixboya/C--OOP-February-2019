namespace WildFarm.Animals.Models.Mammals.Factories
{
    using System;
    using WildFarm.Animals.Contracts;

    public class MammalFactory
    {
        public IAnimal GenerateAnimal(string type, string name, double weight, string livingRegion)
        {
            type = type.ToLower();

            switch (type)
            {

                case "dog":
                    return new Dog(name, weight, livingRegion);
                case "mouse":
                    return new Mouse(name, weight, livingRegion);
                default:
                    throw new ArgumentException("Invalid mammal creation!");

             
            }

        }
    }
}
