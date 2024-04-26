using System;
using System.Collections.Generic;
using System.Text;

namespace Prob10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1]));
                        break;
                    case "pop":
                        if (stack.Count == 0)
                            output.Append(-1 + "\n");
                        else
                            output.Append(stack.Pop() + "\n");
                        break;
                    case "size":
                        output.Append(stack.Count + "\n");
                        break;
                    case "empty":
                        if (stack.Count == 0)
                            output.Append(1 + "\n");
                        else
                            output.Append(0 + "\n");
                        break;
                    case "top":
                        if (stack.Count == 0)
                            output.Append(-1 + "\n");
                        else
                            output.Append(stack.Peek() + "\n");
                        break;
                }
            }

            if (output.Length > 0)
                output.Remove(output.Length - 1, 1);

            Console.WriteLine(output);
        }
    }
}
