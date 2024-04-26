using System;

namespace Prob2443
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input * 2 - i - 1; j++)
                {
                    if (j < i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
