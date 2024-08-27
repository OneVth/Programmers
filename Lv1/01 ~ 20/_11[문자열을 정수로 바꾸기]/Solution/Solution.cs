using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case '+':
                        answer += int.Parse(sb.ToString());
                        sb.Clear();
                        break;
                    case '-':
                        answer -= int.Parse(sb.ToString());
                        sb.Clear();
                        break;
                    default:
                        sb.Insert(0, s[i]);
                        break;
                }
            }

            // 맨 앞이 부호가 아닐경우 sb 더해주기
            if (s[0] != '+' && s[0] != '-')
                answer += int.Parse(sb.ToString());

            return answer;
        }
    }
}
