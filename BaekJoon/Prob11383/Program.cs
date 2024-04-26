using System;

namespace Prob11383
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string input = null;
            string output = null;
            string increase = null;

            for (int i = 0; i < num[0]; i++)
                input += Console.ReadLine();

            for (int i = 0; i < num[0]; i++)
                output += Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                increase += input[i];
                increase += input[i];
            }

            if (output == increase)
                Console.WriteLine("Eyfa");
            else
                Console.WriteLine("Not Eyfa");
        }
    }
}
