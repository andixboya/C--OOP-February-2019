namespace WildFarm.Animals.Models.Mammals
{
    using System;
    using WildFarm.Food.Models;

    public class Mouse : Mammal
    {
        private const double foodModifier = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {

        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit)
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
            Console.WriteLine("Squeak");
        }
    }
}
