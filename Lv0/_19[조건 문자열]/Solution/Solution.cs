using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution(string ineq, string eq, int n, int m)
        {
            int answer = 0;

            switch (ineq)
            {
                case "<":
                    if (eq == "=") answer = n <= m ? 1 : 0;
                    else if (eq == "!") answer = n < m ? 1 : 0;
                    break;
                case ">":
                    if (eq == "=") answer = n >= m ? 1 : 0;
                    else if (eq == "!") answer = n > m ? 1 : 0;
                    break;
                default:
                    break;
            }

            return answer;
        }
    }
}
