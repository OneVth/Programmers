using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string[] babbling)
        {
            int answer = 0;

            foreach (string s in babbling)
            {
                switch (s.Length)
                {
                    case 2:
                        if (s == "ye" || s == "ma")
                            answer++;
                        break;
                    case 3:
                        if (s == "aya" || s == "woo")
                            answer++;
                        break;
                    case 4:
                        if (s.Contains("ye") && s.Contains("ma"))
                            answer++;
                        break;
                    case 5:
                        if (
                            (s.Contains("ye") && s.Contains("aya")) || (s.Contains("ye") && s.Contains("woo")) ||
                            (s.Contains("ma") && s.Contains("aya")) || (s.Contains("ma") && s.Contains("woo"))
                          )
                            answer++;
                        break;
                    case 6:
                        if (s.Contains("aya") && s.Contains("woo"))
                            answer++;
                        break;
                    case 7:
                        if (
                            (s.Contains("ye") && s.Contains("ma") && s.Contains("aya")) ||
                            (s.Contains("ye") && s.Contains("ma") && s.Contains("woo"))
                        )
                            answer++;
                        break;
                    case 8:
                        if (
                            (s.Contains("aya") && s.Contains("woo") && s.Contains("ye")) ||
                            (s.Contains("aya") && s.Contains("woo") && s.Contains("ma"))
                        )
                            answer++;
                        break;
                    case 10:
                        if (s.Contains("ye") && s.Contains("ma") && s.Contains("woo") && s.Contains("aya"))
                            answer++;
                        break;
                }
            }

            return answer;
        }

        public int solution2(string[] babbling)
        {
            int answer = 0;
            string[] talkable = { "aya", "ye", "woo", "ma" };

            for(int i = 0; i < babbling.Length; i++)
            {
                string word = babbling[i];
                foreach(string able in talkable)
                {
                    word = word.Replace(able, " ");
                }
                if (string.IsNullOrWhiteSpace(word))
                    answer++;
            }

            return answer;
        }
    }
}
