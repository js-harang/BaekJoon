using System;
using System.Text;

namespace Prob2845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int participant = input[0] * input[1];
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < nums.Length; i++)
                output.Append((nums[i] - participant).ToString() + " ");

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
