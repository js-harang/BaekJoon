using System;

namespace Prob2217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int output = 0;

            for (int i = 0; i < n; i++)
                input[i] = int.Parse(Console.ReadLine());

            Array.Sort(input);

            for (int i = 0; i < n; i++)
            {
                int weight = input[i] * (n - i);

                if (weight > output)
                    output = weight;
            }

            Console.WriteLine(output);
        }
    }
}
