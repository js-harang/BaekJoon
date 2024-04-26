using System;

namespace Prob25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop;
            string s = null;

            int n = int.Parse(Console.ReadLine());

            if (n % 4 == 0)
                loop = n / 4;
            else
                loop = n / 4 + 1;

            for (int i = 0; i < loop; i++)
                s += "long ";

            Console.WriteLine(s + "int");
        }
    }
}
