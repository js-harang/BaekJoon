using System;
using System.Linq;

namespace Prob10039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];

            for (int i = 0; i < 5; i++)
            {
                input[i] = int.Parse(Console.ReadLine());

                if (input[i] < 40)
                    input[i] = 40;
            }

            Console.WriteLine(input.Average());
        }
    }
}
