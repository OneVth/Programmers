using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] num_list, int n)
        {
            return num_list.Where((w, index) => index % n == 0).ToArray();
        }

        public int[] solution2(int[] num_list, int n)
        {
            int[] answer = new int[(num_list.Length + n - 1) / n];
            for (int i = 0; i < answer.Length; i++) answer[i] = num_list[i * n];
            return answer;
        }
    }
}
