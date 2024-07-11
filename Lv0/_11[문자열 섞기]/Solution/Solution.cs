using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string str1, string str2)
        {
            string answer = "";
            char[] chars1 = str1.ToCharArray();
            char[] chars2 = str2.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                answer += chars1[i];
                answer += chars2[i];
            }
            return answer;
        }

        public string solution2(string str1, string str2)
        {
            string answer = "";
            
            for (int i = 0; i < str1.Length; i++)
            {
                answer += string.Format("{0}{1}", str1[i], str2[i]);
            }
            return answer;
        }

        public string solution3(string str1, string str2)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str1.Length; i++)
            {
                sb.Append(str1[i]);
                sb.Append(str2[i]);
            }

            answer = sb.ToString();

            return answer;
        }
    }
}
