namespace WildFarm.Animals.Models.Birds
{
    using System;
    using WildFarm.Food.Models;

    public class Owl : Bird
    {

        private const double foodModifier = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        //done with vali
        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                base.FoodEaten += food.Quantity;
                base.Weight += foodModifier * food.Quantity;
            }

            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
