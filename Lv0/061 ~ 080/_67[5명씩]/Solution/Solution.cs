using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] names)
        {
            int length = (names.Length + 5 - 1) / 5;
            string[] answer = new string[length];

            for (int i = 0; i < length; i++)
                answer[i] = names[i * 5];

            return answer;
        }
    }
}
