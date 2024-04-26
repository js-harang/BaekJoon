using System;

namespace Prob2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[9, 9];

            int max = 0;
            int r = 1, c = 1;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = input[j];

                    if (input[j] > max)
                    {
                        max = input[j];
                        c = i + 1;
                        r = j + 1;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine("{0} {1}", c, r);
        }
    }
}
