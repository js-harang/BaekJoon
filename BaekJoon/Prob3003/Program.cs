using System;

namespace Prob2997
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(input);

            int a = input[0];
            int b = input[1];
            int c = input[2];

            int output = 0;

            if (b - a == c - b)
                output = 2 * c - b;
            else if (b - a > c - b)
                output = a + c - b;
            else
                output = 2 * b - a;

            Console.WriteLine(output);
        }
    }
}
