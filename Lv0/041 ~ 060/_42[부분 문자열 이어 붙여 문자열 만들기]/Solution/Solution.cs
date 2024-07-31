using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string[] my_strings, int[,] parts)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < my_strings.Length; i++)
            {
                int s = parts[i, 0];
                int e = parts[i, 1];

                sb.Append(my_strings[i].Substring(s, e - s + 1));
            }

            answer = sb.ToString();
            return answer;
        }
    }
}
