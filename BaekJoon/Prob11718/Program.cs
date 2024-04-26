using System;

namespace Prob11718
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                Console.WriteLine(s);

                if (string.IsNullOrEmpty(s))
                    break;
            }
        }
    }
}
