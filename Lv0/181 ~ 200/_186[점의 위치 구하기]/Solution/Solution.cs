using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] dot)
        {
            int answer = 0;

            if (0 < dot[0])
            {
                answer = 0 < dot[1] ? 1 : 4;
            }
            else
            {
                answer = 0 > dot[1] ? 3 : 2;
            }

            return answer;
        }

        public int solution2(int[] dot)
        {
            int x = dot[0];
            int y = dot[1];

            if (0 < x && 0 < y)
                return 1; // First Quadrant
            else if (0 > x && 0 < y)
                return 2; // Second Quadrant
            else if (0 > x && 0 > y)
                return 3; // Third Quadrant
            else if (0 < x && 0 > y)
                return 4; // Fourth Quadrant

            return 0;
        }
    }
}
