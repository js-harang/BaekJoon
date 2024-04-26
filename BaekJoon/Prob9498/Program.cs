using System;

namespace Prob9498
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string output;

            switch (input / 10)
            {
                case 10:
                    output = "A"; break;
                case 9:
                    output = "A"; break;
                case 8:
                    output = "B"; break;
                case 7:
                    output = "C"; break;
                case 6:
                    output = "D"; break;
                default:
                    output = "F"; break;
            }

            Console.WriteLine(output);
        }
    }
}
