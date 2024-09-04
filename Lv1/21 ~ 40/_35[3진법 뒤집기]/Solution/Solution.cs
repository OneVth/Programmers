using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n)
        {
            int answer = 0;
            int length = 0;

            // 3진법 길이 구하기
            while (n >= Math.Pow(3, length))
            {
                length++;
            }

            // 3진법으로 변환 + 앞뒤 반전 + 10진법으로 변환 동시에
            for (int i = length - 1, j = 0; i >= 0; i--, j++)
            {
                answer += n / (int)Math.Pow(3, i) * (int)Math.Pow(3, j);
                n = n % (int)Math.Pow(3, i);
            }

            return answer;
        }

        public int solution2(int n)
        {
            int answer = 0;

            while (n > 0)
            {
                answer *= 3;
                answer += n % 3;
                n /= 3;
            }

            return answer;
        }
    }
}
