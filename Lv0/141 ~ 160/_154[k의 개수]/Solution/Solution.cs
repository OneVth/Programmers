using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int i, int j, int k)
        {
            int answer = 0;

            for (; i <= j; i++)
            {
                answer += i.ToString().Count(c => c == '0' + k);
            }

            return answer;
        }

        public int solution2(int i, int j, int k)
        {
            return Enumerable.Range(i, j - i + 1)
                .Select(x => x.ToString().Where(y => y.Equals(k.ToString().First())).Count())
                .Sum();
        }

        public int solution3(int i, int j, int k)
        {
            return Enumerable.Range(i, j - i + 1).Sum(x => x.ToString().Count(o => o.ToString() == k.ToString()));
        }
    }
}
