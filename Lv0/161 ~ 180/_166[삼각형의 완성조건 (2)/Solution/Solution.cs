using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] sides)
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
    }
}
