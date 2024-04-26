using System;
using System.Text;

namespace Prob11660
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[,] table = new int[input[0], input[0]];
            int[,] sumTable = new int[input[0], input[0]];
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input[0]; i++)
            {
                int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < input[0]; j++)
                    table[i, j] = row[j];
            }

            for (int i = 0; i < input[0]; i++)
            {
                for (int j = 0; j < input[0]; j++)
                {
                    if (i == 0)
                    {
                        if (i == 0 && j == 0)
                            sumTable[i, j] = table[i, j];
                        else
                            sumTable[i, j] = sumTable[i, j - 1] + table[i, j];
                    }
                    else if (j == 0)
                        sumTable[i, j] = sumTable[i - 1, j] + table[i, j];
                    else
                        sumTable[i, j] = sumTable[i, j - 1] + sumTable[i - 1, j] - sumTable[i - 1, j - 1] + table[i, j];
                }
            }

            for (int i = 0; i < input[1]; i++)
            {
                int[] location = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int x1 = location[0] - 1;
                int y1 = location[1] - 1;
                int x2 = location[2] - 1;
                int y2 = location[3] - 1;

                int sum = sumTable[x2, y2];

                if (!(x1 == 0 && y1 == 0))
                {
                    if (x1 == 0)
                        sum -= sumTable[x2, y1 - 1];
                    else if (y1 == 0)
                        sum -= sumTable[x1 - 1, y2];
                    else
                        sum += sumTable[x1 - 1, y1 - 1] - sumTable[x2, y1 - 1] - sumTable[x1 - 1, y2];
                }

                output.Append(sum + "\n");
            }

            Console.Write(output);
        }
    }
}
