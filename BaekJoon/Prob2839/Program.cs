using System;

namespace Prob2839
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = 0;

            while (true)
            {
                if (input % 5 == 0)
                {
                    output += input / 5;
                    break;
                }

                input -= 3;
                output++;

                if (input <= 0)
                    break;
            }

            if (input < 0)
                Console.WriteLine(-1);
            else
                Console.WriteLine(output);
        }
    }
}
