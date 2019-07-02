

namespace ShoppingSpree
{
    using ShoppingSpree.Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, Person> people = new Dictionary<string, Person>();

            foreach (var info in personsInfo)
            {
                string[] partitions = info.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = partitions[0];
                decimal budget = decimal.Parse(partitions[1]);

                try
                {
                    Person currentPerson = new Person(name, budget);
                    people.Add(currentPerson.Name ,currentPerson);
                }

                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                    return;
                    
                }

            }

            string[] productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            foreach (var pInfo in productsInfo)
            {
                string[] partitions = pInfo.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = partitions[0];
                decimal price = decimal.Parse(partitions[1]);

                try
                {
                    Product currentProduct = new Product(name, price);
                    products.Add(currentProduct.Name , currentProduct);
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                    return;
                    
                }
                
            }

            string command = Console.ReadLine();

            while (command!="END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];
                string productName = tokens[1];

                var currentProduct = products[productName];
                var currentPerson = people[personName];

                string message = string.Empty;
                try
                {
                    message= currentPerson.BuyProduct(currentProduct);
                }
                catch (ArgumentException e)
                {

                    message = e.Message;
                    
                }

                Print(message);

                command = Console.ReadLine();
            }

            foreach (var p in people)
            {
                Print(p.Value.ToString());
            }


        }

        private static void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
