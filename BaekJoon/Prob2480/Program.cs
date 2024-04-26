using System;

namespace Prob2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);
            int num3 = int.Parse(s[2]);
            int reward = 0;

            if (num1 == num2 && num1 == num3)
                reward = 10000 + num1 * 1000;
            else if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                int highScore;

                if (num1 > num2 && num1 > num3)
                    highScore = num1;
                else if (num2 > num1 && num2 > num3)
                    highScore = num2;
                else
                    highScore = num3;

                reward = highScore * 100;
            }
            else
            {
                int sameScore = 0;

                if (num1 == num2 || num1 == num3)
                    sameScore = num1;
                else if (num2 == num3)
                    sameScore = num2;

                reward = 1000 + sameScore * 100;
            }

            Console.WriteLine(reward);
        }
    }
}
