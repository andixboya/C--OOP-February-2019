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

            Box box = new Box(length, width, heigh);

            Print(box);

        }

        private static void Print(Box box)
        {
            Console.WriteLine(box);
        }
    }
}
