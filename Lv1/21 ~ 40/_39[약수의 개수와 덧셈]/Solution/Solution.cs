using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                answer += (GetDivisorCount(i) % 2) == 0 ? i : -i;
            }

            return answer;
        }

        int GetDivisorCount(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            return count;
        }
    }
}
