using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[,] lines)
        {
            int answer = 0;
            int aStart = lines[0, 0], aEnd = lines[0, 1];
            int bStart = lines[1, 0], bEnd = lines[1, 1];
            int cStart = lines[2, 0], cEnd = lines[2, 1];

            int ABStart = Math.Max(aStart, bStart);
            int ABEnd = Math.Min(aEnd, bEnd);
            int BCStart = Math.Max(bStart, cStart);
            int BCEnd = Math.Min(bEnd, cEnd);
            int CAStart = Math.Max(cStart, aStart);
            int CAEnd = Math.Min(cEnd, aEnd);

            // 겹치는 선분 더하기
            if (ABStart < ABEnd)
                answer += ABEnd - ABStart;
            if (BCStart < BCEnd)
                answer += BCEnd - BCStart;
            if (CAStart < CAEnd)
                answer += CAEnd - CAStart;

            // 중복 부분 빼기
            int tripleStart = Math.Max(ABStart, CAStart);
            int tripleEnd = Math.Min(ABEnd, BCEnd);

            if (tripleStart < tripleEnd)
                answer -= (tripleEnd - tripleStart) * 2;

            return answer;
        }
    }
}
