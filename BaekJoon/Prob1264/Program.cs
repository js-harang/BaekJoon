using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Prob1264
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            List<int> output = new List<int>();

            for (int i = 0; ; i++)
            {
                string input = Regex.Replace(Console.ReadLine(), " ", "");

                if (input == "#")
                    break;

                input = input.ToLower();
                string newInput = program.CharRemove(input);

                output.Add(input.Length - newInput.Length);
            }

            foreach (int i in output)
                Console.WriteLine(i);
        }

        private string CharRemove(string input)
        {
            string[] charsToRemove = new string[] { "a", "e", "i", "o", "u" };

            foreach (string c in charsToRemove)
                input = input.Replace(c, string.Empty);

            return input;
        }
    }
}
