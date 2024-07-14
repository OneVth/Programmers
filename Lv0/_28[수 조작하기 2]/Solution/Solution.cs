using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(int[] numLog)
        {
            string answer = "";
            for (int i = 1; i < numLog.Length; i++)
            {
                switch (numLog[i] - numLog[i - 1])
                {
                    case 1:
                        answer += "w";
                        break;
                    case -1:
                        answer += "s";
                        break;
                    case 10:
                        answer += "d";
                        break;
                    case -10:
                        answer += "a";
                        break;
                    default:
                        break;
                }
            }
            return answer;
        }
    }
}
