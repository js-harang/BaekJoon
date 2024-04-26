using System;

namespace Prob5086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            while (true)
            {
                string flag = null;

                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                if (a == 0 && b == 0)
                    break;

                if (b % a == 0)
                    flag = "factor";
                else if (a % b == 0)
                    flag = "multiple";
                else
                    flag = "neither";

                s += flag + ' ';
            }

            string[] output = s.Split(' ');

            for (int i = 0; i < output.Length; i++)
                Console.WriteLine(output[i]);
        }
    }
}
