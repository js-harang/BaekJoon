using System;

namespace Prob10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] e = new int[26];
            string s = Console.ReadLine();

            for (int i = 0; i < e.Length; i++)
                e[i] = -1;

            for (int i = 0; i < s.Length; i++)
            {
                int asc = (int)(s[i]) - 97;

                if (e[asc] == -1)
                    e[asc] = i;
            }

            for (int i = 0; i < e.Length; i++)
                Console.Write(e[i] + " ");
        }
    }
}
