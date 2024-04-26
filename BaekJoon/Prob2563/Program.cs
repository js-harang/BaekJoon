using System;

namespace Prob2563
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[100, 100];

            int count = int.Parse(Console.ReadLine());
            int flag = 0;

            for (int i = 0; i < count; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int first = int.Parse(s[1]);
                int second = int.Parse(s[0]);

                for (int j = first - 1; j < first + 9; j++)
                {
                    for (int k = second - 1; k < second + 9; k++)
                    {
                        if (a[j, k] != 1)
                        {
                            a[j, k] = 1;
                            flag++;
                        }
                    }
                }
            }

            Console.WriteLine(flag);
        }
    }
}
