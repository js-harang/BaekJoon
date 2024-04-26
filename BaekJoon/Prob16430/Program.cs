using System;

namespace Prob16430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("{0} {1}", input[1] - input[0], input[1]);
        }
    }
}
