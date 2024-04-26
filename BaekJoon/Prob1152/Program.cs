using System;

namespace Prob1152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().TrimStart(' ').TrimEnd(' ').Split(' ');

            int a = s.Length;

            if (s[0] == "")
                a = 0;

            Console.WriteLine(a);
        }
    }
}
