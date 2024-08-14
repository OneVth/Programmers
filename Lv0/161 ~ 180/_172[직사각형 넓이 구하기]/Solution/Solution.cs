using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[,] dots)
        {
            int dx = 0, dy = 0;

            for (int i = 0; i < dots.GetLength(0); i++)
            {
                if (0 != dots[0, 0] - dots[i, 0])
                    dx = dots[0, 0] - dots[i, 0];

                if (0 != dots[0, 1] - dots[i, 1])
                    dy = dots[0, 1] - dots[i, 1];
            }
            return Math.Abs(dx * dy);
        }
    }
}
