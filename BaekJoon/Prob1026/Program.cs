using System;

namespace Prob1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] inputB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int output = 0;

            Array.Sort(inputA);
            Array.Sort(inputB);
            Array.Reverse(inputB);

            for (int i = 0; i < n; i++)
                output += inputA[i] * inputB[i];

            Console.WriteLine(output);
        }
    }
}
