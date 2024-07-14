using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] num_list)
        {

            int length = num_list.Length;
            int[] answer = new int[length + 1];

            for (int i = 0; i < length; i++)
            {
                answer[i] = num_list[i];
            }

            answer[length] = num_list[length - 1] > num_list[length - 2] ? 
                num_list[length - 1] - num_list[length - 2] : 
                num_list[length - 1] * 2;

            return answer;
        }
    }
}
