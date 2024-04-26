using System;

namespace Prob2738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            string[,] s1 = new string[n, m];
            string[,] s2 = new string[n, m];
            int[,] result = new int[n, m];

            for (int i = 0; i < n * 2; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    if (i < n)
                        s1[i, j] = input[j];
                    else
                        s2[i - n, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = int.Parse(s1[i, j]) + int.Parse(s2[i, j]);
                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
