using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[,] sizes)
        {
            int width = 0;
            int height = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                int longer = sizes[i, 0] > sizes[i, 1] ? sizes[i, 0] : sizes[i, 1];
                int shorter = sizes[i, 0] > sizes[i, 1] ? sizes[i, 1] : sizes[i, 0];

                width = longer > width ? longer : width;
                height = shorter > height ? shorter : height;
            }

            return width * height;
        }
    }
}
