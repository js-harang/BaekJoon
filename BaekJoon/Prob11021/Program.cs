using System;

namespace Prob11021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = null;

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                answer += ($"Case #{i + 1}: {a + b}\n");
            }

            Console.WriteLine(answer.ToString());
        }
    }
}
