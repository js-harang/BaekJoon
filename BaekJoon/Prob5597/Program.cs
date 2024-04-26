using System;

namespace Prob5597
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] check = new bool[30];

            for (int i = 0; i < 28; i++)
            {
                int input = int.Parse(Console.ReadLine());

                check[input - 1] = true;
            }

            for (int i = 0; i < 30; i++)
            {
                if (!check[i])
                    Console.WriteLine(i + 1);
            }
        }
    }
}
