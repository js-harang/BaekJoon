using System;
using System.Linq;

namespace Prob5073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = null;

            while (true)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (input.Sum() == 0)
                    break;

                if (input.Max() >= input.Sum() - input.Max())
                    output += "Invalid\n";
                else if (input[0] == input[1] && input[0] == input[2])
                    output += "Equilateral\n";
                else if (input[0] == input[1] || input[0] == input[2] || input[1] == input[2])
                    output += "Isosceles\n";
                else
                    output += "Scalene\n";
            }

            Console.WriteLine(output.TrimEnd('\n'));
        }
    }
}
