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
            int x1 = dots[0, 0], y1 = dots[0, 1];
            int x2 = dots[1, 0], y2 = dots[1, 1];
            int x3 = dots[2, 0], y3 = dots[2, 1];
            int x4 = dots[3, 0], y4 = dots[3, 1];

            if (
                AreLinesParallel(x1, y1, x2, y2, x3, y3, x4, y4) ||
                AreLinesParallel(x1, y1, x3, y3, x2, y2, x4, y4) ||
                AreLinesParallel(x1, y1, x4, y4, x2, y2, x3, y3)
            )
                return 1;

            return 0;
        }

        public bool AreLinesParallel(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int width1 = Math.Abs(x2 - x1), height1 = Math.Abs(y2 - y1);
            int width2 = Math.Abs(x4 - x3), height2 = Math.Abs(y4 - y3);
            int gcd1 = GetGCD(width1, height1);
            int gcd2 = GetGCD(width2, height2);

            // 각 분자 분모를 최대공약수로 나눈 결과가 같으면 평행임
            return (width1 / gcd1 == width2 / gcd2) && (height1 / gcd1 == height2 / gcd2);
        }

        // 최대 공약수 구하기
        public int GetGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public int solution2(int[,] dots)
        {
            bool parallel =
                IsParallel(dots[0, 0] - dots[1, 0], dots[0, 1] - dots[1, 1], dots[2, 0] - dots[3, 0], dots[2, 1] - dots[3, 1]) ||
                IsParallel(dots[0, 0] - dots[2, 0], dots[0, 1] - dots[2, 1], dots[1, 0] - dots[3, 0], dots[1, 1] - dots[3, 1]) ||
                IsParallel(dots[0, 0] - dots[3, 0], dots[0, 1] - dots[3, 1], dots[1, 0] - dots[2, 0], dots[1, 1] - dots[2, 1]);

            return parallel ? 1 : 0;
        }

        public bool IsParallel(int x1, int y1, int x2, int y2)
        {
            return y1 * x2 == y2 * x1;
        }
    }
}
