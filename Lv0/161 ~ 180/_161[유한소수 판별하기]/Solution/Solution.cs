using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b)
        {
            int GCD = 0, denominator = 0;
            int x = a, y = b;

            // 두 수의 공약수 구하기
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }

            GCD = x;

            // 분모를 최대공약수로 약분
            denominator = b / GCD;

            // 분모가 2와 5만을 소인수로 갖는지 확인
            while (denominator % 2 == 0)
                denominator /= 2;

            while (denominator % 5 == 0)
                denominator /= 5;

            return denominator == 1 ? 1 : 2;
        }
    }
}
