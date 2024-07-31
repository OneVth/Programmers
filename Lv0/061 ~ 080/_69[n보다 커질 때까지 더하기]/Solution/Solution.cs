using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] numbers, int n)
        {
            int answer = 0;
            int i = 0;

            while (answer <= n)
            {
                answer += numbers[i];
                i++;
            }

            return answer;
        }

        public int solution2(int[] numbers, int n)
        {
            int answer = 0;
            foreach (int item in numbers)
            {
                answer += item;
                if (answer > n) break;
            }
            return answer;
        }
    }
}
