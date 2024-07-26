using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, string alp)
        {
            return my_string.Replace(alp, alp.ToUpper());
        }
    }
}
