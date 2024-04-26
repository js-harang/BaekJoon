using System;

namespace Prob1978
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int output = 0;

            for (int i = 0; i < input.Length; i++)
            {
                output++;

                if (input[i] == 1)
                    output--;

                for (int j = 2; j < input[i]; j++)
                {
                    if (input[i] % j == 0)
                    {
                        output--;
                        break;
                    }

                }
            }

            Console.WriteLine(output);
        }
    }
}
