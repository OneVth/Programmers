using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] d, int budget)
        {
            int answer = 0;
            int[] ordered = d.OrderBy(o => o).ToArray();

            for (int i = 0; i < d.Length; i++)
            {
                if (budget >= ordered[i])
                {
                    budget -= ordered[i];
                    answer++;
                    if (budget == 0)
                        break;
                }
                else
                    continue;
            }

            return answer;
        }
    }
}
