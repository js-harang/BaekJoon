using System;

namespace Prob10872
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 1;

            for (int i = 2; i <= n; i++)
                output *= i;

            Console.WriteLine(output);
        }
    }
}
