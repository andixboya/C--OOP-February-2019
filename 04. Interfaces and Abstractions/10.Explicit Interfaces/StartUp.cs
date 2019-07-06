
using System;
using ExplicitInterfaces.Contracts;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] partitions = input.Split();
                string name = partitions[0];
                string country = partitions[1];
                int age = int.Parse(partitions[2]);

                var citizen = new Citizen(name);

                IPerson person = new Citizen(name);
                IResident resident = new Citizen(name);

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
                

                input = Console.ReadLine();
            }

        }
    }
}
