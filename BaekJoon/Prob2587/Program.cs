using System;
using System.Linq;

namespace Prob2587
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];

            for (int i = 0; i < 5; i++)
                input[i] = int.Parse(Console.ReadLine());

            Array.Sort(input);

            Console.WriteLine(input.Average());
            Console.WriteLine(input[2]);
        }
    }
}
