using System;
using System.Linq;

namespace Prob2609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int lcm;
            int gcd;

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            lcm = program.LCM(input.Max(), input.Min());
            gcd = input[0] * input[1] / lcm;

            Console.WriteLine(lcm);
            Console.WriteLine(gcd);
        }

        private int LCM(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return LCM(b, a % b);
        }
    }
}
