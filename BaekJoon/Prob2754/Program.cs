using System;

namespace Prob2754
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            float output = 0;

            switch (input)
            {
                case "A+":
                    output = 4.3f; break;
                case "A0":
                    output = 4.0f; break;
                case "A-":
                    output = 3.7f; break;
                case "B+":
                    output = 3.3f; break;
                case "B0":
                    output = 3.0f; break;
                case "B-":
                    output = 2.7f; break;
                case "C+":
                    output = 2.3f; break;
                case "C0":
                    output = 2.0f; break;
                case "C-":
                    output = 1.7f; break;
                case "D+":
                    output = 1.3f; break;
                case "D0":
                    output = 1.0f; break;
                case "D-":
                    output = 0.7f; break;
                case "F":
                    output = 0.0f; break;
            }

            Console.WriteLine("{0:F1}", output);
        }
    }
}
