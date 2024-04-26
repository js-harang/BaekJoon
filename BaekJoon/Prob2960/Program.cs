using System;
using System.Linq;

namespace Prob2960
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] nums = new int[input[0] - 1];
            int output = 0;
            int flag = 0;

            for (int i = 2; i <= input[0]; i++)
                nums[i - 2] = i;

            for (int i = 1; flag < input[1]; i++)
            {
                int min = nums.Min();

                for (int j = 1; j <= input[0] / min; j++)
                {
                    if (Array.Find(nums, element => element == min * j) == 0)
                        continue;
                    nums = nums.Where(element => element != min * j).ToArray();

                    flag++;

                    if (flag == input[1])
                    {
                        output = min * j;
                        break;
                    }
                }

                if (flag == input[1]) break;
            }

            Console.WriteLine(output);
        }
    }
}
