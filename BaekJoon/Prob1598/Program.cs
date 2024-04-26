using System;

namespace Prob1598
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]) - 1;
            int b = int.Parse(input[1]) - 1;

            int a1 = a / 4;
            int a2 = a % 4;
            int b1 = b / 4;
            int b2 = b % 4;

            int output = Math.Abs(a1 - b1) + Math.Abs(a2 - b2);

            Console.WriteLine(output);
        }
    }
}
