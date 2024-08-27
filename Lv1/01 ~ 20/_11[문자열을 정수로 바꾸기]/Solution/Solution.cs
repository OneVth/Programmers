using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string s)
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

        public int solution2(string s)
        {
            int answer = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (c == '+' || c == '-')
                {
                    Reverse(sb);
                    answer += (c == '+') ? int.Parse(sb.ToString()) : -int.Parse(sb.ToString());
                    sb.Clear();
                }
                else
                    sb.Append(c);
            }

            if(sb.Length > 0)
            {
                Reverse(sb);
                answer += int.Parse(sb.ToString());
            }

            return answer;
        }

        void Reverse(StringBuilder sb)
        {
            char t;
            int end = sb.Length - 1;
            int start = 0;

            while (end - start > 0)
            {
                t = sb[end];
                sb[end] = sb[start];
                sb[start] = t;
                start++;
                end--;
            }
        }

        public int solution3(string s)
        {
            int result = 0;
            int currentNumber = 0;
            char operation = '+';

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (char.IsDigit(currentChar))
                    currentNumber = currentNumber * 10 + (currentChar - '0');

                if (!char.IsDigit(currentChar) && currentChar != ' ' || i == s.Length - 1)
                {
                    if (operation == '+')
                        result += currentNumber;
                    else if (operation == '-')
                        result -= currentNumber;

                    operation = currentChar;
                    currentNumber = 0;
                }
            }

            return result;
        }
    }
}
