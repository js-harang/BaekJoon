using System;

namespace Prob9086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            string[] s = new string[t];

            for (int i = 0; i < s.Length; i++)
            {
                string str = Console.ReadLine();
                s[i] = str.Substring(0, 1) + str.Substring(str.Length - 1, 1);
            }

            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
        }
    }
}
