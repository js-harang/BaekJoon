using System;
using System.Linq;
using System.Text;

namespace Prob10757
{
    internal class Program
    {
        static int overflow = 0;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            StringBuilder result = new StringBuilder();

            string a, b;

            if (input[0].Length > input[1].Length)
            {
                a = new string(input[1].Reverse().ToArray());
                b = new string(input[0].Reverse().ToArray());
            }
            else
            {
                a = new string(input[0].Reverse().ToArray());
                b = new string(input[1].Reverse().ToArray());
            }

            for (int i = 0; i < a.Length; i++)
                result.Append(Overflow(int.Parse(a[i].ToString()), int.Parse(b[i].ToString())));

            for (int i = a.Length; i < b.Length; i++)
                result.Append(Overflow(0, int.Parse(b[i].ToString())));

            if (overflow != 0)
                result.Append(overflow);

            char[] resultChar = result.ToString().ToCharArray();

            string output = new string(resultChar.Reverse().ToArray());

            Console.WriteLine(output);
        }

        private static int Overflow(int a, int b)
        {
            int sum = a + b + overflow;
            overflow = 0;

            if (sum >= 10)
                overflow++;

            return (sum % 10);
        }
    }
}
