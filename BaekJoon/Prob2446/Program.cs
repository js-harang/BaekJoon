using System;

namespace Prob2446
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
                        if (j < i)
                            Console.Write(" ");
                        else if (j < input * 2 - i - 1)
                            Console.Write("*");
                    }
                    else
                    {
                        if (j < input * 2 - i - 2)
                            Console.Write(" ");
                        else if (j < i + 1)
                            Console.Write("*");

                    }
                }

                Console.WriteLine();
            }
        }
    }
}
