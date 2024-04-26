using System;

namespace Prob2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] target = new string[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            foreach (string s in target)
                input = input.Replace(s, "_");

            Console.WriteLine(input.Length);
        }
    }
}
