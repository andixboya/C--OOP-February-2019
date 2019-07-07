namespace WildFarm.Animals.Models.Mammals.Felines.Factories
{
    using System;

    public class FelineFactory
    {
        public Feline GenerateFeline(string type, string name, double weight, string livingRegion, string breed)
        {
            type = type.ToLower();

            switch (type)
            {

                case "cat":
                    return new Cat(name, weight, livingRegion, breed);
                case "tiger":
                    return new Tiger(name, weight, livingRegion, breed);
                default:
                    throw new ArgumentException("Cannot create such Feline!");
            }

        }
    }
}
