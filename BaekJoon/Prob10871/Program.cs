using System;
using System.Text;

namespace Prob10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            StringBuilder output = new StringBuilder();

            string[] nums = Console.ReadLine().Split(' ');

            for (int i = 0; i < input[0]; i++)
            {
                if (int.Parse(nums[i]) < input[1])
                    output.Append(nums[i] + " ");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
