using System;

namespace Prob10798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] s = new string[5, 15];

            for (int i = 0; i < s.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                    s[i, j] = input[j].ToString();
            }

            string output = null;

            for (int i = 0; i < s.GetLength(1); i++)
            {
                for (int j = 0; j < s.GetLength(0); j++)
                    output += s[j, i];
            }

            Console.WriteLine(output);
        }
    }
}
