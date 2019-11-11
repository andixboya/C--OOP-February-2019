using System;
using System.Linq;

namespace CustomAttribute
{
    [CustomAttribute]
    public class StartUp
    {
        public static void Main(string[] args)
        {


            var attr = (CustomAttribute)typeof(StartUp).GetCustomAttributes(false).First();

            var command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attr.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attr.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attr.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {attr.Reviewers}");
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }




        }
    }
}
