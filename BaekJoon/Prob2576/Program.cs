using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            int sum = 0;
            int flag = 0;

            for (int i = 0; i < 7; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    input.Add(num);
                    sum += num;
                    flag++;
                }
            }

            if (sum == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(input.Min());
            }
        }
    }
}
