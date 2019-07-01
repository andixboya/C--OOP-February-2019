using System;

namespace P01_Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, heigh);
                Print(box);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine( e.Message);
            }

        }

        private static void Print(Box box)
        {
            Console.WriteLine(box);
        }
    }
}
