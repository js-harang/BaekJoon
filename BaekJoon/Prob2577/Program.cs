using System;

namespace Prob2577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] output = new int[10];

            int sum = a * b * c;
            string sumS = sum.ToString();

            foreach (char character in sumS)
                output[int.Parse(character.ToString())]++;

            foreach (int i in output)
                Console.WriteLine(i);
        }
    }
}
