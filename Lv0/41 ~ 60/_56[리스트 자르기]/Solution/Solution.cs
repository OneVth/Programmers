using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n, int[] slicer, int[] num_list)
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
    }
}
