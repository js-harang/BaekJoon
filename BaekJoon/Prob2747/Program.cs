using System;

namespace Prob2747
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] num = new int[input + 1];

            num[1] = 1;

            for (int i = 2; i <= input; i++)
                num[i] = num[i - 1] + num[i - 2];

            Console.WriteLine(num[input]);
        }
    }
}
