using System;
using System.Text;

namespace Prob2448
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[,] pattern = new string[input, input * 2 - 1];
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < pattern.GetLength(0); i++)
                for (int j = 0; j < pattern.GetLength(1); j++)
                    if (j > input - 2 - i && j < input + i)
                        pattern[i, j] = "*";
                    else
                        pattern[i, j] = " ";

            if (input == 3)
                pattern[1, 2] = " ";
            else
            {
                for (int i = input / 2; i < input; i++)
                    for (int j = i; j < input * 2 - i - 1; j++)
                        pattern[i, j] = " ";
            }

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
