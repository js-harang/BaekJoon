using System;

namespace Prob25206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] info = new string[20];
            float sum = 0f;
            float sum2 = 0f;
            float flag = 0f;

            for (int i = 0; i < info.Length; i++)
                info[i] = Console.ReadLine();

            for (int i = 0; i < info.Length; i++)
            {
                string[] s = info[i].Split(' ');

                float score = float.Parse(s[1]);
                string strGrade = s[2];
                float grade = 0;

                switch (strGrade)
                {
                    case "A+":
                        grade = 4.5f;
                        sum2 += score;
                        break;
                    case "A0":
                        grade = 4.0f;
                        sum2 += score;
                        break;
                    case "B+":
                        grade = 3.5f;
                        sum2 += score;
                        break;
                    case "B0":
                        grade = 3.0f;
                        sum2 += score;
                        break;
                    case "C+":
                        grade = 2.5f;
                        sum2 += score;
                        break;
                    case "C0":
                        grade = 2.0f;
                        sum2 += score;
                        break;
                    case "D+":
                        grade = 1.5f;
                        sum2 += score;
                        break;
                    case "D0":
                        grade = 1.0f;
                        sum2 += score;
                        break;
                    case "F":
                        grade = 0f;
                        sum2 += score;
                        break;
                    case "P":
                        grade = 0f;
                        flag++;
                        break;
                }

                sum += score * grade;
            }

            float avg = sum / sum2;

            Console.WriteLine(avg);
        }
    }
}
