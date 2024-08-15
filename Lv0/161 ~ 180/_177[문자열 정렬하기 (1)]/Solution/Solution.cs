using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(string my_string)
        {
            return my_string
                .Where(w => char.IsNumber(w))
                .Select(s => int.Parse(s.ToString()))
                .OrderBy(o => o)
                .ToArray();
        }

        public int[] solution2(string my_string)
        {
            my_string = Regex.Replace(my_string, "[^0-9]", "");
            int[] answer = my_string.Select(x => int.Parse(x.ToString())).ToArray();
            Array.Sort(answer);
            return answer;
        }
    }
}
