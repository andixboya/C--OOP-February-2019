

namespace P05_PizzaCalories
{
    using P05_PizzaCalories.Models;
    using System;

    public class StartUp
    {

        private static Pizza pizza;
        public static void Main(string[] args)
        {


            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] partitions = input.Split(" ");
                string typeOfProduct = partitions[0].ToLower();

                try
                {
                    switch (typeOfProduct)
                    {
                        case "dough":
                            string typeOfFlour = partitions[1];
                            string typeOfTechnique = partitions[2];
                            double weight = double.Parse(partitions[3]);

                            Dough dough = new Dough(typeOfFlour, typeOfTechnique, weight);
                            pizza.AddDough(dough);

                            //Print(dough.GetDoughCalories().ToString());
                            break;

                        case "topping":
                            string typeOfTopping = partitions[1];
                            weight = double.Parse(partitions[2]);

                            Topping currentTopping = new Topping(typeOfTopping, weight);
                            pizza.AddTopping(currentTopping);

                            //Print(currentTopping.GetToppingCalories().ToString());
                            break;

                        case "pizza":
                            string pizzaName = partitions[1];
                            pizza = new Pizza(pizzaName);
                            break;


                    }
                }

                catch (ArgumentException e)
                {
                    Print(e.Message);
                    return;

                }


                input = Console.ReadLine();


            }


            Print(pizza.ToString());

        }

        private static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
