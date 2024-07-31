using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string, int n)
        {
            string answer = "";
            int length = my_string.Length;

            answer += my_string.Substring(length - n);

            return answer;
        }

        public string solution2(string my_string, int n)
        {
            return my_string.Remove(0, my_string.Length - n);
        }

        public string solution3(string my_string, int n)
        {
            string answer = "";
            int num = my_string.Length - n;

            for(int i = num; i < my_string.Length; i++)
            {
                answer += my_string[i];
            }

            return answer;
        }
    }
}
