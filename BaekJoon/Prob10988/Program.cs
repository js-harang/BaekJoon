using System;
using System.Linq;

namespace Prob10988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string reverse = new string(s.Reverse().ToArray());

            if (s == reverse)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
