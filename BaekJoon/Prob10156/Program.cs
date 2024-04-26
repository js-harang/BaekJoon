using System;

namespace Prob10156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int m = int.Parse(input[2]);

            int output = k * n - m;

            if (output < 0)
                output = 0;

            Console.WriteLine(output);
        }
    }
}
