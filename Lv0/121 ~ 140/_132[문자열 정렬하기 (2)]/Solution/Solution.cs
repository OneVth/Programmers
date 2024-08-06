using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string)
        {
            return new string(my_string.ToLower().OrderBy(o => o).ToArray());
        }

        public string solution2(string my_string)
        {
            return string.Concat(my_string.ToLower().OrderBy(c => c));
        }
    }
}
