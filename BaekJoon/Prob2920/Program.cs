using System;
using System.Linq;

namespace Prob2920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", null);
            string a = "12345678";
            string b = new string(a.Reverse().ToArray());

            if (input == a)
                Console.WriteLine("ascending");
            else if (input == b)
                Console.WriteLine("descending");
            else
                Console.WriteLine("mixed");
        }
    }
}
