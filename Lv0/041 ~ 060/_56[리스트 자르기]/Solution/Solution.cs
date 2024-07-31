using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int n, int[] slicer, int[] num_list)
        {
            int[] answer = new int[] { };
            int a = slicer[0];
            int b = slicer[1];
            int c = slicer[2];

            switch (n)
            {
                case 1:
                    answer = num_list.Take(b + 1).ToArray();
                    break;
                case 2:
                    answer = num_list.Skip(a).ToArray();
                    break;
                case 3:
                    answer = num_list.Skip(a).Take(b - a + 1).ToArray();
                    break;
                case 4:
                    answer = num_list.Skip(a).Take(b - a + 1).Where((w, index) => index % c == 0).ToArray();
                    break;
            }
            return answer;
        }

        public int[] solution2(int n, int[] slicer, int[] num_list)
        {
            int start = 0;
            int end = num_list.Length - 1;
            int term = 1;

            if(n == 1) // 0번 인덱스부터 b번 인덱스까지
            {
                end = slicer[1];
            }
            else if(n == 2) // a번 인덱스부터 마지막 인덱스까지
            {
                start = slicer[0];
            }
            else if(n == 3) // a번 인덱스부터 b번 인덱스까지
            {
                start = slicer[0];
                end = slicer[1];
            }
            else // a번 인덱스부터 b번 인덱스까지 c 간격으로
            {
                start = slicer[0];
                end = slicer[1];
                term = slicer[2];
            }

            var list = new List<int>();
            for (int i = start; i <= end; i += term)
                list.Add(num_list[i]);

            return list.ToArray();
        }
    }
}
