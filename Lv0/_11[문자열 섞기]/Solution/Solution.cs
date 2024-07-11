using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public string solution(string str1, string str2)
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
    }
}
