using System;
using System.Collections.Generic;
using System.Text;

namespace Soulution
{
    internal class Solution
    {
        public string solution(string my_string, string overwrite_string, int s)
        {
            string answer = "";
            answer = my_string.Remove(s, overwrite_string.Length);
            answer = answer.Insert(s, overwrite_string);
            return answer;
        }
    }
}
