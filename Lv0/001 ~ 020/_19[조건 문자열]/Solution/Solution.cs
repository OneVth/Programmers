using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string ineq, string eq, int n, int m)
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

        public int solution2(string ineq, string eq, int n, int m)
        {
            int answer = 0;

            switch (ineq + eq)
            {
                case "<=":
                    answer = n <= m ? 1 : 0;
                    break;
                case "<!":
                    answer = n < m ? 1 : 0;
                    break;
                case ">=":
                    answer = n >= m ? 1 : 0;
                    break;
                case ">!":
                    answer = n > m ? 1 : 0;
                    break;
                default:
                    break;
            }

            return answer;
        }

        public int solution3(string ineq, string eq, int n, int m)
        {
            int answer = 0;
            string ie = ineq + eq;

            if (ie == ">=") return n >= m ? 1 : 0;
            if (ie == ">!") return n > m ? 1 : 0;
            if (ie == "<=") return n <= m ? 1 : 0;
            if (ie == "<!") return n < m ? 1 : 0;

            return answer;
        }
    }
}
