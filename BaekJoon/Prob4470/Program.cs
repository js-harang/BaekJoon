using System;

namespace Prob4470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            for (int i = 1; i <= n; i++)
                input[i - 1] = $"{i}. {Console.ReadLine()}";

            foreach (string output in input)
                Console.WriteLine(output);
        }
    }
}
