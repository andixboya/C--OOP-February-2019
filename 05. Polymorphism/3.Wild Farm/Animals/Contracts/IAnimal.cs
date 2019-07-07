namespace WildFarm.Animals.Contracts
{
    using System;
    using WildFarm.Food.Models;

    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }
        
        void ProduceSound();
        void Eat(Food food);

    }
}
