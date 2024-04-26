using System;

namespace Prob25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                sum += (a * b);
            }

            if (sum == amount)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
