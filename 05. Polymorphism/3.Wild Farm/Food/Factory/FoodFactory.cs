namespace WildFarm.Food.Factory
{
    using System;
    using WildFarm.Food.Contracts;
    using WildFarm.Food.Models;

    public class FoodFactory
    {
        public Food GenerateFood(string type, int quantity)
        {
            type = type.ToLower();

            switch (type)
            {

                case "vegetable":
                    return new Vegetable(quantity);
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid Food !");             
            }

        }


    }
}
