using System;

namespace Prob5596
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] score2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < score1.Length; i++)
            {
                sum1 += score1[i];
                sum2 += score2[i];
            }

            if (sum1 >= sum2)
                Console.WriteLine(sum1);
            else
                Console.WriteLine(sum2);
        }
    }
}
