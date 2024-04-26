using System;

namespace Prob2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = input[0];
            int k = input[1];
            int flag = 0;
            int output = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    flag++;

                if (flag == k)
                {
                    output = i;
                    break;
                }
            }

            if (flag < k)
                output = 0;

            Console.WriteLine(output);
        }
    }
}
