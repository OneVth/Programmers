using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] array)
        {
            int[] answer = new int[2];

            answer[0] = array.Max();
            answer[1] = Array.IndexOf(array, answer[0]);
            return answer;
        }

        public int[] solution2(int[] array)
        {
            return new int[2] { array.Max(), Array.IndexOf(array, array.Max()) };
        }
    }
}
