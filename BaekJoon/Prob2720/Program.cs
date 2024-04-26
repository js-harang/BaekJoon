using System;

namespace Prob2720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] input = new int[t];

            for (int i = 0; i < t; i++)
                input[i] = int.Parse(Console.ReadLine());

            int q;
            int d;
            int n;
            int p;

            for (int i = 0; i < t; i++)
            {
                q = input[i] / 25;
                input[i] %= 25;
                d = input[i] / 10;
                input[i] %= 10;
                n = input[i] / 5;
                p = input[i] % 5;

                Console.WriteLine("{0} {1} {2} {3}", q, d, n, p);
            }
        }
    }
}
