using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();

            list.Add(n);
            while (n != 1)
            {
                switch (n % 2)
                {
                    case 0:
                        n /= 2;
                        break;
                    case 1:
                        n = 3 * n + 1;
                        break;
                    default:
                        break;
                }
                list.Add(n);
            }

            answer = list.ToArray();
            return answer;
        }
    }
}
