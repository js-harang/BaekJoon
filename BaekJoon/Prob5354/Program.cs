using System;

namespace Prob5354
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string output = null;

            for (int i = 0; i < t; i++)
            {
                int input = int.Parse(Console.ReadLine());

                for (int j = 0; j < input; j++)
                {
                    for (int k = 0; k < input; k++)
                    {
                        if (j == 0 || j == input - 1 || k == 0 || k == input - 1)
                            output += "#";
                        else
                            output += "J";
                    }

                    output += "\n";
                }

                output += "\n";
            }

            Console.WriteLine(output.TrimEnd('\n'));
        }
    }
}
