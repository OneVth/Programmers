using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int n)
        {
            return Enumerable.Range(1, n).Where(w => w % 2 != 0).ToArray();
        }

        public int[] solution2(int n)
        {
            int[] answer = new int[(n + 1) / 2];
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                answer[i] = (i << 1) + 1;
            }
            return answer;
        }
    }
}
