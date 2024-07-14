using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] num_list)
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

        public int[] solution2(int[] num_list)
        {
            int l = num_list.Length - 1;
            int a = num_list[l] > num_list[l - 1] ? num_list[l] - num_list[l - 1] : num_list[l] * 2;
            Array.Resize(ref num_list, l + 2);
            num_list[l + 1] = a;
            return num_list;
        }
    }
}
