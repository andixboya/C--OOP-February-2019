namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {

            var assembly = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == "HarvestingFields");


            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();

            var fields = assembly.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);


            while (input != "HARVEST")
            {

                switch (input)
                {
                    case "private":
                        foreach (var f in fields.Where(f => f.IsPrivate))
                        {
                            sb.AppendLine($"{input} {f.FieldType.Name} {f.Name}");
                        }
                        break;

                    case "protected":

                        foreach (var f in fields.Where(f => f.IsFamily))
                        {
                            sb.AppendLine($"{input} {f.FieldType.Name} {f.Name}");
                        }

                        break;

                    case "public":
                        foreach (var f in fields.Where(f => f.IsPublic))
                        {
                            sb.AppendLine($"{input} {f.FieldType.Name} {f.Name}");
                        }
                        break;

                    case "all":

                        foreach (var f in fields)
                        {
                            string typeOfModifier = GetModifier(f);

                            sb.AppendLine($"{typeOfModifier} {f.FieldType.Name} {f.Name}");

                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());

        }

        private static string GetModifier(FieldInfo f)
        {


            if (f.IsPublic)
            {
                return "public";
            }
            else if (f.IsFamily)
            {
                return "protected";
            }
            else
            {
                return "private";
            }

        }
    }
}
