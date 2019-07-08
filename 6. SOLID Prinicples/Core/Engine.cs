

namespace LoggerT.Core
{
    using LoggerT.Core.Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
            
        }

        public void Run()
        {

            int countOfAppenders = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfAppenders; i++)
            {
                string []appCreateArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                commandInterpreter.AddAppender(appCreateArgs);

            }

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] commandArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    commandInterpreter.AddMessage(commandArgs);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }


            commandInterpreter.Print();

        }
    }
}
