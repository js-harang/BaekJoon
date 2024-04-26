using System;

namespace Prob2745
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            string strb = s[0];
            int[] b = new int[strb.Length];
            int n = int.Parse(s[1]);

            int sum = 0;

            for (int i = 0; i < strb.Length; i++)
            {
                if (!int.TryParse(strb[i].ToString(), out b[i]))
                    b[i] = (int)strb[i] - 55;

                sum += b[i] * (int)Math.Pow(n, strb.Length - i - 1);
            }

            Console.WriteLine(sum);
        }
    }
}
