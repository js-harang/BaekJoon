using System;

namespace Prob2475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
                sum += int.Parse(Math.Pow(input[i], 2).ToString());

            Console.WriteLine(sum % 10);
        }
    }
}
