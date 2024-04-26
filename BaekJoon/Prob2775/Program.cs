using System;

namespace Prob2775
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] output = new int[t];

            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] s = new int[k + 1, n];

                for (int j = 0; j < k + 1; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (j == 0)
                            s[j, l] = l + 1;
                        else
                        {
                            if (l == 0)
                                s[j, l] = 1;
                            else
                                s[j, l] = s[j, l - 1] + s[j - 1, l];
                        }
                    }
                }

                output[i] = s[k, n - 1];
            }

            Console.WriteLine(string.Join("\n", output));
        }
    }
}
