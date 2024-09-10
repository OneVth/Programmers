using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string[] canPronounce = { "aya", "ye", "woo", "ma" };

            foreach (string s in babbling)
            {
                string temp = s;
                foreach (string pronounce in canPronounce)
                {
                    if (temp.Contains(pronounce + pronounce)) // 연속 중복 확인
                        continue;

                    temp = temp.Replace(pronounce, " ");
                }
                if (string.IsNullOrWhiteSpace(temp))
                    answer++;
            }
            return answer;
        }
    }
}
