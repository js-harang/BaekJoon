using System;
using System.Linq;
using System.Text;

namespace Prob5800
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int k = int.Parse(Console.ReadLine());
            int gap;
            StringBuilder output = new StringBuilder();

            for (int i = 1; i <= k; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = input[0];
                input = input.Skip(1).ToArray();
                Array.Sort(input);

                gap = program.LargestGap(input);

                output.Append($"Class {i}\n");
                output.Append($"Max {input.Max()}, Min {input.Min()}, Largest gap {gap}\n");
            }

            output.Remove(output.Length - 1, 1);

            Console.WriteLine(output);
        }

        private int LargestGap(int[] input)
        {
            int[] gap = new int[input.Length - 1];

            for (int i = 0; i < gap.Length; i++)
                gap[i] = input[i + 1] - input[i];

            return gap.Max();
        }
    }
}
