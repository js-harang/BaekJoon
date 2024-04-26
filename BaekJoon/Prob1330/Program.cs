using System;

namespace Prob1330
{
    internal class Program
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if (a > b)
                Console.WriteLine(">");
            else if (a < b)
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
