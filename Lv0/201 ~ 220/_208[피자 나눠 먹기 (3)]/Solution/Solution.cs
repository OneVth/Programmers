using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int slice, int n)
        {
            int answer = 0;

            while (n > answer * slice)
                answer++;

            return answer;
        }

        public int solution2(int slice, int n)
        {
            return (n + slice - 1) / slice;
        }
    }
}
