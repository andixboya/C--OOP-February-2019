
namespace Telephony.Core
{
    using System;
    using Telephony.Models;

    public class Engine
    {
        public void Run()
        {

            string[] numbers = Console.ReadLine().Split(" ");
            string[] sites= Console.ReadLine().Split(" ");

            SmartPhone phone = new SmartPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNumber = numbers[i];

                try
                {
                    phone.CallNumber(currentNumber);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < sites.Length; i++)
            {
                string currentSite = sites[i];
                try
                {
                    phone.SurfSite(currentSite);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
