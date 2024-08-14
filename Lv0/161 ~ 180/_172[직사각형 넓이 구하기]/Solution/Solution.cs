using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[,] dots)
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

        public int solution2(int[,] dots)
        {
            int[] xCoords = new int[] { dots[0, 0], dots[1, 0], dots[2, 0], dots[3, 0] }.Distinct().ToArray();
            int[] yCoords = new int[] { dots[0, 1], dots[1, 1], dots[2, 1], dots[3, 1] }.Distinct().ToArray();

            int length = (int)Math.Abs(yCoords.Max() - yCoords.Min());
            int width = (int)Math.Abs(xCoords.Max() - xCoords.Min());

            return length * width;
        }
    }
}
