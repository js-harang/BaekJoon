using System;
using System.Linq;

namespace Prob4344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            float[] output = new float[c];

            for (int i = 0; i < c; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = input[0];
                input = input.Skip(1).ToArray();
                float avg = float.Parse(input.Average().ToString());
                int count = 0;

                for (int j = 0; j < n; j++)
                {
                    if (input[j] > avg)
                        count++;
                }

                output[i] = float.Parse(Math.Round(float.Parse(count.ToString()) / n * 100, 3).ToString());
            }

            for (int i = 0; i < c; i++)
                Console.WriteLine("{0:f3}%", output[i]);
        }
    }
}
