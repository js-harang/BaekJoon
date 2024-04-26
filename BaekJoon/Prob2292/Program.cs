using System;

namespace Prob2292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) - 2;
            int line = 0;

            if (n < 0)
                Console.WriteLine(1);

            for (line = 1; n - (line - 1) * 6 >= 0; line++)
            {
                n -= (line - 1) * 6;

                if (n / (line * 6) == 0)
                    Console.WriteLine(line + 1);
            }
        }
    }
}
