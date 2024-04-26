using System;

namespace Prob1924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int m = input[0];
            int d = input[1];

            int[] month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] dday = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            int day = 0;

            for (int i = 1; i < m; i++)
                day += month[i - 1];

            day += d;

            Console.WriteLine(dday[day % 7]);
        }
    }
}
