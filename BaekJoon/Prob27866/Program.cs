using System;

namespace Prob27866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string str = s.Substring(num - 1, num - 1);
            Console.WriteLine(str);
        }
    }
}
