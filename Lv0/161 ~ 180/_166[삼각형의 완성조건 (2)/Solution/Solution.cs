using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] sides)
        {
            int answer = 0;
            int bigger = Math.Max(sides[0], sides[1]);
            int smaller = Math.Min(sides[0], sides[1]);

            // case1 
            // bigger가 가장 긴 변의 길이일 경우
            answer += smaller;

            // case2
            // 나머지 변 n이 가장 긴 변의 길이일 경우
            answer += smaller - 1;
            return answer;
        }

        public int solution2(int[] sides)
        {
            int a = 0, b = 0;

            int[] temp = sides.OrderBy(o => o).ToArray();
            a = sides[0];
            b = sides[1];

            // Possible range for the third side c
            int min_c = b - a + 1;
            int max_c = b + a - 1;

            // The number of possible valid values for c
            return max_c - min_c + 1;
        }
    }
}
