using System;
using System.Linq;

namespace Prob2947
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] answer = { 1, 2, 3, 4, 5 };

            while (true)
            {
                if (Enumerable.SequenceEqual(input, answer))
                    break;

                for (int i = 0; i < 4; i++)
                {
                    if (input[i] > input[i + 1])
                        program.Swap(input, i, i + 1);
                }
            }
        }

        private void Swap(int[] input, int a, int b)
        {
            int temp = input[a];
            input[a] = input[b];
            input[b] = temp;

            foreach (int num in input)
                Console.Write($"{num} ");
            Console.WriteLine();
        }
    }
}
