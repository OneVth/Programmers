using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string[] order)
        {
            int answer = 0;

            foreach (string s in order)
            {
                if (s == "iceamericano" || s == "americanoice" || s == "hotamericano" || s == "americanohot" || s == "americano" || s == "anything")
                    answer += 4500;
                else
                    answer += 5000;
            }

            return answer;
        }
    }
}
