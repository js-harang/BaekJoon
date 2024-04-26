using System;
using System.Linq;
using System.Text;

namespace Prob1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                string reverse = new string(input.Reverse().ToArray());

                if (input == reverse)
                    output.Append("yes\n");
                else
                    output.Append("no\n");
            }

            Console.WriteLine(output);
        }
    }
}
