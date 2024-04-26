using System;

namespace Prob14652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            Console.WriteLine("{0} {1}", k / m, k % m);
        }
    }
}
