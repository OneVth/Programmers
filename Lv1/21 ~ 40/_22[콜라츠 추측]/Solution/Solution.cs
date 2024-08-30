using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int num)
        {
            int answer = -1;
            long tmp = (long)num;

            int i = 0;
            while (i < 500)
            {
                if (tmp == 1)
                    return i;

                if (tmp % 2 == 0)
                    tmp /= 2;
                else
                    tmp = tmp * 3 + 1;

                i++;
            }

            return answer;
        }
    }
}
