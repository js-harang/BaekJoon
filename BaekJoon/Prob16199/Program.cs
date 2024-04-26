using System;

namespace Prob16199
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if (input2[1] > input1[1] || (input2[1] == input1[1] && input2[2] >= input1[2]))
                Console.WriteLine(input2[0] - input1[0]);
            else
            {
                if (input2[0] - input1[0] - 1 < 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(input2[0] - input1[0] - 1);
            }
            Console.WriteLine(input2[0] - input1[0] + 1);
            Console.WriteLine(input2[0] - input1[0]);
        }
    }
}
