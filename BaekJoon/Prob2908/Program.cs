using System;
using System.Linq;

namespace Prob2908
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int num1 = int.Parse(new string(s[0].Reverse().ToArray()));
            int num2 = int.Parse(new string(s[1].Reverse().ToArray()));

            if (num1 > num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);
        }
    }
}
