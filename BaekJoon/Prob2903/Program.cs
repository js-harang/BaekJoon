using System;

namespace Prob2903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dot = 2;

            for (int i = 0; i < n; i++)
            {
                dot = dot + (int)Math.Pow(2, i);
            }

            Console.WriteLine(dot * dot);
        }
    }
}
