using System;
using System.Linq;

namespace Prob1932
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] output = new int[size];

            output[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i < size; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int index = input.Length - 1;

                output[index] = output[index - 1] + input[index];
                index--;

                for (int j = index; j > 0; j--)
                    output[j] = output[j - 1] >= output[j] ? output[j - 1] + input[j] : output[j] + input[j];

                output[0] += input[0];

                foreach (int j in output)
                    Console.WriteLine(j);
            }

            Console.WriteLine(output.Max());
        }
    }
}
