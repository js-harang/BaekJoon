using System;

namespace Prob5063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string output = null;

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int r = int.Parse(input[0]);
                int e = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                if (r < e - c)
                    output += "advertise\n";
                else if (r > e - c)
                    output += "do not advertise\n";
                else
                    output += "does not matter\n";
            }

            Console.WriteLine(output.TrimEnd('\n'));
        }
    }
}
