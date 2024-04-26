using System;

namespace Prob2675
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] str = new string[t];

            for (int i = 0; i < str.Length; i++)
                str[0] = null;

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int r = int.Parse(s[0]);
                string a = s[1];

                for (int j = 0; j < a.Length; j++)
                {
                    for (int k = 0; k < r; k++)
                        str[i] += a[j].ToString();
                }
            }

            for (int i = 0; i < t; i++)
                Console.WriteLine(str[i]);
        }
    }
}
