using BorderControlSecond.Contracts;
using BorderControlSecond.Models;
using System;
using System.Collections.Generic;

namespace BorderControlSecond
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<IIdentifiable> subjects = new List<IIdentifiable>();

            while (input != "End")
            {
                string[] partitions = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int countOfParts = partitions.Length;

                string name = partitions[0];



                if (countOfParts == 2) // insert robot
                {
                    string id = partitions[1];

                    IIdentifiable current = new Robot(id, name);
                    subjects.Add(current);


                }

                else //insert citizen
                {
                    int age = int.Parse(partitions[1]);
                    string id = partitions[2];

                    IIdentifiable citizen = new Citizen(id, name, age);

                    subjects.Add(citizen);
                }


                input = Console.ReadLine();
            }

            string endNumberrs = Console.ReadLine();

            List<string> idsToRemove = new List<string>();

            foreach (var subject in subjects)
            {
                string subjectId = subject.Id;

                if (subjectId.EndsWith(endNumberrs))
                {
                    idsToRemove.Add(subjectId);
                }

            }

            Print(idsToRemove.ToArray());  

        }

        private static void Print(params string[] idsToRemove)
        {
            Console.WriteLine(string.Join(Environment.NewLine, idsToRemove));
        }
    }
}
