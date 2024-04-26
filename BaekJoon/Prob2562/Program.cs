using System;

namespace Prob2562
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int flag = 0;

            for (int i = 0; i < 9; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                    flag = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(flag + 1);
        }
    }
}
