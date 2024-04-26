using System;
using System.Text;

namespace Prob10820
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                int[] result = new int[4];

                if (input == null)
                    break;

                foreach (char c in input)
                {
                    if (char.IsLower(c))
                        result[0]++;
                    else if (char.IsUpper(c))
                        result[1]++;
                    else if (char.IsDigit(c))
                        result[2]++;
                    else
                        result[3]++;
                }

                output.Append($"{result[0]} {result[1]} {result[2]} {result[3]}\n");
            }

            Console.WriteLine(output);
        }
    }
}
