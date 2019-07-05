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
            List<Identity> subjectsWithId = new List<Identity>();

            while (input != "End")
            {
                string[] partitions = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = partitions[0];
                string name = partitions[1];

                switch (type)
                {
                    case "Citizen":
                        int age = int.Parse(partitions[2]);
                        string id = partitions[3];
                        DateTime birthDate = DateTime.ParseExact(partitions[4], "dd/MM/yyyy",null);
                        Identity citizen = new Citizen(name, id, age, birthDate);
                        subjectsWithId.Add(citizen);
                        break;

                    case "Pet":
                        birthDate = DateTime.ParseExact(partitions[2], "dd/MM/yyyy", null);
                        Identity pet = new Pet(name, birthDate);
                        subjectsWithId.Add(pet);

                        break;

                    case "Robot":
                        id = partitions[2];
                        IIdentifiable robot = new Robot(id, name);
                        subjects.Add(robot);

                        break;

                }


                input = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());

            List<DateTime> birthdates = new List<DateTime>();


            foreach (var sub in subjectsWithId)
            {
                int currentYear = sub.BirthDate.Year;

                if (currentYear==year)
                {
                    birthdates.Add(sub.BirthDate);
                }

            }

            foreach (var bDay in birthdates)
            {
                string date = $"{bDay.Day:d2}/{bDay.Month:d2}/{bDay.Year}";
                Print(date);
            }

  


        }

        private static void Print(string date)
        {
            Console.WriteLine(date);
        }

        private static void Print(params string[] idsToRemove)
        {
            Console.WriteLine(string.Join(Environment.NewLine, idsToRemove));
        }
    }
}
