using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] numbers, int num1, int num2)
        {
            int length = num2 - num1 + 1;
            int[] answer = new int[length];
            Array.Copy(numbers, num1, answer, 0, length);
            return answer;
        }

        public int[] solution2(int[] numbers, int num1, int num2)
        {
            return numbers.Skip(num1).Take(num2 - num1 + 1).ToArray();
        }
    }
}
