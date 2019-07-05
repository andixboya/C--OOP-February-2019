namespace BorderControlExercise.Core
{
    using BorderControlExercise.Contracts;
    using BorderControlExercise.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {

        private readonly ICollection<IIdentifiable> creatures;
        private readonly ICollection<IBirthable> birthDays;
        private ICollection<IBuyer> buyers;
        

        public Engine()
        {
            this.creatures = new List<IIdentifiable> { };
            this.birthDays = new List<IBirthable> { };
            this.buyers = new List<IBuyer> { };
        }

        public void Run()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine().Split();

                // case of citizen
                if (partitions.Length == 4)
                {
                    IBuyer citizen = new Citizen(partitions[0],int.Parse(partitions[1]),partitions[2],partitions[3]);
                    buyers.Add(citizen);

                }
                // case of rebel
                else if (partitions.Length == 3)
                {
                    IBuyer rebel = new Rebel(partitions[0], int.Parse(partitions[1]), partitions[2]);

                    
                    buyers.Add(rebel);

                }


            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == input);
                if (buyer==null)
                {
                    continue;   
                }

                buyer.BuyFood();
                
            }
            int totalFoodBought = buyers.Sum(b => b.Food);
            Console.WriteLine(totalFoodBought);


        }
    }
}
