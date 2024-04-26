using System;
using System.Linq;

namespace Prob10811
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] s = new string[n];
            int[] score = new int[n];
            float max = 0;
            double avg = 0;

            s = Console.ReadLine().Split(' ');

            for (int i = 0; i < s.Length; i++)
                score[i] = int.Parse(s[i]);

            max = score.Max();
            avg = score.Average() / score.Max() * 100;

            Console.WriteLine(avg);
        }
    }
}
