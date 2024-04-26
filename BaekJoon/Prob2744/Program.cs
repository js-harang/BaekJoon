using System;

namespace Prob2744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] cInput = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
                cInput[i] = char.IsUpper(input[i]) ? char.ToLower(input[i]) : char.ToUpper(input[i]);

            Console.WriteLine(string.Join("", cInput));
        }
    }
}
