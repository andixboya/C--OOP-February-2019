using System;

namespace P03Ferrari
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string driverName = Console.ReadLine();

            FerrariClass car = new FerrariClass(driverName);
            Print(car.ToString());
        }

        private static void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
