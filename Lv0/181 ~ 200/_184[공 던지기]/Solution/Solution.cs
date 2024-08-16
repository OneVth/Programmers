using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] numbers, int k)
        {
            int answer = 1;

            for (int i = 1; i < k; i++)
                answer = (answer + 2) > numbers.Length ? answer + 2 - numbers.Length : answer + 2;

            return answer;
        }

        public int solution2(int[] numbers, int k)
        {
            int position = 0;

            for (int i = 0; i < k - 1; i++)
                position = (position + 2) % numbers.Length;

            return numbers[position];
        }
    }
}
