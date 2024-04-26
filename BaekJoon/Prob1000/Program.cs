using System;

namespace Prob1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split(' ');

            int a = int.Parse(sp[0]);
            int b = int.Parse(sp[1]);

            Console.WriteLine(a + b);
        }
    }
}
