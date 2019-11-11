using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                SwitchColors(colors, sb);
            }
            
            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void SwitchColors(string[] colors, StringBuilder sb)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                var current = colors[i];
                switch (current)
                {
                    case "Green":
                        sb.Append("Yellow ");
                        colors[i] = "Yellow";
                        break;
                    case "Yellow":
                        sb.Append("Red ");
                        colors[i] = "Red";
                        break;
                    case "Red":
                        sb.Append("Green ");
                        colors[i] = "Green";
                        break;
                }
            }
            sb.AppendLine();
        }
    }
}
