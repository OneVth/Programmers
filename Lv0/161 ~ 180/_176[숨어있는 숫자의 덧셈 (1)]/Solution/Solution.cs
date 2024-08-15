using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string my_string)
        {
            int answer = 0;

            foreach (char c in my_string)
            {
                if (int.TryParse(c.ToString(), out int i))
                    answer += i;
            }

            return answer;
        }

        public int solution2(string my_string)
        {
            return my_string.Where(x => char.IsNumber(x)).Sum(x => Convert.ToInt32(x.ToString()));
        }
    }
}
