using System;

namespace Prob11720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
                sum += int.Parse(s[i].ToString());

            Console.WriteLine(sum);
        }
    }
}
