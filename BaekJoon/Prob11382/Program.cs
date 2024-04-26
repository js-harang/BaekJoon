using System;

namespace Prob11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            long a = long.Parse(s[0]);
            long b = long.Parse(s[1]);
            long c = long.Parse(s[2]);

            Console.WriteLine(a + b + c);
        }
    }
}
