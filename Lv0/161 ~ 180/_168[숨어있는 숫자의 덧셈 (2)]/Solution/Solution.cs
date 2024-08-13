using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string[] array = my_string.Split(alpha);

            foreach (string s in array)
            {
                if (int.TryParse(s, out int num))
                    answer += num;
            }

            return answer;
        }
    }
}
