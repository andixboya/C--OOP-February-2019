

namespace P05_PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const double caloriesPerGram = 2;

        private string type;
        private double weight;

        Dictionary<string, double> typesOfToppings;

        public Topping(string type, double weight)
        {
            this.FillInToppingTypes();
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => type;

            private set
            {
                if (!this.typesOfToppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => weight;

            private set
            {
                if (value<1 || value>50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double GetToppingCalories()
        {
            double result = caloriesPerGram * this.Weight * this.typesOfToppings[this.type.ToLower()];

            return result;
        }

        private void FillInToppingTypes()
        {
            this.typesOfToppings = new Dictionary<string, double>();
            this.typesOfToppings.Add("meat", 1.2);
            this.typesOfToppings.Add("veggies", 0.8);
            this.typesOfToppings.Add("cheese", 1.1);
            this.typesOfToppings.Add("sauce", 0.9);

        }
        
    }
}
