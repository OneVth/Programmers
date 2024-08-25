using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            int length = s.Length;

            if (length % 2 == 0)
                answer = s.Substring(length / 2 - 1, 2);
            else
                answer = s.Substring(length / 2, 1);

            return answer;
        }
    }
}
