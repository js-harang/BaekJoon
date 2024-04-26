using System;

namespace Prob15964
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long a = input[0];
            long b = input[1];

            long output = (a + b) * (a - b);

            Console.WriteLine(output);
        }
    }
}
