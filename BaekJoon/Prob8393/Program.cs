using System;
using System.Linq;

namespace Prob8393
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[input];

            for (int i = 0; i < input; i++)
                nums[i] = i + 1;

            Console.WriteLine(nums.Sum());
        }
    }
}
