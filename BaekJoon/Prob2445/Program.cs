using System;

namespace Prob2445
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input * 2 - 1; i++)
            {
                for (int j = 0; j < input * 2; j++)
                {
                    if (i < input)
                    {
                        if (j <= i || j >= input * 2 - i - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j < input * 2 - i - 1 || j > i)
                            Console.Write("*");
                        else
                            Console.Write(" ");

                    }
                }

                Console.WriteLine();
            }
        }
    }
}
