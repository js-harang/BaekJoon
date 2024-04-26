using System;

namespace Prob2444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input * 2 - 1; i++)
            {
                for (int j = 0; j < input * 2 - 1; j++)
                {
                    if (i < input)
                    {
                        if (j < input - i - 1)
                            Console.Write(" ");
                        else if (j < input + i)
                            Console.Write("*");
                    }
                    else
                    {
                        if (j <= i - input)
                            Console.Write(" ");
                        else if (j < input * 3 - i - 2)
                            Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
