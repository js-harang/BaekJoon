using System;
using System.Linq;

namespace Prob1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg;

            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] score = new int[n];

            for (int i = 0; i < s.Length; i++)
                score[i] = int.Parse(s[i]);

            avg = score.Average() / score.Max() * 100;

            Console.WriteLine(avg);
        }
    }
}
