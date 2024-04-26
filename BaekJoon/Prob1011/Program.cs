using System;

namespace Prob1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] output = new int[t];

            for (int i = 0; i < t; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int r = input[1] - input[0];
                int count = 0;

                for (int j = 1; r - j * 2 > 0; j++)
                {
                    r -= j * 2;
                    count++;
                }

                if (r - count - 1 <= 0)
                    output[i] = count * 2 + 1;
                else
                    output[i] = count * 2 + 2;
            }

            for (int i = 0; i < t; i++)
                Console.WriteLine(output[i]);
        }
    }
}
