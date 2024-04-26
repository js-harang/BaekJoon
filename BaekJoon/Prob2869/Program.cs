using System;

namespace Prob2869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int v = input[2];
            int a = input[0];
            int b = input[1];

            int day = (v - b) / (a - b);

            if ((v - b) % (a - b) == 0)
                Console.WriteLine(day);
            else
                Console.WriteLine(day + 1);
        }
    }
}
