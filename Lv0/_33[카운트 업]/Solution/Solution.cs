using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int start_num, int end_num)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();

            for (int i = start_num; i <= end_num; i++)
            {
                list.Add(i);
            }

            answer = list.ToArray();

            return answer;
        }

        public int[] solution2(int start_num, int end_num)
        {
            return Enumerable.Range(start_num, end_num - start_num + 1).ToArray();
        }
    }
}
