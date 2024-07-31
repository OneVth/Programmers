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
            return num_list.Skip(n - 1).ToArray();
        }

        public int[] solution2(int[] num_list, int n)
        {
            int[] answer = new int[num_list.Length - n + 1];

            for (int i = n - 1, j = 0; i < num_list.Length; i++, j++) answer[j] = num_list[i];

            return answer;
        }
    }
}
