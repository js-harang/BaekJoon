using System;

namespace Prob25238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            float a = float.Parse(input[0]);
            float b = float.Parse(input[1]);

            if (a - a * b / 100 >= 100)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);
        }
    }
}
