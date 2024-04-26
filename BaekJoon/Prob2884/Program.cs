using System;

namespace Prob2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int h = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            if (m >= 45)
                m -= 45;
            else
            {
                if (h > 0)
                    h -= 1;
                else
                    h = 23;

                m += 15;
            }

            Console.WriteLine("{0} {1}", h, m);
        }
    }
}
