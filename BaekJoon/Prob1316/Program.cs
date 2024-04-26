using System;

namespace Prob1316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] flag = new bool[26];
            bool isGroup;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                isGroup = true;
                for (int j = 0; j < flag.Length; j++)
                    flag[j] = false;

                flag[s[0] - 97] = true;

                for (int j = 1; j < s.Length; j++)
                {
                    if (s[j - 1] != s[j])
                    {
                        if (flag[s[j] - 'a'] == true)
                        {
                            isGroup = false;
                            break;
                        }

                        flag[s[j] - 'a'] = true;
                    }
                }

                if (isGroup)
                    sum++;
            }

            Console.WriteLine(sum);
        }
    }
}
