using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string, int k)
        {
            string answer = "";
            for (int i = 0; i < k; i++)
            {
                answer += my_string;
            }
            return answer;
        }

        public string solution2(string my_string, int k)
        {
            String answer = String.Concat(Enumerable.Repeat(my_string, k));
            return answer;
        }

        public string solution3(string my_string, int k)
        {
            return Enumerable.Range(0, k).Select(s => my_string).Aggregate((a, b) => a + b);
        }
    }
}
