using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string)
        {
            return new string(my_string.ToLower().OrderBy(o => o).ToArray());
        }
    }
}
