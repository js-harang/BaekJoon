using System;

namespace Prob1193
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int line = 1;
            int order = 0;

            int a = 0;
            int b = 0;

            for (int i = 1; x > 0; i++)
            {
                order = 0;

                for (int j = 1; j <= i && x > 0; j++)
                {
                    x -= 1;
                    order++;
                }

                line++;
            }

            if (line % 2 != 0)
            {
                b = line - order;
                a = line - b;
            }
            else
            {
                a = line - order;
                b = line - a;
            }

            Console.WriteLine("{0}/{1}", a, b);
        }
    }
}
