﻿using System;

namespace Prob2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int h = input[0];
            int m = input[1];
            int s = input[2];
            int time = int.Parse(Console.ReadLine());

            s += time;
            m += s / 60;
            s %= 60;
            h += m / 60;
            m %= 60;
            h %= 24;

            Console.WriteLine("{0} {1} {2}", h, m, s);
        }
    }
}
