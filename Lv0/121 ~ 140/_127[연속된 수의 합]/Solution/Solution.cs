using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int num, int total)
        {
            List<int> answer = new List<int>();
            int std = total / num; // 기준 잡기

            int right = std, left = std;

            answer.Add(std);
            for(int i = 0; i < num - 1; i++)
            {
                if(i % 2 == 0)
                    answer.Add(++right);
                else
                    answer.Add(--left);
            }

            answer.Sort();
            return answer.ToArray();
        }
        public int[] solution2(int num, int total)
        {
            int midpoint = total / num;
            int start = midpoint - (num - 1) / 2;

            return Enumerable.Range(start, num).ToArray();
        }
    }
}
