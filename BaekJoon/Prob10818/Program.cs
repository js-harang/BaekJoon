using System;
using System.Linq;

namespace Prob10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("{0} {1}", input.Min(), input.Max());
        }
    }
}
