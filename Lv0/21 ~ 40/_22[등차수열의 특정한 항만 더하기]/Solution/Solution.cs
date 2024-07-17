using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int a, int d, bool[] included)
        {
            int answer = 0;

            for (int i = 0; i < included.Length; i++)
            {
                answer += included[i] ? a + i * d : 0;
            }
            return answer;
        }

        public int solution2(int a, int d, bool[] included)
        {
            return Enumerable.Range(0, included.Length).Sum(s => included[s] ? a + s * d : 0);
        }

        public int solution3(int a, int d, bool[] included)
        {
            return Enumerable.Range(0, included.Length)
                .Select(s => a + s * d)
                .Where((w, index) => included[index])
                .Sum();
        }
    }
}
