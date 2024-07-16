using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string number)
        {
            int answer = 0;
            List<int> container = new List<int>();
            foreach (char c in number)
            {
                container.Add(int.Parse(c.ToString()));
            }
            answer = container.Sum() % 9;
            return answer;
        }
    }
}
