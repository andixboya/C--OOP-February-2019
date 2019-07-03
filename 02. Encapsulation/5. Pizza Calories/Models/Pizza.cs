

namespace P05_PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || value.Length<1 
                    || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get => dough;

            private set
            {
                this.dough = value;
            }
        }

        public double GetTotalCalories()
        {
            double result = this.toppings.Sum(t => t.GetToppingCalories()) +this.dough.GetDoughCalories();
            return result;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count==10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public void AddDough(Dough dough)
        {
            this.Dough = dough;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.GetTotalCalories():f2} Calories.";
        }
    }
}
