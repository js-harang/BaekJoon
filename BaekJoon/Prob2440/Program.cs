using System;

namespace Prob2440
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = input; j - i > 0; j--)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
