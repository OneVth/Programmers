using System;

namespace Solution
{
    public class Solution
    {
        public int solution1(string s)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < words.Length; i++)
            {
                if (s.Contains(words[i]))
                    s = s.Replace(words[i], i.ToString());
            }

            return int.Parse(s);
        }

        public int solution2(string s)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < words.Length; i++)
            {
                s = s.Replace(words[i], i.ToString());
            }

            return int.Parse(s);
        }
    }
}
