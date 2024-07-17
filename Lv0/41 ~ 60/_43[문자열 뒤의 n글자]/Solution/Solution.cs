using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int n)
        {
            string answer = "";
            int length = my_string.Length;

            answer += my_string.Substring(length - n);

            return answer;
        }
    }
}
