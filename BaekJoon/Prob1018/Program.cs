using System;
using System.Linq;

namespace Prob1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            string[] input = new string[n];
            int[] bStart = new int[(n - 8 + 1) * (m - 8 + 1)];
            int[] wStart = new int[(n - 8 + 1) * (m - 8 + 1)];
            string[] s = new string[(n - 8 + 1) * (m - 8 + 1)];

            for (int i = 0; i < input.Length; i++)
                input[i] = Console.ReadLine();

            int flag = 0;

            for (int i = 0; i <= n - 8; i++)
            {
                for (int j = 0; j <= n - 8; j++)
                {
                    if (j % 2 == 0)
                        s[flag].Insert(s.Length, input[j].Substring(j, 8));
                    else
                        s[flag].Insert(s.Length, new string(input[j].Substring(j, 8).Reverse().ToArray()));

                    flag++;
                }
            }

            for (int i = 0; i < (n - 8 + 1) * (m - 8 + 1); i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (s[i][j] == 'B')
                            bStart[j]++;
                        else
                            wStart[j]++;
                    }
                    else
                    {
                        if (s[i][j] == 'B')
                            wStart[j]++;
                        else
                            bStart[j]++;
                    }
                }
            }
        }
    }
}
