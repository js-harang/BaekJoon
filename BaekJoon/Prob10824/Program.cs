using System;

namespace Prob10824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long ab = long.Parse(input[0] + input[1]);
            long cd = long.Parse(input[2] + input[3]);

            Console.WriteLine(ab + cd);
        }
    }
}
