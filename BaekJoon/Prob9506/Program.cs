using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob9506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            List<string> strList = new List<string>();

            while (true)
            {
                input = int.Parse(Console.ReadLine());
                string str = input + " = 1 + ";

                if (input == -1)
                {
                    break;
                }

                List<int> list = new List<int>();

                for (int i = 2; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        list.Add(i);
                    }
                }

                int sum = list.Sum() + 1;

                if (sum == input)
                {
                    str += String.Join(" + ", list);
                    strList.Add(str);
                }
                else
                {
                    strList.Add(input + " is NOT perfect.");
                }
            }

            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
