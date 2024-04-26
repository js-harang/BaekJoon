using System;
using System.Linq;

namespace Prob2309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[9];
            int answer;

            for (int i = 0; i < 9; i++)
                input[i] = int.Parse(Console.ReadLine());

            answer = input.Sum() - 100;

            Array.Sort(input);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (input[i] + input[j] == answer)
                    {
                        if (i > j)
                        {
                            input = input.Where(num => num != input[i]).ToArray();
                            input = input.Where(num => num != input[j]).ToArray();
                        }
                        else if (i < j)
                        {
                            input = input.Where(num => num != input[j]).ToArray();
                            input = input.Where(num => num != input[i]).ToArray();
                        }

                        break;
                    }
                }

                if (input.Length == 7)
                    break;
            }

            foreach (int i in input)
                Console.WriteLine(i);
        }
    }
}
