using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int length = num2 - num1 + 1;
            int[] answer = new int[length];
            Array.Copy(numbers, num1, answer, 0, length);
            return answer;
        }
    }
}
