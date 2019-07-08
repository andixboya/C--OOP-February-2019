namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {

            var methods = typeof(BlackBoxInteger).GetMethods(BindingFlags.NonPublic|BindingFlags.Instance);


            string input = Console.ReadLine();

            var instance = Activator.CreateInstance(typeof(BlackBoxInteger),true) ;
            var field = instance.GetType().GetField("innerValue", BindingFlags.Instance| BindingFlags.NonPublic);

            while (input!="END")
            {
                string[] partitions = input.Split("_", StringSplitOptions.RemoveEmptyEntries);
                string command = partitions[0];
                int value = int.Parse(partitions[1]);

                var method = methods.FirstOrDefault(m => m.Name == command);

                
                 method.Invoke(instance,new object[] { value });

                Console.WriteLine(field.GetValue(instance)); 
                

                input = Console.ReadLine();
            }


        }
    }
}
