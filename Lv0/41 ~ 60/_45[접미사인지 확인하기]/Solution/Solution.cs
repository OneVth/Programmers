using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string my_string, string is_suffix)
        {
            int answer = 0;
            List<string> strList = new List<string>();

            for (int i = 0; i < my_string.Length; i++)
            {
                strList.Add(my_string.Substring(i));
            }

            answer = strList.Contains(is_suffix) ? 1 : 0;
            return answer;
        }
    }
}
