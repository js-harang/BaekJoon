using System;

namespace Prob2588
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int a = int.Parse(s1);
            int b = int.Parse(s2);

            int first = b / 100;
            int second = b % 100 / 10;
            int third = b % 10;

            Console.WriteLine(a * third);
            Console.WriteLine(a * second);
            Console.WriteLine(a * first);
            Console.WriteLine(a * b);
        }
    }
}
