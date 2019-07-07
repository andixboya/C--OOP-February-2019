namespace WildFarm.Animals.Models.Birds.Factories
{
    using System;

    public class BirdsFactory
    {
        public Bird CreateBird(string type, string name, double weight, double wingSize)
        {
            type = type.ToLower();

            switch (type)
            {
                case "owl":
                    return new Owl(name, weight, wingSize);

                case "hen":
                    return new Hen(name, weight, wingSize);
                default:
                    throw new ArgumentException("Invalid Bird Generation!");
             
            }

        }
    }
}
