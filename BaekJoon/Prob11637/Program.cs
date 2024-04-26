using System;
using System.Linq;
using System.Text;

namespace Prob11637
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            StringBuilder output = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] input = new int[n];

                for (int j = 0; j < n; j++)
                    input[j] = int.Parse(Console.ReadLine());

                if (program.MaxDetection(input, input.Max(), n))
                {
                    if (input.Max() > input.Sum() / 2)
                        output.Append($"majority winner {Array.IndexOf(input, input.Max()) + 1}\n");
                    else
                        output.Append($"minority winner {Array.IndexOf(input, input.Max()) + 1}\n");
                }
                else
                    output.Append("no winner\n");
            }

            output.Remove(output.Length - 1, 1);

            Console.WriteLine(output);
        }

        private bool MaxDetection(int[] input, int max, int n)
        {
            int flag = 0;

            for (int i = 0; i < n; i++)
            {
                if (input[i] == max)
                    flag++;

                if (flag >= 2)
                    break;
            }

            if (flag >= 2)
                return false;
            else
                return true;
        }
    }
}
