namespace WildFarm.Animals.Models.Mammals.Felines
{
    using System;
    using WildFarm.Food.Models;

    public class Tiger : Feline
    {
        private const double foodModifier = 1;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

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
            Console.WriteLine("ROAR!!!");
        }
    }
}
