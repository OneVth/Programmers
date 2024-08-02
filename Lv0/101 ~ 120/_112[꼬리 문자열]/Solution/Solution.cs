using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string[] str_list, string ex)
        {
            return string.Join("", str_list.Where(w => !w.Contains(ex)));
        }
    }
}
