using System;
using System.Linq;

namespace Prob1453
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] seat = new int[100];

            for (int i = 0; i < 100; i++)
                seat[i] = i + 1;

            for (int i = 0; i < n; i++)
                seat = seat.Where(element => element != input[i]).ToArray();

            Console.WriteLine(n - 100 + seat.Length);
        }
    }
}
