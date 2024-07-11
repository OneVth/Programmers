using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int k)
        {
            string answer = "";
            for (int i = 0; i < k; i++)
            {
                answer += my_string;
            }
            return answer;
        }
    }
}
