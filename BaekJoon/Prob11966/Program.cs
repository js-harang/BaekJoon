using System;

namespace Prob11966
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = 0;

            for (int i = 0; i <= 30; i++)
            {
                if (input == Math.Pow(2, i))
                {
                    output = 1;
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
