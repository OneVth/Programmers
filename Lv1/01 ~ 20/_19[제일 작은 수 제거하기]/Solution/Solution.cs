using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            int min = arr.Min();

            answer = arr.Where(w => w != min).ToArray();

            return answer.Length == 0 ? new int[] { -1 } : answer;
        }
    }
}
