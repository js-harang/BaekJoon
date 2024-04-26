using System;

namespace Prob1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            int[] numbers = new int[26];
            int max = 0;
            char result = '?';

            for (int i = 0; i < input.Length; i++)
            {
                numbers[input[i] - 'A']++;

                if (numbers[input[i] - 'A'] > max)
                {
                    max = numbers[input[i] - 'A'];
                    result = Convert.ToChar(input[i]);
                }
                else if (numbers[input[i] - 'A'] == max)
                    result = '?';
            }

            Console.WriteLine(result);
        }
    }
}
