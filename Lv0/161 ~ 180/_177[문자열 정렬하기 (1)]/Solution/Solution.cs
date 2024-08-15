using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(string my_string)
        {
            return my_string
                .Where(w => char.IsNumber(w))
                .Select(s => int.Parse(s.ToString()))
                .OrderBy(o => o)
                .ToArray();
        }
    }
}
