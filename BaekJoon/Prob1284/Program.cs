using System;
using System.Collections.Generic;

namespace Prob1284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> output = new List<string>();
            int space;

            while (true)
            {
                input = Console.ReadLine();

                if (int.Parse(input) == 0)
                    break;

                space = input.Length + 1;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '1')
                        space += 2;
                    else if (input[i] == '0')
                        space += 4;
                    else
                        space += 3;
                }

                output.Add(space.ToString());
            }

            foreach (string s in output)
                Console.WriteLine(s);
        }
    }
}
