namespace WildFarm.Animals.Models.Birds
{
    using System;
    using WildFarm.Food.Models;

    public class Hen : Bird
    {
        private const double foodModifier = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }
        // done with vali
        public override void Eat(Food food)
        {
            base.FoodEaten += food.Quantity;
            base.Weight += foodModifier * food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
