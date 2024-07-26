using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] strArr)
        {
            string[] answer = new string[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0) answer[i] = strArr[i].ToLower();
                else answer[i] = strArr[i].ToUpper();
            }

            return answer;
        }
    }
}
