using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            answer = arr.Where(w => w % divisor == 0).OrderBy(o => o).ToArray();
            return answer.Length == 0 ? new int[] { -1 } : answer;
        }
    }
}
