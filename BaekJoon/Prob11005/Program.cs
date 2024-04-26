using System;
using System.Linq;

namespace Prob11005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int temp = 0;
            string output = null;

            while (n > 0)
            {
                temp = n % b;
                n /= b;

                if (temp > 9)
                {
                    temp += 55;
                    output += (char)temp;
                }
                else
                    output += temp;
            }

            output = new string(output.Reverse().ToArray());

            Console.WriteLine(output);
        }
    }
}
