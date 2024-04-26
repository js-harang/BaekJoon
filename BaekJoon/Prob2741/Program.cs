using System;
using System.Text;

namespace Prob2741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < n; i++)
                s.Append(i + 1 + "\n");

            Console.WriteLine(s);
        }
    }
}
