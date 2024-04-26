using System;

namespace Prob1076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string[] colors = new string[3];
            long output;

            for (int i = 0; i < 3; i++)
                colors[i] = Console.ReadLine();

            program.Resistance(colors);

            output = (long.Parse(colors[0]) * 10 + long.Parse(colors[1])) * long.Parse(Math.Pow(10, int.Parse(colors[2])).ToString());

            Console.WriteLine(output);
        }

        public void Resistance(string[] colors)
        {
            for (int i = 0; i < 3; i++)
            {
                switch (colors[i])
                {
                    case "black":
                        colors[i] = 0.ToString();
                        break;
                    case "brown":
                        colors[i] = 1.ToString();
                        break;
                    case "red":
                        colors[i] = 2.ToString();
                        break;
                    case "orange":
                        colors[i] = 3.ToString();
                        break;
                    case "yellow":
                        colors[i] = 4.ToString();
                        break;
                    case "green":
                        colors[i] = 5.ToString();
                        break;
                    case "blue":
                        colors[i] = 6.ToString();
                        break;
                    case "violet":
                        colors[i] = 7.ToString();
                        break;
                    case "grey":
                        colors[i] = 8.ToString();
                        break;
                    case "white":
                        colors[i] = 9.ToString();
                        break;
                }
            }

        }
    }
}
