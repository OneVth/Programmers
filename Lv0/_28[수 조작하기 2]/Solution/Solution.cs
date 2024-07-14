using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(int[] numLog)
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

        public string solution2(int[] numLog)
        {
            StringBuilder sb = new StringBuilder();
            int n = numLog[0];
            for (int i = 0; i < numLog.Length; i++)
            {
                int next = numLog[i];

                if (n + 1 == next) sb.Append("w");
                else if (n - 1 == next) sb.Append("s");
                else if (n + 10 == next) sb.Append("d");
                else if (n - 10 == next) sb.Append("a");

                n = next;
            }

            return sb.ToString();
        }
    }
}
