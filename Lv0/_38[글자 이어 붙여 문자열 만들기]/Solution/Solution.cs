using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int[] index_list)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < index_list.Length; i++)
            {
                sb.Append(my_string[index_list[i]]);
            }

            answer = sb.ToString();
            return answer;
        }
    }
}
