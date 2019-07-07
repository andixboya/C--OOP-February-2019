namespace WildFarm.Animals.Models.Mammals.Felines
{
    using System;
    using WildFarm.Food.Models;

    public class Cat : Feline
    {
        private const double foodModifier = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
            
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
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
            Console.WriteLine("Meow");
        }
    }
}
