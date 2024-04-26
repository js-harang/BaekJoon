using System;

namespace Prob2442
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input + i; j++)
                {
                    if (j < input - i - 1)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
