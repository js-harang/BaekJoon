using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(input[1]));
                        break;
                    case "pop":
                        if (queue.Count == 0)
                            output.Append(-1 + "\n");
                        else
                            output.Append(queue.Dequeue() + "\n");
                        break;
                    case "size":
                        output.Append(queue.Count + "\n");
                        break;
                    case "empty":
                        if (queue.Count == 0)
                            output.Append(1 + "\n");
                        else
                            output.Append(0 + "\n");
                        break;
                    case "front":
                        if (queue.Count == 0)
                            output.Append(-1 + "\n");
                        else
                            output.Append(queue.Peek() + "\n");
                        break;
                    case "back":
                        if (queue.Count == 0)
                            output.Append(-1 + "\n");
                        else
                            output.Append(queue.Last() + "\n");
                        break;
                }
            }

            if (output.Length > 0)
                output.Remove(output.Length - 1, 1);

            Console.WriteLine(output);
        }
    }
}
