using System;
using System.Text;

namespace Prob2447
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[,] pattern = new string[input, input];

            for (int i = 0; i < pattern.GetLength(0); i++)
                for (int j = 0; j < pattern.GetLength(1); j++)
                    pattern[i, j] = "*";

            for (int i = input; i / 3 >= 1; i /= 3)
                for (int j = 0; j < input / i; j++)
                    for (int k = i / 3 + i * j; k < i / 3 * 2 + i * j; k++)
                        for (int l = 0; l < input / i; l++)
                            for (int n = i / 3 + i * l; n < i / 3 * 2 + i * l; n++)
                                pattern[k, n] = " ";

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                    output.Append(pattern[i, j]);

                output.Append("\n");
            }

            Console.WriteLine(output);
        }
    }
}
