using System;
using System.Linq;

namespace Prob2592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[10];
            int count = 1;
            int flag = 1;

            for (int i = 0; i < 10; i++)
                input[i] = int.Parse(Console.ReadLine());

            int mode = input[0];

            Array.Sort(input);

            for (int i = 1; i < 10; i++)
            {
                if (input[i] == input[i - 1])
                {
                    flag++;

                    if (flag > count)
                    {
                        mode = input[i];
                        count = flag;
                    }
                }
                else
                    flag = 1;
            }

            Console.WriteLine(input.Average());
            Console.WriteLine(mode);
        }
    }
}
