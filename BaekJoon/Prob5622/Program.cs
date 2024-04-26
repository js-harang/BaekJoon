using System;

namespace Prob5622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] <= 'C')
                    sum += 3;
                else if (s[i] <= 'F')
                    sum += 4;
                else if (s[i] <= 'I')
                    sum += 5;
                else if (s[i] <= 'L')
                    sum += 6;
                else if (s[i] <= 'O')
                    sum += 7;
                else if (s[i] <= 'S')
                    sum += 8;
                else if (s[i] <= 'V')
                    sum += 9;
                else
                    sum += 10;
            }

            Console.WriteLine();
        }
    }
}
