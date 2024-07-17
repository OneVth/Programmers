using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string my_string)
        {
            string[] answer = new string[] { };
            List<string> strList = new List<string>();

            for (int i = 0; i < my_string.Length; i++)
            {
                strList.Add(my_string.Substring(i));
            }

            answer = strList.OrderBy(o => o).ToArray();
            return answer;
        }
    }
}
