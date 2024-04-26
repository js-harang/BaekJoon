using System;

namespace Prob2420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long a = long.Parse(s[0]);
            long b = long.Parse(s[1]);

            Console.WriteLine(Math.Abs(a - b));
        }
    }
}
