

namespace ShoppingSpree.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;
        private readonly List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Money
        {
            get => money;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;

            }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money <product.Cost)
            {
                throw new ArgumentException($"{this.name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;

            this.bag.Add(product);

            return $"{this.Name} bought {product.Name}";

        }

        public IReadOnlyCollection<Product> Bag => this.bag;

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();

            if (this.bag.Count == 0)
            {
                message.AppendLine($"{this.name} - Nothing bought");
            }

            else
            {
                message.AppendLine($"{this.name} - {string.Join(", ", this.bag)}");

            }

            return message.ToString().TrimEnd();
        }
    }
}
