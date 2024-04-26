using System;
using System.Text;

namespace Prob11659
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] sumArray = new int[array.Length + 1];

            sumArray[0] = 0;
            for (int i = 1; i <= array.Length; i++)
                sumArray[i] = sumArray[i - 1] + array[i - 1];

            for (int i = 0; i < num[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                output.Append(sumArray[input[1]] - sumArray[input[0] - 1] + "\n");
            }

            Console.WriteLine(output);
        }
    }
}
