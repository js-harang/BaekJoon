using System;
using System.Text;

namespace Prob2742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder s = new StringBuilder();

            for (int i = n; i > 0; i--)
                s.Append(i + "\n");

            Console.WriteLine(s);
        }
    }
}
