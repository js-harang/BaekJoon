using System;
using System.IO;

namespace Prob10989
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[10000];

            for (int i = 0; i < n; i++)
                nums[int.Parse(Console.ReadLine()) - 1]++;

            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0)
                {
                    output.WriteLine(i + 1);
                    nums[i]--;
                }
            }

            input.Close();
            output.Close();
        }
    }
}
