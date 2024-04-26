using System;

namespace Prob2441
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = input; i > 0; i--)
            {
                for (int j = 0; j < input; j++)
                {
                    if (j < input - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
